namespace Journey.API.Models.Response.OBiletClient
{
    public class PolicyResponse
    {
        public object MaxSeats { get; set; }

        public int? MaxSingle { get; set; }

        public int? MaxSingleMales { get; set; }

        public int? MaxSingleFemales { get; set; }

        public bool MixedGenders { get; set; }

        public bool GovId { get; set; }

        public bool Lht { get; set; }
    }
}
