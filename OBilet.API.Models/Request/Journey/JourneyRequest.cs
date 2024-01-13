using Newtonsoft.Json;

namespace OBilet.API.Models.Request
{
    public class JourneyRequest
    {
        [JsonProperty("device-session")]
        public DeviceSessionRequest devicesession { get; set; }

        public string date { get; set; }

        public string language { get; set; }

        public DataRequest data { get; set; }
    }
}
