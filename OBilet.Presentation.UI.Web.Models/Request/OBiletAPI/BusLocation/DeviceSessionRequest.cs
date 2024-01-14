namespace OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation
{
    public record DeviceSessionRequest
    {
        public string SessionId { get; set; }

        public string DeviceId { get; set; }
    }
}
