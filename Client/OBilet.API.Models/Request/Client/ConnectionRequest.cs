using Newtonsoft.Json;

namespace OBilet.API.Models.Request.Client
{
    public class ConnectionRequest
    {
        [JsonProperty("ip-address")]
        public string ipaddress { get; set; }

        public string port { get; set; }
    }
}
