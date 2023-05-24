using Microsoft.AspNetCore.Mvc;

namespace LumiaProject.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
