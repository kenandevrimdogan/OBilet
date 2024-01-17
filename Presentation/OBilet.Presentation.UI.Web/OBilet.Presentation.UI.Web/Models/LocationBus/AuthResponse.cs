using OBilet.Presentation.UI.Web.Models.LocationBus;

namespace OBilet.Presentation.UI.Web.Models.LocationBus
{
    public class AuthResponse
    {
        public string Status { get; set; }
        public AuthDataResponse Data { get; set; }
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
