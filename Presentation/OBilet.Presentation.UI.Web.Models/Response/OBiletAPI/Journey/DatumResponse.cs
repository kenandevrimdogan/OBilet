namespace OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey
{
    public class DatumResponse
    {
        public int id { get; set; }

        public int partnerid { get; set; }

        public string partnername { get; set; }

        public int routeid { get; set; }

        public string bustype { get; set; }

        public string bustypename { get; set; }

        public int totalseats { get; set; }

        public int availableseats { get; set; }

        public JourneyDataResponse journey { get; set; }

        public List<FeatureResponse> features { get; set; }

        public string originlocation { get; set; }

        public string destinationlocation { get; set; }

        public bool isactive { get; set; }

        public int originlocationid { get; set; }

        public int destinationlocationid { get; set; }

        public bool ispromoted { get; set; }

        public int cancellationoffset { get; set; }

        public bool hasbusshuttle { get; set; }

        public bool disablesaleswithoutgovid { get; set; }

        public string displayoffset { get; set; }

        public object partnerrating { get; set; }

        public bool hasdynamicpricing { get; set; }

        public bool disablesaleswithouthescode { get; set; }

        public bool disablesingleseatselection { get; set; }

        public int changeoffset { get; set; }
        public int rank { get; set; }

        public bool displaycouponcodeinput { get; set; }

        public bool disablesaleswithoutdateofbirth { get; set; }

        public int openoffset { get; set; }

        public object displaybuffer { get; set; }

        public bool allowsalesforeignpassenger { get; set; }

        public bool hasseatselection { get; set; }

        public List<object> brandedfares { get; set; }

        public bool hasgenderselection { get; set; }

        public bool hasdynamiccancellation { get; set; }

        public object partnertermsandconditions { get; set; }

        public string partneravailablealphabets { get; set; }

        public int providerid { get; set; }

        public string partnercode { get; set; }

        public bool enablefulljourneydisplay { get; set; }

        public string providername { get; set; }

        public bool enableallstopsdisplay { get; set; }

        public bool isdestinationdomestic { get; set; }

        public object minlengovid { get; set; }

        public object maxlengovid { get; set; }

        public bool requireforeigngovid { get; set; }

        public bool iscancellationinfotext { get; set; }

        public object cancellationoffsetinfotext { get; set; }

        public bool istimezonenotequal { get; set; }

        public double markuprate { get; set; }

        public bool isprintticketbeforejourney { get; set; }

        public bool isextendedjourneydetail { get; set; }
    }
}
