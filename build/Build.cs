using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
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

    [Solution] readonly Solution Solution;

    const string pluginsProjectName = "DNNCommunity.DNNDocs.Plugins";

    // Define directories
    AbsolutePath siteDirectory = RootDirectory / "_site";
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
            DocFXBuild(s => s.SetConfigFile(RootDirectory / "docfx.json"));
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
}
