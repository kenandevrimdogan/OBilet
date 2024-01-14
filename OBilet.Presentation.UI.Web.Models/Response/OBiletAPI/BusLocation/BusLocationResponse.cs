namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.BusLocation
{
    public class BusLocationResponse
    {
        public string status { get; set; }

        public List<Datum> data { get; set; }

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
