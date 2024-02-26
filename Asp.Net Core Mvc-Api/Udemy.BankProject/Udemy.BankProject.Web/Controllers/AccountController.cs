using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly BankContext _context;

        public AccountController(BankContext context)
        {
            _context = context;
        }

        public IActionResult Create(int Id)
        {
            var userInfo = _context.ApplicationUsers.Select(x=> new UserListModel
            {
                Id = x.Id, Name = x.Name, Surname = x.Surname
            }).SingleOrDefault(x => x.Id == Id);
            return View(userInfo);
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model) {

            _context.Accounts.Add(new Data.Entities.Account
            {
                Balance = model.Balance,
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId
            });
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}
