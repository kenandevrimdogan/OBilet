using Newtonsoft.Json;

namespace OBilet.API.Models.Request
{
    public class BuslocationRequest
    {
        public object? data { get; set; }


        [JsonProperty("device-session")]
        public DeviceSessionRequest devicesession { get; set; }

        public string date { get; set; }

        public string language { get; set; }
    }
}
