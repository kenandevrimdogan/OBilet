using Microsoft.Extensions.Caching.Memory;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.CacheModel;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Identity;
using OBilet.Presentation.UI.Web.Models.Response;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Identity;

namespace OBilet.Presentation.UI.Web.Services
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

        public async Task SetSessionInfoAsync()
        {
            var sessionInfo = _memCache.Get($"{_httpContextAccessor.HttpContext.Connection.LocalIpAddress.Address}_session");

            if(sessionInfo != null)
            {
                return;
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
                    IpAddress = _httpContextAccessor.HttpContext.Connection.LocalIpAddress.Address.ToString(),
                    Port = _httpContextAccessor.HttpContext.Connection.LocalPort.ToString()
                }
            });


            if(sessionInfo == null)
            {
                _memCache.Set<SessionModel>($"{_httpContextAccessor.HttpContext.Connection.LocalIpAddress.Address}_session", new SessionModel
                {
                    DeviceId = session.Data.data.deviceid,
                    IpAddress = _httpContextAccessor.HttpContext.Connection.LocalIpAddress.Address.ToString(),
                    SessionId = session.Data.data.sessionid
                });
            }
        }

        public SessionModel GetSessionInfo()
        {
            return _memCache.Get<SessionModel>($"{_httpContextAccessor.HttpContext.Connection.LocalIpAddress.Address}_session");
        }
    }
}
