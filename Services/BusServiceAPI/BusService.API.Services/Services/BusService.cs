using LocationBus.API.Infrastructure;
using LocationBus.API.Models.Request;
using LocationBus.API.Models.Response;
using LocationBus.API.Services.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace LocationBus.API.Services.Concrete
{
    public class BusService : IBusService
    {
        private readonly IOptions<LocationBusApiSettings> _locationBusApiSettings;
        private readonly HttpClient _httpClient;

        public BusService(IOptions<LocationBusApiSettings> obiletApiSettings, 
            HttpClient httpClient)
        {
            _locationBusApiSettings = obiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_locationBusApiSettings.Value.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_locationBusApiSettings.Value.AuthorizationScheme, _locationBusApiSettings.Value.AuthorizationParameter);
        }


        public async Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request)
        {
            var jsonBody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_locationBusApiSettings.Value.Getbuslocations, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<BusLocationResponseModel>();

            return response;
        }
    }
}
