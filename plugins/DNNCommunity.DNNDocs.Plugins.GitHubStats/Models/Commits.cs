using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats.Models
{
    public class Commits
    {
        [JsonProperty(PropertyName = "commit")]
        public Commit Commit { get; set; }

        [JsonProperty(PropertyName = "author")]
        public Author Author { get; set; }
    }
}
