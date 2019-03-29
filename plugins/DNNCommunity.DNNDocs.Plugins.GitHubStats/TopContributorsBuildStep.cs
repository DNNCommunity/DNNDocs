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
    public class TopContributorsBuildStep : IDocumentBuildStep
    {
        #region Build
        public void Build(FileModel model, IHostService host)
        {
            // do nothing
        }
        #endregion

        public int BuildOrder => 0;

        public string Name => nameof(TopContributorsBuildStep);

        #region Postbuild
        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {
            var ghApiEndPoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/contributors";
            var gitContributors = GitHubApiRequest(ghApiEndPoint);

            foreach (var model in models)
            {
                if (model.Type == DocumentType.Article)
                {
                    var content = (Dictionary<string, object>)model.Content;
                    for(var i = 1; i < 6; i++)
                    {
                        content["gitContributor" + i + "Contributions"] = gitContributors[i - 1].Contributions;
                        content["gitContributor" + i + "Login"] = gitContributors[i - 1].Login;
                        content["gitContributor" + i + "AvatarUrl"] = gitContributors[i - 1].AvatarUrl;
                        content["gitContributor" + i + "HtmlUrl"] = gitContributors[i - 1].HtmlUrl;
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
            var resultsObj = new List<Contributor>();
            if (webRequest != null)
            {
                webRequest.ContentType = "application/json";
                webRequest.Method = "GET";
                webRequest.UserAgent = "Nothing";
                webRequest.ServicePoint.Expect100Continue = false;

                try
                {
                    using (var s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (var sr = new StreamReader(s))
                        {
                            var contributorsAsJson = sr.ReadToEnd();
                            var contributors = JsonConvert.DeserializeObject<List<Contributor>>(contributorsAsJson);
                            return contributors;
                        }
                    }
                }
                catch
                {
                    //do something
                }
            }
            return resultsObj;
        }
        #endregion
    }
}
