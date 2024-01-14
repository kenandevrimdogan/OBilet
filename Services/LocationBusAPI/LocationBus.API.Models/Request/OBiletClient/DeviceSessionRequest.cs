namespace LocationBus.API.Models.Request.OBiletClient
{
    public record DeviceSessionRequest
    {
        public string SessionId { get; set; }

        public string DeviceId { get; set; }
    }
}
