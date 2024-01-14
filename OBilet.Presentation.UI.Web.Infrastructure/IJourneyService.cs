using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Journey;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey;

namespace OBilet.Presentation.UI.Web.Infrastructure
{
    public interface IJourneyService
    {
        Task<JourneyResponse> GetBusJourneysAsync(JourneyRequest request);
    }
}
