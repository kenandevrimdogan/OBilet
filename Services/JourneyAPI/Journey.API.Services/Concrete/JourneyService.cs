using Journey.API.Infrastructure;
using Journey.API.Models.DTO;
using Journey.API.Models.Request.OBiletClient;
using Journey.API.Models.Response.OBiletClient;
using Journey.API.Services.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace Journey.API.Services.Concrete
{
    public class JourneyService : IJourneyService
    {
        private readonly IOptions<OBiletApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;

        public JourneyService(IOptions<OBiletApiSettings> journeyApiSettings,
            HttpClient httpClient)
        {
            _oBiletApiSettings = journeyApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
        }

        public async Task<JourneyResponse> GetBusJourneysAsync(JourneyRequest request)
        {
            var jsonbody = JsonConvert.SerializeObject(new JourneyDTO
            {
                data = new DataDTO
                {
                    departuredate = request.Data.DepartureDate.ToString("yyyy-MM-dd"),
                    destinationid = request.Data.DestinationId,
                    originid = request.Data.OriginId
                },
                date = request.Date.ToString(),
                devicesession = new DeviceSessionDTO
                {
                    deviceid = request.DeviceSession.DeviceId,
                    sessionid = request.DeviceSession.SessionId
                },
                language = request.Language
            });

            var payload = new StringContent(jsonbody, Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetBusJourneys, payload);

            var response = await result.Content.ReadFromJsonAsync<JourneyResponse>();

            return response;
        }
    }
}
