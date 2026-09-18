using Microsoft.AspNetCore.Mvc;

namespace ZombieParty.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }


}
