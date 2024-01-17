using Newtonsoft.Json;

namespace OBilet.API.Models.Response
{
    public class PolicyResponse
    {
        [JsonProperty("max-seats")]
        public object MaxSeats { get; set; }

        [JsonProperty("max-single")]
        public int? MaxSingle { get; set; }

        [JsonProperty("max-single-males")]
        public int? MaxSingleMales { get; set; }

        [JsonProperty("max-single-females")]
        public int MaxSingleFemales { get; set; }

        [JsonProperty("mixed-genders")]
        public bool MixedGenders { get; set; }

        [JsonProperty("gov-id")]
        public bool GovId { get; set; }

        public bool Lht { get; set; }
    }
}
