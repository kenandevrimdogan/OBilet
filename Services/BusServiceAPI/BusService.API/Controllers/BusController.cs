using LocationBus.API.Infrastructure;
using LocationBus.API.Models.Request;
using LocationBus.API.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace LocationBus.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("getBuslocations")]
        public async Task<BusLocationResponseModel> GetbuslocationsAsync(BuslocationRequest request)
        {
            return await _busService.GetBuslocationsAsync(request);
        }
    }
}
