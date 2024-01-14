namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class JourneyDataResponse
    {
        public string kind { get; set; }
        public string code { get; set; }
        public List<StopResponse> stops { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
        public string currency { get; set; }
        public string duration { get; set; }

        public double originalprice { get; set; }

        public double internetprice { get; set; }

        public double? providerinternetprice { get; set; }
        public object booking { get; set; }

        public string busname { get; set; }
        public PolicyResponse policy { get; set; }
        public List<string> features { get; set; }
        public string description { get; set; }
        public object available { get; set; }

        public object partnerprovidercode { get; set; }

        public object peronno { get; set; }

        public object partnerproviderid { get; set; }

        public bool issegmented { get; set; }

        public object partnername { get; set; }

        public object providercode { get; set; }

        public double sortingprice { get; set; }
    }
}
