using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.CacheModel;
using OBilet.Presentation.UI.Web.Models.DTO.Journey;
using OBilet.Presentation.UI.Web.Models.Journey;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class JourneyController : Controller
    {
        private readonly IJourneyService _journeyService;
        private readonly ICacheService _cacheService;


        public JourneyController(IJourneyService journeyService, ICacheService cacheService)
        {
            _journeyService = journeyService;
            _cacheService = cacheService;
        }

        [HttpPost]
        public async Task<IActionResult> Index(JourneySearchDTO search)
        {
            var busJourneyResult = await _journeyService.GetBusJourneysAsync(new Models.Request.OBiletAPI.Journey.JourneyRequest
            {
                Language = "tr-TR",
                Date = DateTime.Now,
                Data = new Models.Request.OBiletAPI.Journey.DataRequest
                {
                    OriginId = search.OriginId,
                    DestinationId = search.DestinationId,
                    DepartureDate = search.DepartureDate,
                },
            });

            if (busJourneyResult.IsError)
            {
                return RedirectToAction("Index", "Home", new { IsError = busJourneyResult.IsError, ErrorMessages = busJourneyResult.ErrorMessages });
            }

            if (!busJourneyResult.IsError)
            {
                await _cacheService.SetJourneySearchModelAsync(new JourneySearchModel
                {
                    OriginId = search.OriginId,
                    DestinationId = search.DestinationId,
                    DepartureDate = search.DepartureDate,
                    DestinationText = busJourneyResult.Data.Data.FirstOrDefault().DestinationLocation,
                    OriginText = busJourneyResult.Data.Data.FirstOrDefault().OriginLocation
                });
            }

            var viewModel = new JourneyListViewModel
            {
                JourneyResponse = busJourneyResult,
                DepartureDate = search.DepartureDate
            };

            return View("Index", viewModel);
        }
    }
}
