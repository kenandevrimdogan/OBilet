using Journey.API.Models.Request;
using Journey.API.Models.Response;

namespace Journey.API.Infrastructure
{
    public interface IJourneyService
    {
        Task<JourneyResponse> GetbusjourneysAsync(JourneyRequest request);
    }
}
