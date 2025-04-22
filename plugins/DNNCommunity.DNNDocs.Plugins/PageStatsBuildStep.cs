using System.Collections.Immutable;
using System.Composition;
using System.Diagnostics;
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
            Console.WriteLine($"[PLUGIN] {nameof(PageStatsBuildStep)} loaded.");
        }

        public void Build(FileModel model, IHostService host)
        {
        }

        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {

            if (models == null || models.Count == 0)
            {
                Console.WriteLine("[PLUGIN] No models to process.");
                return;
            }

            Console.WriteLine($"[PLUGIN] {nameof(PageStatsBuildStep)} Processing {models.Count} models");

            var gitHubApi = new GitHubApi(); // Optionally pass token

            foreach (var model in models)
            {

                if (model.Type != DocumentType.Article) continue;

                // Build the relative path for the GitHub API query
                string transformedFilePath = model.LocalPathFromRoot.Replace("/", "%2F");

                // Get commits for the specific page/file
                var gitCommits = gitHubApi.GetCommitsAsync(model.LocalPathFromRoot).GetAwaiter().GetResult();

                if (gitCommits != null && gitCommits.Count > 0)
                {
                    // Group by author login and order by number of commits
                    var topContributors = gitCommits
                        .Where(c => c.Author != null && !string.IsNullOrEmpty(c.Author.Login))
                        .GroupBy(c => c.Author.Login)
                        .OrderByDescending(g => g.Count())
                        .Select(g => g.First())
                        .Take(5)
                        .ToList();

                    var content = (Dictionary<string, object>)model.Content;

                    var contributorsList = new List<string>();
                    int index = 1;
                    foreach (var commit in topContributors)
                    {
                        content[$"gitPageContributor{index}Login"] = commit.Author.Login;
                        content[$"gitPageContributor{index}AvatarUrl"] = commit.Author.AvatarUrl;
                        content[$"gitPageContributor{index}HtmlUrl"] = commit.Author.HtmlUrl;

                        contributorsList.Add(commit.Author.Login);
                        index++;
                    }

                    // Set the page last updated date based on the latest commit
                    var lastUpdated = gitCommits[0].Commit.Author.Date.DateTime.ToShortDateString();
                    content["gitPageDate"] = lastUpdated;
                    
                    Console.WriteLine($"[PLUGIN] {nameof(PageStatsBuildStep)} processed {model.File} | Contributors: {string.Join(", ", contributorsList)} | Last Updated: {lastUpdated}");
                }
            }
        }


        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }
    }
}
