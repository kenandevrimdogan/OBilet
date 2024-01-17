using Newtonsoft.Json;

namespace OBilet.API.Models.Request
{
    public class JourneyDataRequest
    {
        [JsonProperty("origin-id")]
        public int? OriginId { get; set; }


        [JsonProperty("destination-id")]
        public int? DestinationId { get; set; }


        [JsonProperty("departure-date")]
        public string? DepartureDate { get; set; }
    }
}
