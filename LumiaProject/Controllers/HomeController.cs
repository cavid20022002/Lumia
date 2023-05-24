using Microsoft.AspNetCore.Mvc;

namespace LumiaProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
