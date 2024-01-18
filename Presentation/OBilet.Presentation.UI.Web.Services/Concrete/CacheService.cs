using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.CacheModel;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Identity;

namespace OBilet.Presentation.UI.Web.Services.Concrete
{
    public class CacheService : ICacheService
    {
        private readonly IIdentityService _identityService;
        private readonly IMemoryCache _memCache;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CacheService(IIdentityService identityService, IMemoryCache memCache, IHttpContextAccessor httpContextAccessor)
        {
            _identityService = identityService;
            _memCache = memCache;
            _httpContextAccessor = httpContextAccessor;
        }

        private string getIpAddress()
        {
            // return _httpContextAccessor.HttpContext.Connection.RemotePort.ToString() TomanyRequest'den dolayı kapatıldı. (Rate limit, Circuit Breaker kaynaklı'da olabilir)
            return "165.114.41.23";
        }

        private string getIpAddressPort()
        {
            return _httpContextAccessor.HttpContext.Connection.RemotePort.ToString() ?? "5117";
        }

        public async Task<SessionModel> SetSessionInfoAsync()
        {
            var sessionInfo = _memCache.Get<SessionModel>($"{getIpAddress()}_session");

            if (sessionInfo != null)
            {
                return sessionInfo;
            }

            var session = await _identityService.GetSessionAsync(new SessionRequest
            {
                Type = 1,
                Browser = new BrowserRequest
                {
                    Name = "Chrome",
                    Version = "47.0.0.12"
                },
                Connection = new ConnectionRequest
                {
                    IpAddress = getIpAddress(),
                    Port = getIpAddressPort()
                }
            });

            sessionInfo = new SessionModel
            {
                DeviceId = session.Data.data.deviceid,
                IpAddress = getIpAddress(),
                SessionId = session.Data.data.sessionid
            };

            _memCache.Set<SessionModel>($"{getIpAddress()}_session", sessionInfo);


            return sessionInfo;
        }

        public JourneySearchModel GetJourneySearchModel()
        {
            return _memCache.Get<JourneySearchModel>($"{getIpAddress()}_search");
        }

        public async Task SetJourneySearchModelAsync(JourneySearchModel model)
        {
            _memCache.Set<JourneySearchModel>($"{getIpAddress()}_search", model);
        }
    }
}
