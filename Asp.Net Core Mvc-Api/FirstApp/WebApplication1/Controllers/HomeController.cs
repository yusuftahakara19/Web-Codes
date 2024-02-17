using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            return View(new Customer());  
        }

        [HttpPost]  
        public IActionResult Create(Customer customer)
        {
            //var validControl = ModelState.IsValid;
            //var errors = ModelState.Values.SelectMany(x => x.Errors.Select(y=>y.ErrorMessage));
            ModelState.Remove("Id");
            if(customer.firstName == "admin")
            {
                ModelState.AddModelError("","Firstname cannot be 'admin'");
            }

            if (ModelState.IsValid)
            {
                Customer lastCustomer = null;

                if (CustomerContext.Customers.Count > 0)
                {
                    lastCustomer = CustomerContext.Customers.Last();
                }

                customer.Id = 1;
                if (lastCustomer != null)
                {
                    customer.Id = lastCustomer.Id + 1;
                }

                CustomerContext.Customers.Add(customer);

                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var removedCustomer = CustomerContext.Customers.Find(a => a.Id == id);
            if (removedCustomer != null)
            {
                CustomerContext.Customers.Remove(removedCustomer);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a => a.Id == id);
            return View(updatedCustomer);
        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            Customer updatedCustomer = CustomerContext.Customers.FirstOrDefault(x => x.Id == customer.Id);
            updatedCustomer.firstName = customer.firstName;
            updatedCustomer.lastName = customer.lastName;
            updatedCustomer.age = customer.age;
            return RedirectToAction("Index");
        }
    }
}
