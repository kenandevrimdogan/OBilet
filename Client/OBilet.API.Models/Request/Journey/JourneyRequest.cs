using Newtonsoft.Json;

namespace OBilet.API.Models.Request
{
    public class JourneyRequest
    {
        [JsonProperty("device-session")]
        public DeviceSessionRequest DeviceSession { get; set; }

        public string Date { get; set; }

        public string Language { get; set; }

        public JourneyDataRequest? Data { get; set; }
    }
}
