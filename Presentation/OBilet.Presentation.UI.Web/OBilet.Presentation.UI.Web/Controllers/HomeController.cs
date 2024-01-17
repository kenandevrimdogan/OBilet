using Microsoft.AspNetCore.Mvc;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.Home;
using OBilet.Presentation.UI.Web.Models.LocationBus;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation;
using OBilet.Presentation.UI.Web.Models.Response;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocationBusService _locationBusService;

        public HomeController(ILocationBusService locationBusService)
        {
            _locationBusService = locationBusService;
        }


        public IActionResult Index([FromQuery]GetBusLocationViewModel request)
        {
            if (!request.DepartureDate.HasValue)
            {
                request.DepartureDate = DateTime.Now;
            }

            return View(request);
        }

        [HttpPost("getBusLocations")]
        public async Task<IActionResult> GetBusLocationsAsync([FromBody] BuslocationRequest request)
        {
            var result = await _locationBusService.GetBusLocationsAsync(request);

            return Json(result);
        }

    }
}