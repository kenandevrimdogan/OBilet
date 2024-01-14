using Newtonsoft.Json;

namespace Journey.API.Models.Response.OBiletClient
{
    public class FeatureResponse
    {
        public int id { get; set; }
        public int priority { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        [JsonProperty("is-promoted")]
        public bool ispromoted { get; set; }

        [JsonProperty("back-color")]
        public string backcolor { get; set; }

        [JsonProperty("fore-color")]
        public string forecolor { get; set; }
    }
}
