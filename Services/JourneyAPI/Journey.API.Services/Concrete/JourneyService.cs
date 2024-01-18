using Journey.API.Infrastructure;
using Journey.API.Models.DTO;
using Journey.API.Models.Request.OBiletClient;
using Journey.API.Models.Response;
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

        public async Task<Result<JourneyResponse>> GetBusJourneysAsync(JourneyRequest request)
        {
            var response = new Result<JourneyResponse>();

            if (request.Data.OriginId == default
                || request.Data.DestinationId == default)
            {
                response.IsError = true;
                response.ErrorMessages.Add("Varış veya Kalkış noktaları boş olamaz");
            }

            if (request.Data.DepartureDate.HasValue)
            {
                response.IsError = true;
                response.ErrorMessages.Add("Kalkış zamanı boş olamaz");
            }

            if (request.Data.DestinationId == request.Data.OriginId)
            {
                response.IsError = true;
                response.ErrorMessages.Add("Aynı konumu hem kalkış hem de varış olarak seçilemez");
            }

            if (request.Data.DepartureDate.Value.Date < DateTime.Now.Date)
            {
                response.IsError = true;
                response.ErrorMessages.Add("Kalkış tarihi için geçerli minimum tarih bugündür.");
            }

            if (response.IsError == true)
            {
                return response;
            }


            var jsonbody = JsonConvert.SerializeObject(new JourneyDTO
            {
                data = new DataDTO
                {
                    departuredate = request.Data.DepartureDate?.ToString("yyyy-MM-dd"),
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

            response.Data = await result.Content.ReadFromJsonAsync<JourneyResponse>();
            response.Data.Data = response.Data.Data.OrderBy(x => x.Journey.Departure).ThenBy(x=> x.Journey.Arrival).ToList();

            return response;
        }
    }
}
