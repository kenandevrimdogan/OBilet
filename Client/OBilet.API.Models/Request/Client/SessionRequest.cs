namespace OBilet.API.Models.Request.Client
{
    public class SessionRequest
    {
        public int Type { get; set; }

        public ConnectionRequest Connection { get; set; }

        public BrowserRequest Browser { get; set; }
    }
}
