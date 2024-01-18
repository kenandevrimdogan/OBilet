using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OBilet.API.Infrastructure;
using OBilet.API.Models.Request.Client;
using OBilet.API.Models.Response.Client;
using OBilet.API.Services.Settings;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace OBilet.API.Services.Concrete
{
    public class ClientService : IClientService
    {
        private readonly IOptions<OBiletClientApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;

        public ClientService(IOptions<OBiletClientApiSettings> oBiletApiSettings,
            HttpClient httpClient)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_oBiletApiSettings.Value.AuthorizationScheme, _oBiletApiSettings.Value.AuthorizationParameter);
        }

        public async Task<SessionResponse> GetSessionAsync(SessionRequest request)
        {
            var jsonbody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetSession, new StringContent(jsonbody, Encoding.UTF8, "application/json"));

            var response = JsonConvert.DeserializeObject<SessionResponse>(await result.Content.ReadAsStringAsync());

            return response;
        }
    }
}
