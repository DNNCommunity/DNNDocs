using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.Git;
using Nuke.Common.Tools.DocFX;
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DocFX.DocFXTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.MSBuild.MSBuildTasks;

[GitHubActions(
    "PR_Validation",
    GitHubActionsImage.WindowsLatest,
    GitHubActionsImage.MacOsLatest,
    GitHubActionsImage.UbuntuLatest,
    ImportGitHubTokenAs = "GithubToken",
    OnPullRequestBranches = new[] { "master" },
    InvokedTargets = new[] { nameof(Compile) })]
[GitHubActions(
    "Deploy",
    GitHubActionsImage.WindowsLatest,
    ImportGitHubTokenAs = "GithubToken",
    OnPushBranches = new[] { "master" },
    InvokedTargets = new[] { nameof(Deploy) })]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Serve);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Parameter("Github Token")]
    readonly string GithubToken;

    [Solution] readonly Solution Solution;
    [GitRepository] readonly GitRepository repository;

    const string pluginsProjectName = "DNNCommunity.DNNDocs.Plugins";

    // Define directories
    AbsolutePath siteDirectory = RootDirectory / "docs";
    AbsolutePath pluginsDirectory = RootDirectory / "templates" / "dnn-docs" / "plugins";
    AbsolutePath dnnPlatformDirectory = RootDirectory / "Dnn.Platform";

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            EnsureCleanDirectory(siteDirectory);
            EnsureCleanDirectory(pluginsDirectory);
            EnsureCleanDirectory(dnnPlatformDirectory);
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
        MSBuild(s =>  s
        .SetProjectFile(Solution.GetProject(pluginsProjectName))
        .SetConfiguration(Configuration));
        var sourceFile = Solution.GetProject(pluginsProjectName).Directory / "bin" / Configuration / $"{pluginsProjectName}.dll";
        CopyFileToDirectory(sourceFile, pluginsDirectory, FileExistsPolicy.OverwriteIfNewer, true);
    });

    Target PullDnnRepo => _ => _
    .DependsOn(Clean)
    .Executes(() =>
    {
        GitLogger = (type, output) => Logger.Info(output);
        Git($"clone https://github.com/dnnsoftware/Dnn.Platform.git {dnnPlatformDirectory}");
    });

    Target Compile => _ => _
        .DependsOn(Clean)
        .DependsOn(Restore)
        .DependsOn(BuildPlugins)
        .DependsOn(PullDnnRepo)
        .Executes(() =>
        {
            DocFXMetadata(s => s.SetFilterConfigFile(RootDirectory / "docfx.json"));
            DocFXBuild(s => s.SetConfigFile(RootDirectory / "docfx.json"));
        });

    Target TemplateExportDefault => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DocFXTemplate(s => s
                .SetProcessArgumentConfigurator(a => a.Add("export default")));
        });


    Target Serve => _ => _
        .DependsOn(Clean)
        .DependsOn(Restore)
        .DependsOn(BuildPlugins)
        .DependsOn(PullDnnRepo)
        .Executes(() =>
        {
            DocFXBuild(s => s
                .SetConfigFile(RootDirectory / "docfx.json")
                .EnableServe());
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
        .DependsOn(CreateDeployBranch)
        .DependsOn(Compile)
        .Executes(() => {
            Git("config --global user.name 'DNN Community'");
            Git("config --global user.email 'info@dnncommunity.org'");
            Git($"remote set-url origin https://DNNCommunity:{GithubToken}@github.com/DNNCommunity/DNNDocs.git");
            Git("status");
            Git("add docs -f"); // Force adding because it is usually gitignored.
            Git("status");
            Git("commit --allow-empty -m \"Commit latest build\""); // We allow an empty commit in case the last change did not affect the site.
            Git("status");
            Git("checkout -b site origin/site");
            Git("status");
            Git("cherry-pick deploy"); // This only picks the very last commit on that branch.
            Git("status");
            Git("push origin site"); // Should push only the change with linear history and a proper diff.
        });
}
