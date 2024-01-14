using Newtonsoft.Json;

namespace Journey.API.Models.DTO
{
    public class DataDTO
    {
        [JsonProperty("origin-id")]
        public int originid { get; set; }

        [JsonProperty("destination-id")]
        public int destinationid { get; set; }

        [JsonProperty("departure-date")]
        public string departuredate { get; set; }
    }
}
