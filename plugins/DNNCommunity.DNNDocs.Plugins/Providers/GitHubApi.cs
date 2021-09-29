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
            var token = GetGitHubInfo(models);
            System.Console.WriteLine("accessToken: ", token);
            if (!string.IsNullOrEmpty(token))
            {
                var contributorsEndpoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/contributors";
                var resultsAsJson = MakeRequest(contributorsEndpoint, token);
                System.Console.WriteLine("starting deserialization in GetContributors");
                System.Console.WriteLine("resultsAsJson: ", resultsAsJson);
                var contributors = JsonConvert.DeserializeObject<List<Contributor>>(resultsAsJson);
                System.Console.WriteLine("passed deserialization in GetContributors");
                return contributors;
            }
            else
            {
                return null;
            }

        }

        public static List<Commits> GetCommits(ImmutableList<FileModel> models, string path)
        {
            var token = GetGitHubInfo(models);
            System.Console.WriteLine("accessToken: ", token);
            if (!string.IsNullOrEmpty(token))
            {
                var commitsEndpoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/commits";
                if (path != "") {
                    commitsEndpoint = commitsEndpoint + "&path=" + path;
                }
                var resultsAsJson = MakeRequest(commitsEndpoint, token);
                System.Console.WriteLine("starting deserialization in GetCommits");
                var commits = JsonConvert.DeserializeObject<List<Commits>>(resultsAsJson);
                System.Console.WriteLine("passed deserialization in GetCommits");
                return commits;
            }
            else
            {
                return null;
            }

        }

        public static string MakeRequest(string endpoint, string accessToken)
        {
            HttpWebRequest webRequest = WebRequest.Create(endpoint) as HttpWebRequest;

            if (webRequest != null)
            {
                webRequest.ContentType = "application/json";
                webRequest.Method = "GET";
                webRequest.UserAgent = "Nothing";
                webRequest.ServicePoint.Expect100Continue = false;
                webRequest.Headers.Add("access_token", accessToken);

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

        private static string GetGitHubInfo(ImmutableList<FileModel> models)
        {
            string gitHubJsonFilePath = models[0].BaseDir + @"/github.txt";
            if (File.Exists(gitHubJsonFilePath))
            {
                var fileContent = File.ReadAllLines(gitHubJsonFilePath)[0];
                System.Console.WriteLine("fileContent: " + fileContent);

                return fileContent;
                
                //System.Console.WriteLine("passed deserialization in GetGitHubInfo");
                //System.Console.WriteLine(JsonConvert.SerializeObject(gitHubInfo));
                //System.Console.WriteLine("accessToken in GetGitHubInfo: ", gitHubInfo.MyAccessToken);

                //return gitHubInfo;
            }
            else
            {
                return null;
            }
        }
    }
}
