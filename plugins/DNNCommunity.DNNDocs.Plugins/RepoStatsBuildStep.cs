using System.Collections.Immutable;
using System.Composition;
using System.Diagnostics;
using DNNCommunity.DNNDocs.Plugins.Models;
using DNNCommunity.DNNDocs.Plugins.Providers;
using Docfx.Plugins;
using Octokit;

namespace DNNCommunity.DNNDocs.Plugins
{
    [Export("ConceptualDocumentProcessor", typeof(IDocumentBuildStep))]
    public class RepoStatsBuildStep : IDocumentBuildStep
    {
        public string Name => nameof(RepoStatsBuildStep);

        public int BuildOrder => 2;

        public RepoStatsBuildStep()
        {
            Console.WriteLine($"[plugin] {nameof(RepoStatsBuildStep)} loaded.");
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

            Console.WriteLine($"[PLUGIN] {nameof(RepoStatsBuildStep)} Processing Repo Stats for {models.Count()} models");

            var gitHubApi = new GitHubApi();
            var contributors = gitHubApi.GetContributorsAsync().GetAwaiter().GetResult();
            Console.WriteLine($"Found {contributors.Count} contributors");

            var commits = gitHubApi.GetCommitsAsync().GetAwaiter().GetResult();
            Console.WriteLine($"Found {commits.Count} commits");

            if (contributors.Any() && commits.Any())
            {
                foreach (var model in models.Select((value, index) => new { value, index }))
                {
                    Console.WriteLine($"Processing model {model.index + 1} of {models.Count}");

                    if (model.value.Type == DocumentType.Article)
                    {
                        var content = (Dictionary<string, object>)model.value.Content;
                        Console.WriteLine($"Processing Article : {model.value.OriginalFileAndType.FullPath}");

                        // Add top 5 contributors (or fewer if not enough)
                        for (var i = 0; i < Math.Min(5, contributors.Count); i++)
                        {
                            var contributor = contributors[i];
                            content[$"gitContributor{i + 1}Contributions"] = contributor.Total;
                            content[$"gitContributor{i + 1}Login"] = contributor.Author.Login;
                            content[$"gitContributor{i + 1}AvatarUrl"] = contributor.Author.AvatarUrl;
                            content[$"gitContributor{i + 1}HtmlUrl"] = contributor.Author.HtmlUrl;

                            Console.WriteLine($"Added contributor {i + 1}: {contributor.Author.Login}");
                        }

                        // Group commits by author login and order by number of commits
                        var groupedCommits = commits
                            .Where(c => c.Author != null && c.Author.Login != null)
                            .GroupBy(c => c.Author.Login)
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.First())
                            .Take(5)
                            .ToList();

                        Console.WriteLine($"Selected top {groupedCommits.Count} recent contributors based on commits.");

                        for (var i = 0; i < groupedCommits.Count; i++)
                        {
                            var commit = groupedCommits[i];
                            var author = commit.Author;

                            content[$"gitRecentContributor{i}Login"] = author.Login;
                            content[$"gitRecentContributor{i}AvatarUrl"] = author.AvatarUrl;
                            content[$"gitRecentContributor{i}HtmlUrl"] = author.HtmlUrl;

                            Console.WriteLine($"Added recent contributor {i}: {author.Login}");
                        }
                    }
                }
            }
        }

        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }
    }
}
