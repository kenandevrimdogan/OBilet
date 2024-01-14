namespace LocationBus.API.Models.DTO
{
    public class AuthDTO
    {
        public int type { get; set; }

        public ConnectionDTO connection { get; set; }

        public BrowserDTO browser { get; set; }
    }
}
