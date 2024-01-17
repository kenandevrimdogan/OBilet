using Identity.API.Models.Request.OBiletApi;
using Identity.API.Models.Response.OBiletApi;

namespace Identity.API.Infrastructure
{
    public interface IIdentityService
    {
        Task<SessionResponse> GetSessionAsync(SessionRequest request);
    }
}
