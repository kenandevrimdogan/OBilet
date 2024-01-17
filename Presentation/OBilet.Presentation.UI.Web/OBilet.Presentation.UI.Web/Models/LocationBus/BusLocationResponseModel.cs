namespace OBilet.Presentation.UI.Web.Models.LocationBus
{
    public class BusLocationResponseModel
    {
        public string Status { get; set; }
        public List<Datum> Data { get; set; }
        public object Message { get; set; }

        public object UserMessage { get; set; }

        public object ApiRequestId { get; set; }
        public string Controller { get; set; }

        public object ClientRequestId { get; set; }

        public object WebCorrelationId { get; set; }

        public string CorrelationId { get; set; }
        public object Parameters { get; set; }
    }
}
