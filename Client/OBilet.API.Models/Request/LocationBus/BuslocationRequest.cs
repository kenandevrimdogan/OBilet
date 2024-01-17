using Newtonsoft.Json;

namespace OBilet.API.Models.Request
{
    public class BuslocationRequest
    {
        public string? Data { get; set; }


        [JsonProperty("device-session")]
        public DeviceSessionRequest Devicesession { get; set; }

        public string Date { get; set; }

        public string Language { get; set; }
    }
}
