using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        public async Task<IActionResult> Index([FromQuery] GetBusLocationViewModel request)
        {
            if (!request.DepartureDate.HasValue)
            {
                request.DepartureDate = DateTime.Now;
            }

            //var result = await _locationBusService.GetBusLocationsAsync();

            //request.Regions = 


            return View(request);
        }

        public async Task<IActionResult> GetBusLocationsAsync(string search)
        {
            var apiResult = await _locationBusService.GetBusLocationsAsync(new BuslocationRequest
            {
                Language = "tr-TR",
                Date = DateTime.Now,
                Data = search,
                DeviceSession = new DeviceSessionRequest
                {
                    DeviceId = "PqtdftjloK3Kpka97+ILDzMa6D9740nggLiTzXiLlzA=",
                    SessionId = "PqtdftjloK3Kpka97+ILDzMa6D9740nggLiTzXiLlzA="
                }
            });

            var result = apiResult.Data.data.OrderBy(x => x.rank).Select(x => new SelectListItem
            {
                Text = x.name,
                Value = x.id.ToString()
            }).DistinctBy(x => x.Value).ToList();

            return Json(result);
        }

    }
}