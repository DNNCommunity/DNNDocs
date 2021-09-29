using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using Microsoft.DocAsCode.Plugins;
using Microsoft.DocAsCode.Build.ConceptualDocuments;
using DNNCommunity.DNNDocs.Plugins.Models;
using DNNCommunity.DNNDocs.Plugins.Providers;
using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins
{
    [Export(nameof(ConceptualDocumentProcessor), typeof(IDocumentBuildStep))]
    public class PageStatsBuildStep : IDocumentBuildStep
    {
        #region Build
        public void Build(FileModel model, IHostService host)
        {
            // do nothing
        }
        #endregion

        public int BuildOrder => 3;

        public string Name => nameof(PageStatsBuildStep);

        #region Postbuild
        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {
            var rootPath = models[0].BaseDir;
            foreach (var model in models)
            {
                if (model.Type == DocumentType.Article)
                {
                    string transformedFilePathFromRoot = model.LocalPathFromRoot.Replace("/", "%2F");
                    List<Commits> gitCommits = GitHubApi.Instance(rootPath).GetCommits(models, transformedFilePathFromRoot);

                    if (gitCommits != null && gitCommits.Count > 0)
                    {
                        var commits = gitCommits
                            .Where(x => x.Author != null)
                            .GroupBy(x => x.Author.Login)
                            .OrderByDescending(x => x.Count())
                            .Select(x => x.FirstOrDefault())
                            .Take(5);

                        var content = (Dictionary<string, object>)model.Content;

                        int index = 1;
                        foreach (var commit in commits)
                        {
                            content["gitPageContributor" + index + "Login"] = commit.Author.Login;
                            content["gitPageContributor" + index + "AvatarUrl"] = commit.Author.AvatarUrl;
                            content["gitPageContributor" + index + "HtmlUrl"] = commit.Author.HtmlUrl;
                            index++;
                        }

                        content["gitPageDate"] = System.DateTime.Parse(gitCommits[0].Commit.Author.Date).ToShortDateString();
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
