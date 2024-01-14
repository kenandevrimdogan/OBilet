using OBilet.API.Models.Request;
using OBilet.API.Models.Response;

namespace OBilet.API.Infrastructure
{
    public interface IJourneyService
    {
        Task<JourneyResponse> GetBusJourneysAsync(JourneyRequest request);
    }
}
