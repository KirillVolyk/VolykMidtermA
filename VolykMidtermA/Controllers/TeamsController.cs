using Microsoft.AspNetCore.Mvc;

namespace VolykMidtermA.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
