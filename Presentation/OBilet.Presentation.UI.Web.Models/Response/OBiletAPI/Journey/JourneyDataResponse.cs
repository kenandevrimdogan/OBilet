namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class JourneyDataResponse
    {
        public string Kind { get; set; }
        public string Code { get; set; }
        public List<StopResponse> Stops { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public string Currency { get; set; }
        public string Duration { get; set; }

        public double OriginalPrice { get; set; }

        public double InternetPrice { get; set; }

        public double? ProviderInternetPrice { get; set; }

        public object Booking { get; set; }

        public string BusName { get; set; }
        public PolicyResponse Policy { get; set; }
        public List<string> Features { get; set; }
        public string Description { get; set; }
        public object Available { get; set; }

        public object PartnerProviderCode { get; set; }

        public object PeronNo { get; set; }

        public object PartnerProviderId { get; set; }

        public bool IsSegmented { get; set; }

        public object PartnerName { get; set; }

        public object ProviderCode { get; set; }

        public double SortingPrice { get; set; }
    }
}
