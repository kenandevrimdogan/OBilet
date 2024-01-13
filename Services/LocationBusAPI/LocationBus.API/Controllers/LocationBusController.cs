using LocationBus.API.Infrastructure;
using LocationBus.API.Models.Request;
using LocationBus.API.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace LocationBus.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LocationBusController : ControllerBase
    {
        private readonly ILocationBusService _busService;

        public LocationBusController(ILocationBusService busService)
        {
            _busService = busService;
        }

        [HttpPost("getBuslocations")]
        public async Task<BusLocationResponseModel> GetbuslocationsAsync([FromBody] BuslocationRequest request)
        {
            return await _busService.GetBuslocationsAsync(request);
        }
    }
}
