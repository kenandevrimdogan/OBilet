namespace LocationBus.API.Models.Request.OBiletClient
{
    public record BuslocationRequest
    {
        public string? Data { get; set; }

        public DateTime Date { get; set; }

        public string Language { get; set; }

        public DeviceSessionRequest? DeviceSession { get; set; }
    }
}
