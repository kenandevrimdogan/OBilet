using Microsoft.AspNetCore.Mvc;
using OBilet.Presentation.UI.Web.Models;
using OBilet.Presentation.UI.Web.Models.Home;
using System.Diagnostics;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}