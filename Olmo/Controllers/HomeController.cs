using System.Web.Mvc;
using Olmo.Extras;

namespace Olmo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Headline = "OLMO är ett testprojekt.";
            var message = "Minisetup av Grunt + jshint samt testar en fånig extension från mitt NuGet-paket:";
            ViewBag.Message = message.DoOlmo("<br /><a href=\"https://www.nuget.org/packages/Olmo.Extras/\" target=\"top\">https://www.nuget.org/packages/Olmo.Extras/</a>");
            return View();
        }
    }
}