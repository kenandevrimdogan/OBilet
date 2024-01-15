using Newtonsoft.Json;

namespace Journey.API.Models.DTO
{
    public class DataDTO
    {
        public int? originid { get; set; }

        public int? destinationid { get; set; }

        public string? departuredate { get; set; }
    }
}
