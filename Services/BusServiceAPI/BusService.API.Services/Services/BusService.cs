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
        private readonly IOptions<ObiletApiSettings> _obiletApiSettings;
        private readonly HttpClient _httpClient;

        public BusService(IOptions<ObiletApiSettings> obiletApiSettings, 
            HttpClient httpClient)
        {
            _obiletApiSettings = obiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_obiletApiSettings.Value.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
        }


        public async Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request)
        {
            var jsonBody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_obiletApiSettings.Value.Getbuslocations, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<BusLocationResponseModel>();

            return response;
        }
    }
}
