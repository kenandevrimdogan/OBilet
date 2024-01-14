using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.BusLocation;

namespace OBilet.Presentation.UI.Web.Infrastructure
{
    public interface ILocationBusService
    {
        Task<BusLocationResponse> GetBusLocationsAsync(BuslocationRequest request);
    }
}
