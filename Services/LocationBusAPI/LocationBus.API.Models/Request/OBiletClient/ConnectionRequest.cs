namespace LocationBus.API.Models.Request.OBiletClient
{
    public record ConnectionRequest
    {
        public string IpAddress { get; set; }

        public string Port { get; set; }
    }
}
