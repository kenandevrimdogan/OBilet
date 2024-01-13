namespace BusService.API.Models.Request
{
    public class AuthRequest
    {
        public int type { get; set; }

        public ConnectionRequest connection { get; set; }

        public BrowserRequest browser { get; set; }
    }
}
