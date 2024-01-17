using OBilet.Presentation.UI.Web.Models.Response.OBiletAPI.Journey;
using System;
using System.Globalization;

namespace OBilet.Presentation.UI.Web.Models.Journey
{
    public class JourneyListViewModel
    {
        public JourneyResponse JourneyResponse { get; set; }

        public DateTime DepartureDate { get; set; }

        public string DepartureDateText
        {
            get
            {
                CultureInfo turkishCulture = new CultureInfo("tr-TR");
                string formattedDate = DepartureDate.ToString("dd MMMM dddd", turkishCulture);

                return formattedDate;
            }
        }
    }
}
