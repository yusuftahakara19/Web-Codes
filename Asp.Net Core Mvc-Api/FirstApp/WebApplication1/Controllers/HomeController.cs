using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    [Route("Quaresma/[action]")]
    public class HomeController : Controller
    {

        
        public IActionResult Index()
        {
            //viewbag, viewdata, tempdata, model
            ViewBag.Name = "Yusuf";
            ViewData["Name"] = "Taha";
            TempData["Name"] = "Kara";
            Customer customer = new() { firstName = "John", lastName = "Wick", age = 42 };

            return View(customer);
            //return View("Details");
            //  return RedirectToAction("Details",new {@id = 50});
        }

        public IActionResult Details(int id)
        {
            Customer customer = new() { firstName = "Walter", lastName = "White", age = id };
            //Business
            return View("Test",customer);
        }
    }
}
