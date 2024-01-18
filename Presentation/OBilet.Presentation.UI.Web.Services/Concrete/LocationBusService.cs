using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.BusLocation;
using OBilet.Presentation.UI.Web.Models.Response;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.BusLocation;
using OBilet.Presentation.UI.Web.Services.Settings;
using System.Net.Http.Json;
using System.Text;

namespace OBilet.Presentation.UI.Web.Services.Concrete
{
    public class LocationBusService : ILocationBusService
    {

        private readonly IOptions<OBiletApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;
        private readonly ICacheService _cacheService;

        public LocationBusService(IOptions<OBiletApiSettings> oBiletApiSettings,
            HttpClient httpClient,
            ICacheService cacheService)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
            _cacheService = cacheService;
        }


        public async Task<Result<BusLocationResponse>> GetBusLocationsAsync(BuslocationRequest request)
        {
            var session = await _cacheService.SetSessionInfoAsync();

            request.DeviceSession = new DeviceSessionRequest
            {
                SessionId = session.SessionId,
                DeviceId = session.DeviceId
            };

            var jsonBody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetBusLocations, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<Result<BusLocationResponse>>();

            return response;
        }
    }
}
