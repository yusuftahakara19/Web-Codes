using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Controllers
{
    public class HomeController : Controller
    {   private readonly BankContext _context;

        public HomeController(BankContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.ApplicationUsers.Select(x=> new UserListModel
            {
                Id = x.Id, Name = x.Name,Surname=x.Surname
            }).ToList());
        }
    }
}
