namespace OBilet.Presentation.UI.Web.Models.CacheModel
{
    public class JourneySearchModel
    {
        public int OriginId { get; set; }

        public string OriginText { get; set; }

        public int DestinationId { get; set; }

        public string DestinationText { get; set; }

        public DateTime DepartureDate { get; set; }
    }
}
