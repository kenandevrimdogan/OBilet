namespace OBilet.Presentation.UI.Web.Models.DTO.Journey
{
    public class JourneySearchDTO
    {
        public int OriginId { get; set; }

        public int DestinationId { get; set; }

        public DateTime DepartureDate { get; set; } = DateTime.Now;
    }
}
