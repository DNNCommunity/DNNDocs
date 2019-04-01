using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.GitHubStats.Shared
{
    class GitHub
    {
        [JsonProperty(PropertyName = "access_token")]
        public string MyAccessToken { get; set; }
    }
}
