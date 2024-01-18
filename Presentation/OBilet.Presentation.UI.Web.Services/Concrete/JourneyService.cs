using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Journey;
using OBilet.Presentation.UI.Web.Models.Response;
using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey;
using OBilet.Presentation.UI.Web.Services.Settings;
using System.Net.Http.Json;
using System.Text;

namespace OBilet.Presentation.UI.Web.Services.Concrete
{
    public class JourneyService : IJourneyService
    {
        private readonly IOptions<OBiletApiSettings> _oBiletApiSettings;
        private readonly HttpClient _httpClient;
        private readonly ICacheService _cacheService;

        public JourneyService(IOptions<OBiletApiSettings> oBiletApiSettings,
            HttpClient httpClient,
            ICacheService cacheService)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
            _cacheService = cacheService;
        }

        public async Task<Result<JourneyResponse>> GetBusJourneysAsync(JourneyRequest request)
        {
            var session = await _cacheService.SetSessionInfoAsync();

            request.DeviceSession = new DeviceSessionRequest
            {
                sessionid = session.SessionId,
                deviceid = session.DeviceId
            };

            var jsonbody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetBusJourneys, new StringContent(jsonbody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<Result<JourneyResponse>>();

            return response;
        }
    }
}
