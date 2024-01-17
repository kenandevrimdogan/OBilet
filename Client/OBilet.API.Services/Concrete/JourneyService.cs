using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OBilet.API.Infrastructure;
using OBilet.API.Models.Request;
using OBilet.API.Models.Response;
using OBilet.API.Services.Settings;
using System.Net.Http.Headers;
using System.Text;

namespace OBilet.API.Services.Concrete
{
    public class JourneyService: IJourneyService
    {
        private readonly IOptions<OBiletClientApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;

        public JourneyService(IOptions<OBiletClientApiSettings> oBiletApiSettings,
            HttpClient httpClient)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_oBiletApiSettings.Value.AuthorizationScheme, _oBiletApiSettings.Value.AuthorizationParameter);
        }

        public async Task<JourneyResponse> GetBusJourneysAsync(JourneyRequest request)
        {
            var jsonbody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetBusJourneys, new StringContent(jsonbody, Encoding.UTF8, "application/json"));

            var response = JsonConvert.DeserializeObject<JourneyResponse>(await result.Content.ReadAsStringAsync());

            return response;
        }
    }
}
