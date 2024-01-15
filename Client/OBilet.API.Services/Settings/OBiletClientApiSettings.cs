namespace OBilet.API.Services.Settings
{
    public class OBiletClientApiSettings 
    {
        public string BaseUrl { get; set; }

        public string Endpoint { get; set; }

        public string AuthorizationScheme { get; set; }

        public string AuthorizationParameter { get; set; }

        public string GetBusJourneys { get; set; }

        public string GetBusLocations { get; set; }

        public string GetSession { get; set; }

    }
}
