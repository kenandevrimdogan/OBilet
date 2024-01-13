using Journey.API.Infrastructure;
using Journey.API.Models.Request;
using Journey.API.Models.Response;
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

        [HttpPost("getbusjourneys")]
        public async Task<JourneyResponse> GetbusjourneysAsync([FromBody] JourneyRequest request)
        {
            return await _journeyService.GetbusjourneysAsync(request);
        }
    }
}
