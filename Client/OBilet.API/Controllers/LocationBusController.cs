using Microsoft.AspNetCore.Mvc;
using OBilet.API.Infrastructure;
using OBilet.API.Models.Request;
using OBilet.API.Models.Response;

namespace OBilet.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LocationBusController : ControllerBase
    {
        private readonly ILocationBusService _locationBusService;

        public LocationBusController(ILocationBusService locationBusService)
        {
            _locationBusService = locationBusService;
        }

        [HttpPost("getBuslocations")]
        public async Task<BusLocationResponseModel> GetBusLocationsAsync([FromBody] BuslocationRequest request)
        {
            return await _locationBusService.GetBusLocationsAsync(request);
        }
    }
}
