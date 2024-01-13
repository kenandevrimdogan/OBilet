using OBilet.API.Models.Request;
using OBilet.API.Models.Response;

namespace OBilet.API.Infrastructure
{
    public interface ILocationBusService
    {
        Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request);
    }
}
