using BusService.API.Infrastructure;
using BusService.API.Models.Request;
using BusService.API.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace BusService.API.Controllers
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
