using Microsoft.AspNetCore.Mvc;

namespace TechnicalService.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
