namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class PolicyResponse
    {
        public object maxseats { get; set; }

        public int? maxsingle { get; set; }

        public int? maxsinglemales { get; set; }

        public int maxsinglefemales { get; set; }

        public bool mixedgenders { get; set; }

        public bool govid { get; set; }
        public bool lht { get; set; }
    }
}
