using EfCore.Data.Contexts;
using EfCore.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EfCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UdemyContext context = new UdemyContext();
            Product product = new Product()
            {
                Price = 4500
            };
            context.Products.Add(product);  
            context.SaveChanges();  
            return View();
        }
    }
}
