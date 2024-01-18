using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.CacheModel;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Identity;
using OBilet.Presentation.UI.Web.Models.Response;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Identity;
using OBilet.Presentation.UI.Web.Services.Settings;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace OBilet.Presentation.UI.Web.Services.Concrete
{
    public class IdentityService : IIdentityService
    {
        private readonly IOptions<OBiletApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;


        public IdentityService(IOptions<OBiletApiSettings> oBiletApiSettings,
            HttpClient httpClient)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
        }

        public async Task<Result<SessionResponse>> GetSessionAsync(SessionRequest request)
        {
            var jsonbody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetSession, new StringContent(jsonbody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<Result<SessionResponse>>();

            return response;
        }

        

    }
}
