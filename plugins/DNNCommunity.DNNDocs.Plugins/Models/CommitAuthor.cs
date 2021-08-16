using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.Models
{
    public class CommitAuthor
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
    }
}
