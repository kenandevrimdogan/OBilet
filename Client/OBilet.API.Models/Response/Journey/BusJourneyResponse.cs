using Newtonsoft.Json;

namespace OBilet.API.Models.Response
{
    public class BusJourneyResponse
    {
        public int Id { get; set; }

        [JsonProperty("partner-id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner-name")]
        public string PartnerName { get; set; }

        [JsonProperty("route-id")]
        public int RouteId { get; set; }

        [JsonProperty("bus-type")]
        public string BusType { get; set; }

        [JsonProperty("bus-type-name")]
        public string BusTypeName { get; set; }

        [JsonProperty("total-seats")]
        public int TotalSeats { get; set; }

        [JsonProperty("available-seats")]
        public int AvailableSeats { get; set; }

        public JourneyDataResponse Journey { get; set; }
        public List<FeatureResponse> Features { get; set; }

        [JsonProperty("origin-location")]
        public string OriginLocation { get; set; }

        [JsonProperty("destination-location")]
        public string DestinationLocation { get; set; }

        [JsonProperty("is-active")]
        public bool IsActive { get; set; }

        [JsonProperty("origin-location-id")]
        public int OriginLocationId { get; set; }

        [JsonProperty("destination-location-id")]
        public int DestinationLocationId { get; set; }

        [JsonProperty("is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty("cancellation-offset")]
        public int CancellationOffset { get; set; }

        [JsonProperty("has-bus-shuttle")]
        public bool HasBusShuttle { get; set; }

        [JsonProperty("disable-sales-without-gov-id")]
        public bool DisableSalesWithoutGovId { get; set; }

        [JsonProperty("display-offset")]
        public string DisplayOffset { get; set; }

        [JsonProperty("partner-rating")]
        public object PartnerRating { get; set; }

        [JsonProperty("has-dynamic-pricing")]
        public bool HasDynamicPricing { get; set; }

        [JsonProperty("disable-sales-without-hes-code")]
        public bool DisableSalesWithoutHesCode { get; set; }

        [JsonProperty("disable-single-seat-selection")]
        public bool DisableSingleSeatSelection { get; set; }

        [JsonProperty("change-offset")]
        public int ChangeOffset { get; set; }

        public int Rank { get; set; }

        [JsonProperty("display-coupon-code-input")]
        public bool DisplayCouponCodeInput { get; set; }

        [JsonProperty("disable-sales-without-date-of-birth")]
        public bool DisableSalesWithoutDateOfBirth { get; set; }

        [JsonProperty("open-offset")]
        public int? OpenOffset { get; set; }

        [JsonProperty("display-buffer")]
        public object DisplayBuffer { get; set; }

        [JsonProperty("allow-sales-foreign-passenger")]
        public bool AllowSalesForeignPassenger { get; set; }

        [JsonProperty("has-seat-selection")]
        public bool HasSeatSelection { get; set; }

        [JsonProperty("branded-fares")]
        public List<object> BrandedFares { get; set; }

        [JsonProperty("has-gender-selection")]
        public bool HasGenderSelection { get; set; }

        [JsonProperty("has-dynamic-cancellation")]
        public bool HasDynamicCancellation { get; set; }

        [JsonProperty("partner-terms-and-conditions")]
        public object PartnerTermsAndConditions { get; set; }

        [JsonProperty("partner-available-alphabets")]
        public string PartnerAvailableAlphabets { get; set; }

        [JsonProperty("provider-id")]
        public int ProviderId { get; set; }

        [JsonProperty("partner-code")]
        public string PartnerCode { get; set; }

        [JsonProperty("enable-full-journey-display")]
        public bool EnableFullJourneyDisplay { get; set; }

        [JsonProperty("provider-name")]
        public string ProviderName { get; set; }

        [JsonProperty("enable-all-stops-display")]
        public bool EnableAllStopsDisplay { get; set; }

        [JsonProperty("is-destination-domestic")]
        public bool IsDestinationDomestic { get; set; }

        [JsonProperty("min-len-gov-id")]
        public object MinLenGovId { get; set; }

        [JsonProperty("max-len-gov-id")]
        public object MaxLenGovId { get; set; }

        [JsonProperty("require-foreign-gov-id")]
        public bool RequireForeignGovId { get; set; }

        [JsonProperty("is-cancellation-info-text")]
        public bool IsCancellationInfoText { get; set; }

        [JsonProperty("cancellation-offset-info-text")]
        public object CancellationOffsetInfoText { get; set; }

        [JsonProperty("is-time-zone-not-equal")]
        public bool IsTimeZoneNotEqual { get; set; }

        [JsonProperty("markup-rate")]
        public double MarkupRate { get; set; }

        [JsonProperty("is-print-ticket-before-journey")]
        public bool IsPrintTicketBeforeJourney { get; set; }

        [JsonProperty("is-extended-journey-detail")]
        public bool IsExtendedJourneyDetail { get; set; }
    }
}
