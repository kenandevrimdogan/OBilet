namespace OBilet.API.Models.Request.Client
{
    public class SessionRequest
    {
        public int type { get; set; }

        public ConnectionRequest connection { get; set; }

        public BrowserRequest browser { get; set; }
    }
}
