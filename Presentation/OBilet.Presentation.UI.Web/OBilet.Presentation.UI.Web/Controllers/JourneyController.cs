using Microsoft.AspNetCore.Mvc;
using OBilet.Presentation.UI.Web.Models.DTO.Journey;
using OBilet.Presentation.UI.Web.Models.Journey;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class JourneyController : Controller
    {

        [HttpPost]
        public IActionResult Index(JourneySearchDTO search)
        {
            var viewModel = new JourneyListViewModel();

            return View("Index", viewModel);
        }
    }
}
