using Newtonsoft.Json;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.BusLocation;

namespace OBilet.API.Models.Response
{
    public class Datum
    {
        public int Id { get; set; }

        [JsonProperty("parent-id")]
        public int ParentId { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }

        [JsonProperty("geo-location")]
        public GeoLocationModel GeoLocation { get; set; }

        public int Zoom { get; set; }

        [JsonProperty("tz-code")]
        public string TzCode { get; set; }

        [JsonProperty("weather-code")]
        public object WeatherCode { get; set; }

        public int Rank { get; set; }

        [JsonProperty("reference-code")]
        public string ReferenceCode { get; set; }

        [JsonProperty("city-id")]
        public int? CityId { get; set; }

        [JsonProperty("reference-country")]
        public object ReferenceCountry { get; set; }

        [JsonProperty("country-id")]
        public int? CountryId { get; set; }

        public string Keywords { get; set; }

        [JsonProperty("city-name")]
        public string CityName { get; set; }

        public object Languages { get; set; }

        [JsonProperty("country-name")]
        public string CountryName { get; set; }

        public object Code { get; set; }

        [JsonProperty("show-country")]
        public bool ShowCountry { get; set; }

        [JsonProperty("area-code")]
        public object AreaCode { get; set; }

        [JsonProperty("long-name")]
        public string LongName { get; set; }

        [JsonProperty("is-city-center")]
        public bool IsCityCenter { get; set; }
    }
}
