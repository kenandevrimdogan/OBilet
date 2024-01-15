using OBilet.API.Models.Request.Client;
using OBilet.API.Models.Response.Client;

namespace OBilet.API.Infrastructure
{
    public interface IClientService
    {
        Task<SessionResponse> GetSessionAsync(SessionRequest request);
    }
}
