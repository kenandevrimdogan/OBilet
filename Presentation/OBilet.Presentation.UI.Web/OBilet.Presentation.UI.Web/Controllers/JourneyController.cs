using Microsoft.AspNetCore.Mvc;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.DTO.Journey;
using OBilet.Presentation.UI.Web.Models.Journey;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class JourneyController : Controller
    {
        private readonly IJourneyService _journeyService;

        public JourneyController(IJourneyService journeyService)
        {
            _journeyService = journeyService;
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
                }
            });

            if (busJourneyResult.IsError)
            {
                return RedirectToAction("Index", "Home", new { IsError = busJourneyResult.IsError, ErrorMessages = busJourneyResult.ErrorMessages });
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
