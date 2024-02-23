using Microsoft.AspNetCore.Mvc;

namespace Udemy.BankProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
