using Identity.API.Models.Request.OBiletApi;
using Identity.API.Models.Response;
using Identity.API.Models.Response.OBiletApi;

namespace Identity.API.Infrastructure
{
    public interface IIdentityService
    {
        Task<Result<SessionResponse>> GetSessionAsync(SessionRequest request);
    }
}
