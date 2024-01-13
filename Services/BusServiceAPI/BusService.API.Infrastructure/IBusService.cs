using BusService.API.Models.Request;
using BusService.API.Models.Response;

namespace BusService.API.Infrastructure
{
    public interface IBusService
    {
       Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request);
    }
}
