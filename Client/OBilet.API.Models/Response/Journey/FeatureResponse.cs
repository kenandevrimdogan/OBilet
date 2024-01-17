using Newtonsoft.Json;

namespace OBilet.API.Models.Response
{
    public class FeatureResponse
    {
        public int Id { get; set; }
        public int? Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonProperty("is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty("back-color")]
        public string BackColor { get; set; }

        [JsonProperty("fore-color")]
        public string ForeColor { get; set; }
    }
}
