using Journey.API.Infrastructure;
using Journey.API.Models.Request.OBiletClient;
using Journey.API.Models.Response.OBiletClient;
using Microsoft.AspNetCore.Mvc;

namespace Journey.API.Controllers
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

        [HttpPost("getBusJourneys")]
        public async Task<JourneyResponse> GetbusjourneysAsync([FromBody] JourneyRequest request)
        {
            return await _journeyService.GetBusJourneysAsync(request);
        }
    }
}
