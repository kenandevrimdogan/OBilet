using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Identity;
using OBilet.Presentation.UI.Web.Models.Response;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Identity;

namespace OBilet.Presentation.UI.Web.Infrastructure
{
    public interface IIdentityService
    {
        Task<Result<SessionResponse>> GetSessionAsync(SessionRequest request);
    }
}
