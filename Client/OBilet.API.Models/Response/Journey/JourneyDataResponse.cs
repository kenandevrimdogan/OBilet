using Newtonsoft.Json;

namespace OBilet.API.Models.Response
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

        [JsonProperty("original-price")]
        public double OriginalPrice { get; set; }

        [JsonProperty("internet-price")]
        public double InternetPrice { get; set; }

        [JsonProperty("provider-internet-price")]
        public double? ProviderInternetPrice { get; set; }

        public object Booking { get; set; }

        [JsonProperty("bus-name")]
        public string BusName { get; set; }
        public PolicyResponse Policy { get; set; }
        public List<string> Features { get; set; }
        public string Description { get; set; }
        public object Available { get; set; }

        [JsonProperty("partner-provider-code")]
        public object PartnerProviderCode { get; set; }

        [JsonProperty("peron-no")]
        public object PeronNo { get; set; }

        [JsonProperty("partner-provider-id")]
        public object PartnerProviderId { get; set; }

        [JsonProperty("is-segmented")]
        public bool IsSegmented { get; set; }

        [JsonProperty("partner-name")]
        public object PartnerName { get; set; }

        [JsonProperty("provider-code")]
        public object ProviderCode { get; set; }

        [JsonProperty("sorting-price")]
        public double SortingPrice { get; set; }
    }
}
