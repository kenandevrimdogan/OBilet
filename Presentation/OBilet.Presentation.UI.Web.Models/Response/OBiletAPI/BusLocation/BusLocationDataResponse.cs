namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.BusLocation
{
    public class Datum
    {
        public int id { get; set; }

        public int parentid { get; set; }

        public string type { get; set; }

        public string name { get; set; }

        public GeoLocationResponse geolocation { get; set; }

        public int zoom { get; set; }

        public string tzcode { get; set; }

        public object weathercode { get; set; }

        public int rank { get; set; }

        public string referencecode { get; set; }

        public int? cityid { get; set; }
        
        public object referencecountry { get; set; }

        public int countryid { get; set; }

        public string keywords { get; set; }

        public string cityname { get; set; }

        public object languages { get; set; }

        public string countryname { get; set; }

        public object code { get; set; }

        public bool showcountry { get; set; }

        public object areacode { get; set; }

        public string longname { get; set; }

        public bool iscitycenter { get; set; }
    }
}
