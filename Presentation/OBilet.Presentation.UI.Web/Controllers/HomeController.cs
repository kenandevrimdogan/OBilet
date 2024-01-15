using Microsoft.AspNetCore.Mvc;

namespace OBilet.Presentation.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
