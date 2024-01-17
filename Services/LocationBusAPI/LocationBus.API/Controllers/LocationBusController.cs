using LocationBus.API.Infrastructure;
using LocationBus.API.Models.Request.OBiletClient;
using LocationBus.API.Models.Response;
using LocationBus.API.Models.Response.OBiletClient;
using Microsoft.AspNetCore.Mvc;

namespace LocationBus.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LocationBusController : ControllerBase
    {
        private readonly ILocationBusService _locationBusService;

        public LocationBusController(ILocationBusService busService)
        {
            _locationBusService = busService;
        }

        [HttpPost("getBusLocations")]
        public async Task<Result<BusLocationResponseModel>> GetBusLocationsAsync([FromBody] BuslocationRequest request)
        {
            return await _locationBusService.GetBuslocationsAsync(request);
        }
    }
}
