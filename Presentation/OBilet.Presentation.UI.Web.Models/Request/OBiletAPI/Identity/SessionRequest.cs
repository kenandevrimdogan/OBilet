namespace OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Identity
{
    public class SessionRequest
    {
        public int Type { get; set; }

        public ConnectionRequest Connection { get; set; }

        public BrowserRequest Browser { get; set; }
    }
}
