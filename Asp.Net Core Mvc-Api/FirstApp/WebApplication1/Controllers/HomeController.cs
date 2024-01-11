using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
