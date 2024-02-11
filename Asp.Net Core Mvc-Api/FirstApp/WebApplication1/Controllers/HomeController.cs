using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{

    public class HomeController : Controller
    {

        
        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]  
        public IActionResult CreateWithForm()
        {
            return View();
        }
    }
}
