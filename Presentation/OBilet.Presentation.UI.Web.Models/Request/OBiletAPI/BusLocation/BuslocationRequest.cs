namespace OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation
{
    public record BuslocationRequest
    {
        public string Data { get; set; }

        public DateTime Date { get; set; }

        public string Language { get; set; }

        public DeviceSessionRequest DeviceSession { get; set; }
    }
}
