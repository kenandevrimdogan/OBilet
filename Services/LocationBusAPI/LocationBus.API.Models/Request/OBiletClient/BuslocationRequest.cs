namespace LocationBus.API.Models.Request.OBiletClient
{
    public record BuslocationRequest
    {
        public object Data { get; set; }

        public DateTime Date { get; set; }

        public string Language { get; set; }
    }
}
