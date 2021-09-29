using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Collections.Immutable;
using Microsoft.DocAsCode.Plugins;
using Newtonsoft.Json;
using DNNCommunity.DNNDocs.Plugins.Models;
using System;

namespace DNNCommunity.DNNDocs.Plugins.Providers
{
    public sealed class GitHubApi
    {
        private static GitHubApi instance;
        private string gitHubToken;
        private string rootPath;
        
        static GitHubApi()
        {
        }

        private GitHubApi(string rootPath)
        {
            this.rootPath = rootPath;
            gitHubToken = GetToken();
        }


        public static GitHubApi Instance(string rootPath)
        {
            if (instance is null)
            {
                instance = new GitHubApi(rootPath);
            }

            return instance;
        }

        public List<Contributor> GetContributors(ImmutableList<FileModel> models)
        {
            if (string.IsNullOrEmpty(gitHubToken))
            {
                return null;
            }

            var contributorsEndpoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/contributors";
            var resultsAsJson = MakeRequest(contributorsEndpoint, gitHubToken);

            if (string.IsNullOrEmpty(resultsAsJson))
            {
                return null;
            }

            var contributors = JsonConvert.DeserializeObject<List<Contributor>>(resultsAsJson);
            return contributors;
        }

        public List<Commits> GetCommits(ImmutableList<FileModel> models, string path)
        {

            if (string.IsNullOrEmpty(gitHubToken))
            {
                return null;
            }
            
            var commitsEndpoint = "https://api.github.com/repos/DNNCommunity/DNNDocs/commits";
            if (path != "") {
                commitsEndpoint = commitsEndpoint + "?path=" + path;
            }

            var resultsAsJson = MakeRequest(commitsEndpoint, gitHubToken);
            if (string.IsNullOrEmpty(resultsAsJson))
            {
                return null;
            }

            var commits = JsonConvert.DeserializeObject<List<Commits>>(resultsAsJson);
            return commits;
        }

        public string MakeRequest(string endpoint, string accessToken)
        {
            HttpWebRequest webRequest = WebRequest.Create(endpoint) as HttpWebRequest;

            if (webRequest != null)
            {
                webRequest.ContentType = "application/json";
                webRequest.Method = "GET";
                webRequest.UserAgent = "request";
                webRequest.ServicePoint.Expect100Continue = false;
                webRequest.Headers.Add("access_token", accessToken);

                try
                {
                    WebResponse webResponse = webRequest.GetResponse();
                    var status = ((HttpWebResponse)webResponse).StatusDescription;

                    bool failed = false;
                    if (status.Contains("Unauthorized"))
                    {
                        failed = true;
                    }

                    using (var s = webResponse.GetResponseStream())
                    {
                        using (var sr = new StreamReader(s))
                        {
                            string resultsAsJson = sr.ReadToEnd();
                            if (failed)
                            {
                                return null;
                            }
                            return resultsAsJson;
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private string GetToken()
        {
            var filePath = Path.Combine(this.rootPath, "github-token.txt");
            if (!File.Exists(filePath))
            {
                return null;
            }
            
            return File.ReadAllText(filePath);
        }
    }
}
