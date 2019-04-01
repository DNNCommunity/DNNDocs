using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using Microsoft.DocAsCode.Plugins;
using Microsoft.DocAsCode.Build.ConceptualDocuments;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats
{
    internal class Contributor
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty(PropertyName = "contributions")]
        public string Contributions { get; set; }
    }

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
            var ghApiEndPoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/contributors";
            string gitHubJsonFilePath = models[0].BaseDir + @"/github.json";

            if (File.Exists(gitHubJsonFilePath))
            {
                Shared.GitHub access_token = JsonConvert.DeserializeObject<Shared.GitHub>(File.ReadAllText(gitHubJsonFilePath));

                if (access_token != null && access_token.MyAccessToken != "")
                {
                    var gitContributors = GitHubApiRequest(ghApiEndPoint + "?access_token=" + access_token.MyAccessToken);

                    if (gitContributors != null)
                    {
                        foreach (var model in models)
                        {
                            if (model.Type == DocumentType.Article)
                            {
                                var content = (Dictionary<string, object>)model.Content;

                                for (var i = 1; i < 6; i++)
                                {
                                    content["gitContributor" + i + "Contributions"] = gitContributors[i - 1].Contributions;
                                    content["gitContributor" + i + "Login"] = gitContributors[i - 1].Login;
                                    content["gitContributor" + i + "AvatarUrl"] = gitContributors[i - 1].AvatarUrl;
                                    content["gitContributor" + i + "HtmlUrl"] = gitContributors[i - 1].HtmlUrl;
                                }
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
        private List<Contributor> GitHubApiRequest(string endpoint)
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

                    if (status.Contains("Unauthorized"))
                    {
                        return null;
                    }
                    else
                    {
                        using (var s = webResponse.GetResponseStream())
                        {
                            using (var sr = new StreamReader(s))
                            {
                                var contributorsAsJson = sr.ReadToEnd();
                                var contributors = JsonConvert.DeserializeObject<List<Contributor>>(contributorsAsJson);
                                return contributors;
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
