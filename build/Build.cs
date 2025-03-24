using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.Git;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using Nuke.Common.Tools.NuGet;

[GitHubActions(
    "PR_Validation",
    GitHubActionsImage.WindowsLatest,
    ImportSecrets = new[] { "GithubToken" },
    OnPullRequestBranches = new[] { "main" },
    InvokedTargets = new[] { nameof(Compile) })]
[GitHubActions(
    "Deploy",
    GitHubActionsImage.WindowsLatest,
    ImportSecrets = new[] { "GithubToken", "ACCESS_TOKEN" },
    OnPushBranches = new[] { "main" },
    InvokedTargets = new[] { nameof(Deploy) })]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    // Default target is defined here for when the build is called without a target.
    public static int Main() => Execute<Build>(x => x.Serve);

    [NuGetPackage(
        packageId: "docfx",
        packageExecutable: "docfx.dll"
    )]
    readonly Tool DnnDocFX;

    // Project specific constants
    private const string organizationName = "DNNCommunity";
    private const string repositoryName = "DNNDocs";
    private const string pluginsProjectName = "DNNCommunity.DNNDocs.Plugins";

    // CLI parameters.
    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;
    [Parameter("Github Token")]
    readonly string GithubToken;

    // Nuke features injection.
    [Solution] readonly Solution Solution;
    [GitRepository] readonly GitRepository gitRepository;

    // Define directories
    AbsolutePath siteDirectory = RootDirectory / "docs";
    AbsolutePath pluginsDirectory = RootDirectory / "templates" / "dnn-docs" / "plugins";
    AbsolutePath dnnPlatformDirectory = RootDirectory / "Dnn.Platform";

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            siteDirectory.CreateOrCleanDirectory();
            pluginsDirectory.CreateOrCleanDirectory();
            dnnPlatformDirectory.CreateOrCleanDirectory();
        });

    Target Restore => _ => _
        .Executes(() =>
        {
            var projects = Solution.AllProjects;
            projects.ForEach(project => DotNetRestore(s => s.SetProjectFile(project)));
        });

    Target BuildPlugins => _ => _
    .DependsOn(Clean)
    .DependsOn(Restore)
    .Executes(() =>
    {
        var project = Solution.AllProjects.FirstOrDefault(p => p.Name.Contains("Plugins"));
        DotNetBuild(s => s
            .SetProjectFile(project)
            .SetConfiguration(Configuration));
        DotNetPublish(s => s
            .SetProject(project)
            .SetConfiguration(Configuration)
            .SetOutput(pluginsDirectory));
    });

    Target PullDnnPackages => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            var packages = new string[] {
                "DotNetNuke.Core",
                "DotNetNuke.Abstractions",
                "DotNetNuke.DependencyInjection",
                "DotNetNuke.Instrumentation",
                "Dnn.PersonaBar.Library",
                "DotNetNuke.Providers.FolderProviders",
                "DotNetNuke.SiteExportImport",
                "DotNetNuke.Web",
                "DotNetNuke.Web.Client",
                "DotNetNuke.Web.Mvc",
            };
            packages.ForEach(package =>
                NuGetTasks.NuGetInstall(_ => _
                    .SetPackageID(package)
                    .SetOutputDirectory(RootDirectory / "packages")));
        });

    Target Compile => _ => _
        .DependsOn(Clean)
        .DependsOn(Restore)
        .DependsOn(BuildPlugins)
        .DependsOn(PullDnnPackages)
        .Executes(() =>
        {
            DnnDocFX?.Invoke("metadata", RootDirectory);
            DnnDocFX?.Invoke("build", RootDirectory);
        });

    Target Serve => _ => _
        .DependsOn(Clean)
        .DependsOn(Restore)
        .DependsOn(BuildPlugins)
        .Executes(() =>
        {
            DnnDocFX?.Invoke("--serve --open-browser", RootDirectory);
        });

    Target CreateDeployBranch => _ => _
        .Before(Compile)
        .Executes(() =>
        {
            // Because in CI we are in detached head,
            // we create a local deploy branch to track our commit.
            Git("switch -c deploy");
        });

    Target Deploy => _ => _
        .OnlyWhenDynamic(() => gitRepository.ToString() == $"https://github.com/{organizationName}/{repositoryName}")
        .DependsOn(CreateDeployBranch)
        .DependsOn(Compile)
        .Executes(() => {
            Git("config --global user.name 'DNN Community'");
            Git("config --global user.email 'info@dnncommunity.org'");
            Git($"remote set-url origin https://{organizationName}:{GithubToken}@github.com/{organizationName}/{repositoryName}.git");
            Git("status");
            Git("add docs -f"); // Force adding because it is usually gitignored.
            Git("status");
            var latestBuildMessage = "Commit latest build";
            Git($"commit --allow-empty -m {latestBuildMessage}"); // We allow an empty commit in case the last change did not affect the site.
            Git("status");
            Git("fetch origin");
            Git("status");
            Git("checkout -b site origin/site"); // pulling a local copy of the current deployment.
            Git("status");
            Git("rm -r ."); // Delete all files before so we have a diff if something is no longer present in the new build.
            Git("status");
            Git("checkout deploy -- docs"); // pulls only docs from our temporary deploy branch.
            Git("status");

            (RootDirectory / "docs" / "CNAME").WriteAllText("docs.dnncommunity.org");

            Git("add docs"); // stage the docs
            Git("status");
            Git($"commit --allow-empty -m {latestBuildMessage}");
            Git("status");
            Git("push origin site"); // Should push only the change with linear history and a proper diff.
            Git("checkout deploy");
        });
}
