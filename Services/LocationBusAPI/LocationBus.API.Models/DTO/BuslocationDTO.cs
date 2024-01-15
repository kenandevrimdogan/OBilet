using Newtonsoft.Json;

namespace LocationBus.API.Models.DTO
{
    public class BuslocationDTO
    {
        public object data { get; set; }
        public DeviceSessionDTO devicesession { get; set; }
        public string date { get; set; }
        public string language { get; set; }
    }
}
