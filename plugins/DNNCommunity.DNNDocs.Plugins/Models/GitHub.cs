using Newtonsoft.Json;

namespace DNNCommunity.DNNDocs.Plugins.Models
{
    public class GitHub
    {
        private string myAccessToken;

        [JsonProperty(PropertyName = "accessToken")]
        public string MyAccessToken { 
            get {
                System.Console.WriteLine("get myAccessToken: ", this.myAccessToken);
                return this.myAccessToken;
            }

            set {
                this.myAccessToken = value;
                System.Console.WriteLine("set myAccessToken: ", this.myAccessToken);
            }
        }
    }
}
