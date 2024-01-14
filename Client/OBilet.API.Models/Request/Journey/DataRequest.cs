using Newtonsoft.Json;

namespace OBilet.API.Models.Request
{
    public class DataRequest
    {
        [JsonProperty("origin-id")]
        public int originid { get; set; }


        [JsonProperty("destination-id")]
        public int destinationid { get; set; }


        [JsonProperty("departure-date")]
        public string departuredate { get; set; }
    }
}
