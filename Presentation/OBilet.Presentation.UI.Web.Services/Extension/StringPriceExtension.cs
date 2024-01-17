using System.Globalization;

namespace OBilet.Presentation.UI.Web.Services.Extension
{
    public static class StringPriceExtension
    {
        public static string TurkishLiraWithoutCurrency(this double amount)
        {
            CultureInfo turkishCulture = new CultureInfo("tr-TR");

            turkishCulture.NumberFormat.CurrencySymbol = "";
            string formattedAmount = amount.ToString("C", turkishCulture);

            return formattedAmount;
        }
    }
}
