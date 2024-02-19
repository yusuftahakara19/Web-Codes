using Microsoft.AspNetCore.Mvc;

namespace EfCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
