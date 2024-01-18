using Newtonsoft.Json;

namespace OBilet.API.Models.Request.Client
{
    public class ConnectionRequest
    {
        [JsonProperty("ip-address")]
        public string IpAddress { get; set; }

        public string Port { get; set; }
    }
}
