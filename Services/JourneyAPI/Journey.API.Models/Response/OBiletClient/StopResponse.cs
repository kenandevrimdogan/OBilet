namespace Journey.API.Models.Response.OBiletClient
{
    public class StopResponse
    {
        public int Id { get; set; }
        public int? KolayCarLocationId { get; set; }
        public string Name { get; set; }
        public string Station { get; set; }
        public DateTime? Time { get; set; }

        public bool IsOrigin { get; set; }

        public bool IsDestination { get; set; }

        public bool IsSegmentStop { get; set; }
        public int Index { get; set; }
    }
}
