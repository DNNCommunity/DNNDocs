using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.Models
{
    public class Commit
    {
        [JsonProperty(PropertyName = "author")]
        public CommitAuthor Author { get; set; }
    }
}
