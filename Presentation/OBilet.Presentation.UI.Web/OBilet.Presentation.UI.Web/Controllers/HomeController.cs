using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.CacheModel;
using OBilet.Presentation.UI.Web.Models.DTO.Journey;
using OBilet.Presentation.UI.Web.Models.Home;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation;
using OBilet.Presentation.UI.Web.Services;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocationBusService _locationBusService;
        private readonly ICacheService _cacheService;
        private readonly IMemoryCache _memCache;

        public HomeController(ILocationBusService locationBusService, IMemoryCache memCache, ICacheService cacheService)
        {
            _locationBusService = locationBusService;
            _memCache = memCache;
            _cacheService = cacheService;
        }


        public async Task<IActionResult> Index([FromQuery] GetBusLocationViewModel request)
        {
            var cacheSearch = _memCache.Get<JourneySearchModel>($"{HttpContext.Connection.LocalIpAddress.Address}_search");
            await _cacheService.SetSessionInfoAsync();

            if (cacheSearch != null)
            {
                request.DepartureDate = cacheSearch.DepartureDate;
                request.DestinationId = cacheSearch.DestinationId;
                request.OriginId = cacheSearch.OriginId;
                request.OriginText = cacheSearch.OriginText;
                request.DestinationText = cacheSearch.DestinationText;
            }

            if (!request.DepartureDate.HasValue)
            {
                request.DepartureDate = DateTime.Now.AddDays(1);
            }

            return View(request);
        }

        public async Task<IActionResult> GetBusLocationsAsync(string search)
        {
            var session = _cacheService.GetSessionInfo();
            var apiResult = await _locationBusService.GetBusLocationsAsync(new BuslocationRequest
            {
                Language = "tr-TR",
                Date = DateTime.Now,
                Data = search,
                DeviceSession = new DeviceSessionRequest
                {
                    DeviceId = session.DeviceId,
                    SessionId = session.SessionId
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