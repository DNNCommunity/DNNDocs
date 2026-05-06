using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.Models
{
    public class Contributor
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty(PropertyName = "contributions")]
        public string Contributions { get; set; }

        /// <summary>Number of commits by this author in the sampled window.</summary>
        public int Total { get; set; }

        /// <summary>Date of the most recent commit by this author.</summary>
        public DateTimeOffset LatestCommitDate { get; set; }
    }
}
