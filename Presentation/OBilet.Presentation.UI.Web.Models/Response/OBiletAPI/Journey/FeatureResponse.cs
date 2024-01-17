
namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class FeatureResponse
    {
        public int Id { get; set; }
        public int? Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsPromoted { get; set; }

        public string BackColor { get; set; }

        public string ForeColor { get; set; }
    }
}
