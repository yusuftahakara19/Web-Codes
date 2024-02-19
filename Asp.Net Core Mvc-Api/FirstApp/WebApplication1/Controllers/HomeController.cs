using FirstApp.Filters;
using FirstApp.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
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
        [ValidFirstName]
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

        public IActionResult Status(int? code)
        {
            return View();
        }

        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            var logFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "logs");
            var logFileName = DateTime.Now.ToString();

            logFileName = logFileName.Replace(" ", "_");
            logFileName = logFileName.Replace("/", "-");
            logFileName = logFileName.Replace(":", "_");
            logFileName += ".txt";
            
            var logFilePath = Path.Combine(logFolderPath, logFileName);

            DirectoryInfo directory = new DirectoryInfo(logFolderPath);

            if (!directory.Exists)
            {
                directory.Create();
            }

            FileInfo file = new FileInfo(logFilePath);

            var writer = file.CreateText();
            writer.WriteLine("Error path : " + exceptionHandlerPathFeature.Path);
            writer.WriteLine("Error : " + exceptionHandlerPathFeature.Error.Message);

            return View();
        }

        public IActionResult Err()
        {
            throw new System.Exception("An Error Occurred");
        }
    }
}
