using OBilet.Presentation.UI.Web.Models.CacheModel;

namespace OBilet.Presentation.UI.Web.Services
{
    public interface ICacheService
    {
        Task SetSessionInfoAsync();

        SessionModel GetSessionInfo();
    }
}
