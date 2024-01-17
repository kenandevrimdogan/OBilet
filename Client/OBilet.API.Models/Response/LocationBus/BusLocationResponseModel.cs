using Newtonsoft.Json;

namespace OBilet.API.Models.Response
{
    public class BusLocationResponseModel
    {
        public string Status { get; set; }
        public List<Datum> Data { get; set; }
        public object Message { get; set; }

        [JsonProperty("user-message")]
        public object UserMessage { get; set; }

        [JsonProperty("api-request-id")]
        public object ApiRequestId { get; set; }

        public string Controller { get; set; }

        [JsonProperty("client-request-id")]
        public object ClientRequestId { get; set; }

        [JsonProperty("web-correlation-id")]
        public object WebCorrelationId { get; set; }

        [JsonProperty("correlation-id")]
        public string CorrelationId { get; set; }

        public object Parameters { get; set; }
    }
}
