using OBilet.Presentation.UI.Web.Models.CacheModel;

namespace OBilet.Presentation.UI.Web.Infrastructure
{
    public interface ICacheService
    {
        Task<SessionModel> SetSessionInfoAsync();

        JourneySearchModel GetJourneySearchModel();

        Task SetJourneySearchModelAsync(JourneySearchModel model);
    }
}
