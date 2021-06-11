using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Collections.Immutable;
using Microsoft.DocAsCode.Plugins;
using Newtonsoft.Json;
using DNNCommunity.DNNDocs.Plugins.Models;

namespace DNNCommunity.DNNDocs.Plugins.Providers
{
    public class GitHubApi
    {
        public static List<Contributor> GetContributors(ImmutableList<FileModel> models)
        {
            GitHub gitHubInfo = GetGitHubInfo(models);
            if (gitHubInfo != null && gitHubInfo.MyAccessToken != "")
            {
                var contributorsEndpoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/contributors?access_token=" + gitHubInfo.MyAccessToken;
                var resultsAsJson = MakeRequest(contributorsEndpoint);
                var contributors = JsonConvert.DeserializeObject<List<Contributor>>(resultsAsJson);
                return contributors;
            }
            else
            {
                return null;
            }

        }

        public static List<Commits> GetCommits(ImmutableList<FileModel> models, string path)
        {
            GitHub gitHubInfo = GetGitHubInfo(models);
            if (gitHubInfo != null && gitHubInfo.MyAccessToken != "")
            {
                var commitsEndpoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/commits?access_token=" + gitHubInfo.MyAccessToken;
                if (path != "") {
                    commitsEndpoint = commitsEndpoint + "&path=" + path;
                }
                var resultsAsJson = MakeRequest(commitsEndpoint);
                var commits = JsonConvert.DeserializeObject<List<Commits>>(resultsAsJson);
                return commits;
            }
            else
            {
                return null;
            }

        }

        public static string MakeRequest(string endpoint)
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
                                string resultsAsJson = sr.ReadToEnd();
                                return resultsAsJson;
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

        private static GitHub GetGitHubInfo(ImmutableList<FileModel> models)
        {
            string gitHubJsonFilePath = models[0].BaseDir + @"/github.json";

            if (File.Exists(gitHubJsonFilePath))
            {
                GitHub gitHubInfo = JsonConvert.DeserializeObject<GitHub>(File.ReadAllText(gitHubJsonFilePath));
                return gitHubInfo;
            }
            else
            {
                return null;
            }
        }
    }
}
