using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OBilet.Presentation.UI.Web.Models.Home
{
    public class GetBusLocationViewModel
    {
        [DisplayName("Nereden")]
        [Required]
        public int? OriginId { get; set; }

        [DisplayName("Nereye")]
        [Required]
        public int? DestinationId { get; set; }

        [DisplayName("Tarih")]
        [Required]
        public DateTime? DepartureDate { get; set; }

        public bool? IsError { get; set; }

        public List<string> ErrorMessages { get; set; } = new List<string>();

        public List<SelectListItem> Regions { get; set; }

        public string OriginText { get; set; }

        public string DestinationText { get; set; }


    }
}
