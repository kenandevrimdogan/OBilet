using Journey.API.Infrastructure;
using LocationBus.API.Services.Settings;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;

namespace Journey.API.Services.Concrete
{
    public class JourneyService : IJourneyService
    {
        private readonly IOptions<JourneyApiSettings> _obiletApiSettings;
        private readonly HttpClient _httpClient;

        public JourneyService(IOptions<JourneyApiSettings> obiletApiSettings,
            HttpClient httpClient)
        {
            _obiletApiSettings = obiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_obiletApiSettings.Value.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_obiletApiSettings.Value.AuthorizationScheme, _obiletApiSettings.Value.AuthorizationParameter);
        }


        //public async Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request)
        //{
        //    var jsonBody = JsonConvert.SerializeObject(request);

        //    var result = await _httpClient.PostAsync(_obiletApiSettings.Value.Getbuslocations, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

        //    var response = await result.Content.ReadFromJsonAsync<BusLocationResponseModel>();

        //    return response;
        //}
    }
}
