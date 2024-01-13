using Journey.API.Infrastructure;
using Journey.API.Models.Request;
using Journey.API.Models.Response;
using LocationBus.API.Services.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace Journey.API.Services.Concrete
{
    public class JourneyService : IJourneyService
    {
        private readonly IOptions<JourneyApiSettings> _journeyApiSettings;
        private readonly HttpClient _httpClient;

        public JourneyService(IOptions<JourneyApiSettings> journeyApiSettings,
            HttpClient httpClient)
        {
            _journeyApiSettings = journeyApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_journeyApiSettings.Value.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_journeyApiSettings.Value.AuthorizationScheme, _journeyApiSettings.Value.AuthorizationParameter);
        }

        public async Task<JourneyResponse> GetbusjourneysAsync(JourneyRequest request)
        {
            var jsonbody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_journeyApiSettings.Value.Getbusjourneys, new StringContent(jsonbody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<JourneyResponse>();

            return response;
        }
    }
}
