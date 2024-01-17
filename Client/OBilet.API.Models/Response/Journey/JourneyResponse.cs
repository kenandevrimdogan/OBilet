using Newtonsoft.Json;

namespace OBilet.API.Models.Response
{
    public class JourneyResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<BusJourneyResponse> Data { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("user-message")]
        public object UserMessage { get; set; }

        [JsonProperty("api-request-id")]
        public object ApiRequestId { get; set; }

        [JsonProperty("controller")]
        public string Controller { get; set; }

        [JsonProperty("client-request-id")]
        public object ClientRequestId { get; set; }

        [JsonProperty("web-correlation-id")]
        public object WebCorrelationId { get; set; }

        [JsonProperty("correlation-id")]
        public string CorrelationId { get; set; }

        [JsonProperty("Parameters")]
        public object Parameters { get; set; }
    }
}
