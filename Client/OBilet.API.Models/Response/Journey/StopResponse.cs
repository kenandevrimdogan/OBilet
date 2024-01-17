using Newtonsoft.Json;

namespace OBilet.API.Models.Response
{
    public class StopResponse
    {
        public int Id { get; set; }
        public int? KolayCarLocationId { get; set; }
        public string Name { get; set; }
        public string Station { get; set; }
        public DateTime? Time { get; set; }

        [JsonProperty("is-origin")]
        public bool IsOrigin { get; set; }

        [JsonProperty("is-destination")]
        public bool IsDestination { get; set; }

        [JsonProperty("is-segment-stop")]
        public bool IsSegmentStop { get; set; }
        public int Index { get; set; }
    }
}
