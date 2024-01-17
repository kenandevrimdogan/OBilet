using Microsoft.AspNetCore.Mvc;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models;
using OBilet.Presentation.UI.Web.Models.Home;
using System.Diagnostics;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocationBusService _locationBusService;

        public HomeController(ILocationBusService locationBusService)
        {
            _locationBusService = locationBusService;
        }


        public IActionResult Index()
        {
            var viewModel = new GetBusLocationViewModel
            {
                DestinationId = 1,
                DepartureDate = DateTime.Now.AddDays(1)
            };

            return View(viewModel);
        }
    
    }
}