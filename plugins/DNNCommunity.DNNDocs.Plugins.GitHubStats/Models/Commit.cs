using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats.Models
{
    public class Commit
    {
        [JsonProperty(PropertyName = "author")]
        public CommitAuthor Author { get; set; }
    }
}
