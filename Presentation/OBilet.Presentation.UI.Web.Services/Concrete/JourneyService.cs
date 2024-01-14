using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Models.Request.OBiletAPI.Journey;
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

        public JourneyService(IOptions<OBiletApiSettings> oBiletApiSettings,
            HttpClient httpClient)
        {
            _oBiletApiSettings = oBiletApiSettings;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_oBiletApiSettings.Value.BaseUrl);
        }

        public async Task<JourneyResponse> GetBusJourneysAsync(JourneyRequest request)
        {
            var jsonbody = JsonConvert.SerializeObject(request);

            var result = await _httpClient.PostAsync(_oBiletApiSettings.Value.GetBusJourneys, new StringContent(jsonbody, Encoding.UTF8, "application/json"));

            var response = await result.Content.ReadFromJsonAsync<JourneyResponse>();

            return response;
        }
    }
}
