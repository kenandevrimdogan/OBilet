using Newtonsoft.Json;

namespace LocationBus.API.Models.Response.OBiletClient
{
    public class BusLocationResponseModel
    {
        public string status { get; set; }

        public List<Datum> data { get; set; }

        public object message { get; set; }


        [JsonProperty("user-message")]
        public object usermessage { get; set; }


        [JsonProperty("api-request-id")]
        public object apirequestid { get; set; }

        public string controller { get; set; }


        [JsonProperty("client-request-id")]
        public object clientrequestid { get; set; }


        [JsonProperty("web-correlation-id")]
        public object webcorrelationid { get; set; }


        [JsonProperty("correlation-id")]
        public string correlationid { get; set; }

        public object parameters { get; set; }
    }
}
