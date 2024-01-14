using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OBilet.API.Infrastructure;
using OBilet.API.Models.Request;
using OBilet.API.Models.Response;
using OBilet.API.Services.Settings;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace OBilet.API.Services.Concrete
{
    public class LocationBusService: ILocationBusService
    {

        private readonly IOptions<OBiletClientApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;

        public LocationBusService(IOptions<OBiletClientApiSettings> oBiletApiSettings,
            HttpClient httpClient)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_oBiletApiSettings.Value.AuthorizationScheme, _oBiletApiSettings.Value.AuthorizationParameter);
        }


        public async Task<BusLocationResponseModel> GetBusLocationsAsync(BuslocationRequest request)
        {
            var jsonBody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetBusLocations, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<BusLocationResponseModel>();

            return response;
        }
    }
}
