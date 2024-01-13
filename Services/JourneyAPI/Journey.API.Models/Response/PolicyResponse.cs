using Newtonsoft.Json;

namespace Journey.API.Models.Response
{
    public class PolicyResponse
    {
        [JsonProperty("max-seats")]
        public object maxseats { get; set; }

        [JsonProperty("max-single")]
        public int? maxsingle { get; set; }

        [JsonProperty("max-single-males")]
        public int? maxsinglemales { get; set; }

        [JsonProperty("max-single-females")]
        public int maxsinglefemales { get; set; }

        [JsonProperty("mixed-genders")]
        public bool mixedgenders { get; set; }

        [JsonProperty("gov-id")]
        public bool govid { get; set; }
        public bool lht { get; set; }
    }
}
