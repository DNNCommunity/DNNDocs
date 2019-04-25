using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats.Models
{
    public class GitHub
    {
        [JsonProperty(PropertyName = "access_token")]
        public string MyAccessToken { get; set; }
    }
}
