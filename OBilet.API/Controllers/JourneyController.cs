using Microsoft.AspNetCore.Mvc;
using OBilet.API.Infrastructure;
using OBilet.API.Models.Request;
using OBilet.API.Models.Response;

namespace OBilet.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class JourneyController : ControllerBase
    {
        private readonly IJourneyService _journeyService;

        public JourneyController(IJourneyService journeyService)
        {
            _journeyService = journeyService;
        }

        [HttpPost("getbusjourneys")]
        public async Task<JourneyResponse> GetBusJourneysAsync([FromBody] JourneyRequest request)
        {
            return await _journeyService.GetBusJourneysAsync(request);
        }
    }
}
