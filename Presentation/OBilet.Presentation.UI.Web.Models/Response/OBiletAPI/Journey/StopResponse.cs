namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class StopResponse
    {
        public int id { get; set; }

        public int? kolayCarLocationId { get; set; }

        public string name { get; set; }

        public string station { get; set; }

        public DateTime? time { get; set; }

        public bool isorigin { get; set; }

        public bool isdestination { get; set; }

        public bool issegmentstop { get; set; }

        public int index { get; set; }
    }
}
