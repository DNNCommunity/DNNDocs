using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using Microsoft.DocAsCode.Plugins;
using Microsoft.DocAsCode.Build.ConceptualDocuments;
using System.Net;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats
{
    internal class Commits
    {
        [JsonProperty(PropertyName = "commit")]
        public Commit Commit { get; set; }

        [JsonProperty(PropertyName = "author")]
        public Author Author { get; set; }
    }

    internal class Commit
    {
        [JsonProperty(PropertyName = "author")]
        public CommitAuthor Author { get; set; }
    }

    internal class CommitAuthor
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
    }

    internal class Author
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }
    }

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
            var ghApiBaseEndPoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/commits";

            foreach (var model in models)
            {
                if (model.Type == DocumentType.Article)
                {
                    string gitHubJsonFilePath = model.BaseDir + @"/github.json";

                    if (File.Exists(gitHubJsonFilePath))
                    {
                        string transformedFilePathFromRoot = model.LocalPathFromRoot.Replace("/", "%2F");
                        Shared.GitHub access_token = JsonConvert.DeserializeObject<Shared.GitHub>(File.ReadAllText(gitHubJsonFilePath));

                        if (access_token != null && access_token.MyAccessToken != "")
                        {
                            List<Commits> gitCommits = GetPageCommits(ghApiBaseEndPoint + "?path=" + transformedFilePathFromRoot + "&access_token=" + access_token.MyAccessToken);

                            if (gitCommits != null)
                            {
                                var commits = gitCommits
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
            }
        }
        #endregion

        #region Prebuild
        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }
        #endregion

        #region Helpers
        private List<Commits> GetPageCommits(string endpoint)
        {
            HttpWebRequest webRequest = WebRequest.Create(endpoint) as HttpWebRequest;

            if (webRequest != null)
            {
                webRequest.ContentType = "application/json";
                webRequest.Method = "GET";
                webRequest.UserAgent = "Nothing";
                webRequest.ServicePoint.Expect100Continue = false;

                try
                {
                    WebResponse webResponse = webRequest.GetResponse();
                    var status = ((HttpWebResponse)webResponse).StatusDescription;

                    if (status.Contains("401"))
                    {
                        return null;
                    }
                    else
                    {
                        using (var s = webResponse.GetResponseStream())
                        {
                            using (var sr = new StreamReader(s))
                            {
                                var commitsAsJson = sr.ReadToEnd();
                                List<Commits> commits = JsonConvert.DeserializeObject<List<Commits>>(commitsAsJson);
                                return commits;
                            }
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
