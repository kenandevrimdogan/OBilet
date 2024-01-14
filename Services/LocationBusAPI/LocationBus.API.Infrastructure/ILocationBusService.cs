using LocationBus.API.Models.Request.OBiletClient;
using LocationBus.API.Models.Response.OBiletClient;

namespace LocationBus.API.Infrastructure
{
    public interface ILocationBusService
    {
       Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request);
    }
}
