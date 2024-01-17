namespace OBilet.Presentation.UI.Web.Models.LocationBus
{
    public class Datum
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public GeoLocationModel GeoLocation { get; set; }

        public int Zoom { get; set; }

        public string TzCode { get; set; }

        public object WeatherCode { get; set; }

        public int Rank { get; set; }

        public string ReferenceCode { get; set; }

        public int? CityId { get; set; }

        public object ReferenceCountry { get; set; }

        public int? CountryId { get; set; }

        public string Keywords { get; set; }

        public string CityName { get; set; }

        public object Languages { get; set; }

        public string CountryName { get; set; }

        public object Code { get; set; }

        public bool ShowCountry { get; set; }

        public object AreaCode { get; set; }

        public string LongName { get; set; }

        public bool IsCityCenter { get; set; }
    }
}
