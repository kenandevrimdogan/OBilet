namespace Journey.API.Models.Request.OBiletClient
{
    public class JourneyRequest
    {
        public DateTime Date { get; set; }

        public string Language { get; set; }

        public DataRequest Data { get; set; }
    }
}
