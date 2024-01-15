using Journey.API.Models.Request.OBiletClient;
using Newtonsoft.Json;

namespace Journey.API.Models.DTO
{
    public class JourneyDTO
    {
        public DeviceSessionDTO devicesession { get; set; }

        public string date { get; set; }

        public string language { get; set; }

        public DataDTO data { get; set; }
    }
}
