using Newtonsoft.Json;

namespace Journey.API.Models.Response.OBiletClient
{
    public class StopResponse
    {
        public int id { get; set; }
        public int? kolayCarLocationId { get; set; }
        public string name { get; set; }
        public string station { get; set; }
        public DateTime? time { get; set; }

        [JsonProperty("is-origin")]
        public bool isorigin { get; set; }

        [JsonProperty("is-destination")]
        public bool isdestination { get; set; }

        [JsonProperty("is-segment-stop")]
        public bool issegmentstop { get; set; }
        public int index { get; set; }
    }
}
