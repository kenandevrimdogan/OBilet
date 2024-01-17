using Identity.API.Infrastructure;
using Identity.API.Models.Request.OBiletApi;
using Identity.API.Models.Response.OBiletApi;
using Identity.API.Services.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace Identity.API.Services.Concrete
{
    public class IdentityService : IIdentityService
    {
        private readonly IOptions<OBiletClientApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;

        public IdentityService(IOptions<OBiletClientApiSettings> oBiletApiSettings,
            HttpClient httpClient)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
        }

        public async Task<SessionResponse> GetSessionAsync(SessionRequest request)
        {
            var jsonbody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetSession, new StringContent(jsonbody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<SessionResponse>();

            return response;
        }
    }
}
