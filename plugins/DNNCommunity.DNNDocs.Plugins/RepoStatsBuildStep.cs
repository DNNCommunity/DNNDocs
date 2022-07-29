using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using Microsoft.DocAsCode.Plugins;
using Microsoft.DocAsCode.Build.ConceptualDocuments;
using DNNCommunity.DNNDocs.Plugins.Models;
using DNNCommunity.DNNDocs.Plugins.Providers;
using System;

namespace DNNCommunity.DNNDocs.Plugins
{
    [Export(nameof(ConceptualDocumentProcessor), typeof(IDocumentBuildStep))]
    public class RepoStatsBuildStep : IDocumentBuildStep
    {
        #region Build
        public void Build(FileModel model, IHostService host)
        {
            // do nothing
        }
        #endregion

        public int BuildOrder => 2;

        public string Name => nameof(RepoStatsBuildStep);

        #region Postbuild
        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {
            Console.WriteLine($"Processing Repo Stats for {models.Count()} models");
            var rootPath = models[0].BaseDir;
            
            List<Contributor> gitContributors = GitHubApi.Instance(rootPath).GetContributors(models);
            Console.WriteLine($"Found {gitContributors.Count()} contributors");

            List<Commits> gitCommits = GitHubApi.Instance(rootPath).GetCommits(models, "");
            Console.WriteLine($"Found {gitCommits.Count()} commits");

            if (gitContributors.Any() && gitCommits.Any())
            {
                foreach (var model in models.Select((value, index) => new { value, index }))
                {
                    Console.WriteLine($"Processing model {model.index} of {models.Count()}");
                    if (model.value.Type == DocumentType.Article)
                    {
                        var content = (Dictionary<string, object>)model.value.Content;
                        Console.WriteLine($"Processing Article : {model.value.OriginalFileAndType.FullPath}");
                        for (var i = 1; i < 6; i++)
                        {
                            try
                            {
                                content["gitContributor" + i + "Contributions"] = gitContributors[i - 1].Contributions;
                                Console.WriteLine($"Added contributor {i} contributions: {gitContributors[i - 1].Contributions}");
                                content["gitContributor" + i + "Login"] = gitContributors[i - 1].Login;
                                Console.WriteLine($"Added contributor {i} login: {gitContributors[i-1].Login}");
                                content["gitContributor" + i + "AvatarUrl"] = gitContributors[i - 1].AvatarUrl;
                                Console.WriteLine($"Added contributor {i} avatar url: {gitContributors[i - 1].AvatarUrl}");
                                content["gitContributor" + i + "HtmlUrl"] = gitContributors[i - 1].HtmlUrl;
                                Console.WriteLine($"Added contributor {i} html url: {gitContributors[i - 1].HtmlUrl}");
                            }
                            catch (Exception)
                            {
                                // Ignore failures
                            }
                        }

                        var groupedCommits = gitCommits.GroupBy(x => x?.Author?.Login);
                        Console.WriteLine($"Found {groupedCommits.Count()} grouped commits.");

                        groupedCommits = groupedCommits.OrderByDescending(x => x.Count());
                        Console.WriteLine("Ordered the grouped commits by count.");

                        var commits = groupedCommits.Select(x => x.FirstOrDefault());
                        Console.WriteLine($"Found {commits.Count()} commits as in the first group.");

                        commits = commits.Take(5);
                        Console.WriteLine($"Took the top {commits.Count()} commits only.");

                        foreach (var commit in commits.Select((value, index) => new { value, index }))
                        {
                            try
                            {
                                Console.WriteLine($"Adding commit {commit.index} from: {commit.value.Author.Login}");
                                content["gitRecentContributor" + commit.index + "Login"] = commit.value.Author.Login;
                                content["gitRecentContributor" + commit.index + "AvatarUrl"] = commit.value.Author.AvatarUrl;
                                content["gitRecentContributor" + commit.index + "HtmlUrl"] = commit.value.Author.HtmlUrl;
                            }
                            catch (Exception)
                            {
                                // Ignore failures
                            }
                            finally{
                                Console.WriteLine($"Processed commit {commit.index} of {commits.Count()}");
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Prebuild
        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }
        #endregion

    }
}
