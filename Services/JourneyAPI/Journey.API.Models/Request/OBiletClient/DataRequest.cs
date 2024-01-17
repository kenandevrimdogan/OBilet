namespace Journey.API.Models.Request.OBiletClient
{
    public class DataRequest
    {
        public int? OriginId { get; set; }

        public int? DestinationId { get; set; }

        public DateTime? DepartureDate { get; set; }
    }
}
