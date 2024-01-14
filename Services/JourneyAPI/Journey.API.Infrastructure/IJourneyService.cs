using Journey.API.Models.Request.OBiletClient;
using Journey.API.Models.Response.OBiletClient;

namespace Journey.API.Infrastructure
{
    public interface IJourneyService
    {
        Task<JourneyResponse> GetBusJourneysAsync(JourneyRequest request);
    }
}
