namespace OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation
{
    public record BuslocationRequest
    {
        public object Data { get; set; }

        public DateTime Date { get; set; }

        public string Language { get; set; }
    }
}
