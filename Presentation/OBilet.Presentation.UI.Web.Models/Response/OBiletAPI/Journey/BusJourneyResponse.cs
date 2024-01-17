
namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class BusJourneyResponse
    {
        public int Id { get; set; }

        public int PartnerId { get; set; }

        public string PartnerName { get; set; }

        public int RouteId { get; set; }

        public string BusType { get; set; }

        public string BusTypeName { get; set; }

        public int TotalSeats { get; set; }

        public int AvailableSeats { get; set; }

        public JourneyDataResponse Journey { get; set; }
        public List<FeatureResponse> Features { get; set; }

        public string OriginLocation { get; set; }

        public string DestinationLocation { get; set; }

        public bool IsActive { get; set; }

        public int OriginLocationId { get; set; }

        public int DestinationLocationId { get; set; }

        public bool IsPromoted { get; set; }

        public int CancellationOffset { get; set; }

        public bool HasBusShuttle { get; set; }

        public bool DisableSalesWithoutGovId { get; set; }

        public string DisplayOffset { get; set; }

        public object PartnerRating { get; set; }

        public bool HasDynamicPricing { get; set; }

        public bool DisableSalesWithoutHesCode { get; set; }

        public bool DisableSingleSeatSelection { get; set; }

        public int ChangeOffset { get; set; }

        public int Rank { get; set; }

        public bool DisplayCouponCodeInput { get; set; }

        public bool DisableSalesWithoutDateOfBirth { get; set; }

        public int? OpenOffset { get; set; }

        public object DisplayBuffer { get; set; }

        public bool AllowSalesForeignPassenger { get; set; }

        public bool HasSeatSelection { get; set; }

        public List<object> BrandedFares { get; set; }

        public bool HasGenderSelection { get; set; }

        public bool HasDynamicCancellation { get; set; }

        public object PartnerTermsAndConditions { get; set; }

        public string PartnerAvailableAlphabets { get; set; }

        public int ProviderId { get; set; }

        public string PartnerCode { get; set; }

        public bool EnableFullJourneyDisplay { get; set; }

        public string ProviderName { get; set; }

        public bool EnableAllStopsDisplay { get; set; }

        public bool IsDestinationDomestic { get; set; }

        public object MinLenGovId { get; set; }

        public object MaxLenGovId { get; set; }

        public bool RequireForeignGovId { get; set; }

        public bool IsCancellationInfoText { get; set; }

        public object CancellationOffsetInfoText { get; set; }

        public bool IsTimeZoneNotEqual { get; set; }

        public double MarkupRate { get; set; }

        public bool IsPrintTicketBeforeJourney { get; set; }

        public bool IsExtendedJourneyDetail { get; set; }
    }
}
