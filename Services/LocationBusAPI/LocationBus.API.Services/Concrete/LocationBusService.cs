using LocationBus.API.Infrastructure;
using LocationBus.API.Models.DTO;
using LocationBus.API.Models.Request.OBiletClient;
using LocationBus.API.Models.Response.OBiletClient;
using LocationBus.API.Services.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace LocationBus.API.Services.Concrete
{
    public class LocationBusService : ILocationBusService
    {
        private readonly IOptions<OBiletApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;

        public LocationBusService(IOptions<OBiletApiSettings> oBiletApiSettings, 
            HttpClient httpClient)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
        }


        public async Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request)
        {
            var jsonBody = JsonConvert.SerializeObject(new BuslocationDTO
            {
                data = request.Data,
                date = request.Date.ToString("yyyy-MM-ddTHH:mm:ss"),
                devicesession = new DeviceSessionDTO
                {
                    deviceid = request.DeviceSession.DeviceId,
                    sessionid = request.DeviceSession.SessionId,
                },
                language = request.Language
            });

            var payload = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetBuslocations, payload);

            var response = await result.Content.ReadFromJsonAsync<BusLocationResponseModel>();

            return response;
        }
    }
}
