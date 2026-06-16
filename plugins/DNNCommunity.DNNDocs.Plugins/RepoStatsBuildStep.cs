using System.Collections.Immutable;
using System.Composition;
using System.Diagnostics;
using Docfx.Common;
using DNNCommunity.DNNDocs.Plugins.Models;
using DNNCommunity.DNNDocs.Plugins.Providers;
using Docfx.Plugins;

namespace DNNCommunity.DNNDocs.Plugins
{
    [Export("ConceptualDocumentProcessor", typeof(IDocumentBuildStep))]
    public class RepoStatsBuildStep : IDocumentBuildStep
    {
        public string Name => nameof(RepoStatsBuildStep);

        public int BuildOrder => 2;

        public RepoStatsBuildStep()
        {
            Logger.LogInfo($"{nameof(RepoStatsBuildStep)} loaded.");
        }

        public void Build(FileModel model, IHostService host)
        {
        }

        // IDocumentBuildStep.Postbuild is a synchronous interface contract; bridge to the async implementation.
        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
            => PostbuildAsync(models, host).GetAwaiter().GetResult();

        private async Task PostbuildAsync(ImmutableList<FileModel> models, IHostService host)
        {
            if (models == null || models.Count == 0)
            {
                Logger.LogWarning($"{nameof(RepoStatsBuildStep)}: No models to process.");
                return;
            }

            var articleModels = models.Where(m => m.Type == DocumentType.Article).ToList();
            Logger.LogInfo($"{nameof(RepoStatsBuildStep)}: Processing repo stats for {articleModels.Count} article models.");

            var gitHubApi = new GitHubApi();

            List<Contributor> contributors;

            try
            {
                var sw = Stopwatch.StartNew();
                contributors = (await gitHubApi.GetContributorsAsync()).ToList();
                Logger.LogInfo($"{nameof(RepoStatsBuildStep)}: Fetched {contributors.Count} contributors in {sw.Elapsed.TotalSeconds:F1}s.");
            }
            catch (Exception ex)
            {
                Logger.LogWarning($"{nameof(RepoStatsBuildStep)}: Failed to retrieve GitHub stats ({ex.Message}). Skipping contributor data for this build.");
                return;
            }

            if (!contributors.Any())
            {
                return;
            }

            // Top contributors: most commits in the sampled window.
            var topContributors = contributors.OrderByDescending(c => c.Total).Take(5).ToList();
            Logger.LogInfo($"{nameof(RepoStatsBuildStep)}: Top contributors: {string.Join(", ", topContributors.Select(c => c.Login))}");

            // Recent contributors: most recent commit date.
            var recentContributors = contributors.OrderByDescending(c => c.LatestCommitDate).Take(5).ToList();
            Logger.LogInfo($"{nameof(RepoStatsBuildStep)}: Recent contributors: {string.Join(", ", recentContributors.Select(c => c.Login))}");

            var totalSw = Stopwatch.StartNew();
            foreach (var item in articleModels.Select((value, index) => new { value, index }))
            {
                if ((item.index + 1) % 100 == 0 || item.index + 1 == articleModels.Count)
                {
                    Logger.LogInfo($"{nameof(RepoStatsBuildStep)}: Stamping model {item.index + 1}/{articleModels.Count} ({totalSw.Elapsed.TotalSeconds:F1}s elapsed).");
                }

                var content = (Dictionary<string, object>)item.value.Content;

                for (var i = 0; i < topContributors.Count; i++)
                {
                    var c = topContributors[i];
                    content[$"gitContributor{i + 1}Contributions"] = c.Total;
                    content[$"gitContributor{i + 1}Login"] = c.Login;
                    content[$"gitContributor{i + 1}AvatarUrl"] = c.AvatarUrl;
                    content[$"gitContributor{i + 1}HtmlUrl"] = c.HtmlUrl;
                }

                for (var i = 0; i < recentContributors.Count; i++)
                {
                    var c = recentContributors[i];
                    content[$"gitRecentContributor{i + 1}Login"] = c.Login;
                    content[$"gitRecentContributor{i + 1}AvatarUrl"] = c.AvatarUrl;
                    content[$"gitRecentContributor{i + 1}HtmlUrl"] = c.HtmlUrl;
                }
            }

            Logger.LogInfo($"{nameof(RepoStatsBuildStep)}: Finished stamping {articleModels.Count} models in {totalSw.Elapsed.TotalSeconds:F1}s.");
        }

        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }
    }
}
