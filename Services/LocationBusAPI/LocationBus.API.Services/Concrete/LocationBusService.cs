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
        private readonly IOptions<OBiletApiSettings> _locationBusApiSettings;
        private readonly HttpClient _httpClient;

        public LocationBusService(IOptions<OBiletApiSettings> locationBusApiSettings, 
            HttpClient httpClient)
        {
            _locationBusApiSettings = locationBusApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_locationBusApiSettings.Value.BaseUrl);
        }


        public async Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request)
        {
            var jsonBody = JsonConvert.SerializeObject(new BuslocationDTO
            {
                data = request.Data,
                date = request.Date.ToString(),
                devicesession = new DeviceSessionDTO
                {
                    deviceid = "",
                    sessionid = "",
                },
                language = ""
            });

            var payload = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync(_locationBusApiSettings.Value.GetBuslocations, payload);

            var response = await result.Content.ReadFromJsonAsync<BusLocationResponseModel>();

            return response;
        }
    }
}
