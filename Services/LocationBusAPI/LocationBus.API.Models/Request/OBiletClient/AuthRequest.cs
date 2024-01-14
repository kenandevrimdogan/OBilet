namespace LocationBus.API.Models.Request.OBiletClient
{
    public record AuthRequest
    {
        public int Type { get; set; }

        public ConnectionRequest Connection { get; set; }

        public BrowserRequest Browser { get; set; }
    }
}
