using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolykMidtermA.Data;
using VolykMidtermA.Models;

namespace VolykMidtermA.Controllers
{
    public class TeamsController : Controller
    {
        // shared db obj
        private readonly ApplicationDbContext _context;

        // constructor w/db dependency
        public TeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var teams = _context.Team
                .OrderBy(t => t.Ranking)
                .ToList();

            return View(teams);
        }

        // GET: Teams/Create ADMIN ONLY
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
