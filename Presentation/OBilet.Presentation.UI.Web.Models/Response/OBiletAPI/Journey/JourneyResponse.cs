using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey;

namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class JourneyResponse
    {
        public string Status { get; set; }

        public List<BusJourneyResponse> Data { get; set; }

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
