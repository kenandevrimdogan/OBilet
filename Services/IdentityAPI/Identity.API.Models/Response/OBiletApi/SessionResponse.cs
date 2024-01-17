namespace Identity.API.Models.Response.OBiletApi
{
    public class SessionResponse
    {
        public string status { get; set; }
        public SessionDataResponse data { get; set; }
        public object message { get; set; }

        public object usermessage { get; set; }

        public object apirequestid { get; set; }
        public string controller { get; set; }

        public object clientrequestid { get; set; }

        public object webcorrelationid { get; set; }

        public string correlationid { get; set; }
        public object parameters { get; set; }
    }
}
