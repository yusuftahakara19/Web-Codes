using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //viewbag, viewdata, tempdata, model
            ViewBag.Name = "Yusuf";
            return View();
        }
    }
}
