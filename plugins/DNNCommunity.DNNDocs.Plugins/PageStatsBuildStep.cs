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
    public class PageStatsBuildStep : IDocumentBuildStep
    {
        public string Name => nameof(PageStatsBuildStep);
        
        public int BuildOrder => 3;

        public PageStatsBuildStep()
        {
            Logger.LogInfo($"{nameof(PageStatsBuildStep)} loaded.");
        }

        public void Build(FileModel model, IHostService host)
        {
        }

        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
            => PostbuildAsync(models, host).GetAwaiter().GetResult();

        private async Task PostbuildAsync(ImmutableList<FileModel> models, IHostService host)
        {
            if (models == null || models.Count == 0)
            {
                Logger.LogWarning($"{nameof(PageStatsBuildStep)}: No models to process.");
                return;
            }

            var articleModels = models
                .Where(m => m.Type == DocumentType.Article)
                .Where(m => !m.LocalPathFromRoot.StartsWith("content/reference/", StringComparison.OrdinalIgnoreCase))
                .ToList();
            Logger.LogInfo($"{nameof(PageStatsBuildStep)}: Processing {articleModels.Count} article models (reference pages excluded).");

            var gitHubApi = new GitHubApi();
            var totalSw = Stopwatch.StartNew();

            foreach (var item in articleModels.Select((value, index) => new { value, index }))
            {
                if ((item.index + 1) % 100 == 0 || item.index + 1 == articleModels.Count)
                {
                    Logger.LogInfo($"{nameof(PageStatsBuildStep)}: Processing model {item.index + 1}/{articleModels.Count} ({totalSw.Elapsed.TotalSeconds:F1}s elapsed).");
                }

                var gitCommits = await gitHubApi.GetCommitsAsync(item.value.LocalPathFromRoot);

                if (gitCommits != null && gitCommits.Count > 0)
                {
                    var topContributors = gitCommits
                        .Where(c => c.Author != null && !string.IsNullOrEmpty(c.Author.Login))
                        .GroupBy(c => c.Author.Login)
                        .OrderByDescending(g => g.Count())
                        .Select(g => g.First())
                        .Take(5)
                        .ToList();

                    var content = (Dictionary<string, object>)item.value.Content;

                    int index = 1;
                    foreach (var commit in topContributors)
                    {
                        content[$"gitPageContributor{index}Login"] = commit.Author.Login;
                        content[$"gitPageContributor{index}AvatarUrl"] = commit.Author.AvatarUrl;
                        content[$"gitPageContributor{index}HtmlUrl"] = commit.Author.HtmlUrl;
                        index++;
                    }

                    var lastUpdated = gitCommits[0].Commit.Author.Date.DateTime.ToShortDateString();
                    content["gitPageDate"] = lastUpdated;
                }
            }

            Logger.LogInfo($"{nameof(PageStatsBuildStep)}: Finished in {totalSw.Elapsed.TotalSeconds:F1}s.");
        }


        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }
    }
}
