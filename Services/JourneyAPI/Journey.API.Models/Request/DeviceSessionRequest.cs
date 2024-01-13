using Newtonsoft.Json;

namespace Journey.API.Models.Request
{
    public class DeviceSessionRequest
    {
        [JsonProperty("session-id")]
        public string sessionid { get; set; }

        [JsonProperty("device-id")]
        public string deviceid { get; set; }
    }
}
