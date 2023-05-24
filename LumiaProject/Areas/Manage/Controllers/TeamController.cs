using LumiaProject.DAL;
using LumiaProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LumiaProject.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeamController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Team> teams = await _context.Teams.Include(t=>t.Profession).ToListAsync();
            return View(teams);

        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Professions=await _context.Professions.ToListAsync();
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(Team team)
        {
            if (!ModelState.IsValid) return NotFound();
            if (team.Photo==null)
            {
                ModelState.AddModelError("Photo", "Sekil bos gonderile bilmez");
            }

            ViewBag.Professions = await _context.Professions.ToListAsync();
            return View();

        }

    }
}
