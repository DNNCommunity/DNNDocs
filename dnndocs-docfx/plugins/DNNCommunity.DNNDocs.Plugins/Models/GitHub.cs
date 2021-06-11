using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.Models
{
    public class GitHub
    {
        [JsonProperty(PropertyName = "access_token")]
        public string MyAccessToken { get; set; }
    }
}
