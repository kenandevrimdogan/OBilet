namespace OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation
{
    public record AuthDTO
    {
        public int Type { get; set; }

        public ConnectionDTO Connection { get; set; }

        public BrowserDTO Browser { get; set; }
    }
}
