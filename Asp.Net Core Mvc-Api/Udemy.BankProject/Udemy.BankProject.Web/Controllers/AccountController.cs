using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Data.Interfaces;
using Udemy.BankProject.Web.Data.Repositories;
using Udemy.BankProject.Web.Data.UnitOfWork;
using Udemy.BankProject.Web.Mapping;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUow _uow;
        public AccountController(IUow uow)
        {
            _uow = uow;
        }

        public IActionResult Create(int Id)
        {
            var userInfo = _uow.GetRepository<ApplicationUser>().GetById(Id);
            return View(new UserListModel { Id = userInfo.Id, Name = userInfo.Name, Surname = userInfo.Surname });
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {
            _uow.GetRepository<Account>().Create(new Account
            {
                Balance = model.Balance,
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId
            });
            _uow.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult GetAccountsByUserId(int userId)
        {
            var query = _uow.GetRepository<Account>().GetQueryable();
            var accounts = query.Where(x => x.ApplicationUserId == userId).ToList();
            var user = _uow.GetRepository<ApplicationUser>().GetById(userId);
            var list = new List<AccountListModel>();
            ViewBag.FullName = user.Name + " " + user.Surname;

            foreach (var account in accounts)
            {
                list.Add(new AccountListModel
                {
                    Balance = account.Balance,
                    AccountNumber = account.AccountNumber,
                    ApplicationUserId = account.ApplicationUserId,
                    Id = account.Id
                });
            }

            return View(list);
        }

        [HttpGet]
        public IActionResult SendMoney(int accountId)
        {
            var query = _uow.GetRepository<Account>().GetQueryable();
            var accounts = query.Where(x => x.Id != accountId).ToList();
            var list = new List<AccountListModel>();
            ViewBag.SenderId = accountId;
            foreach (var account in accounts)
            {
                list.Add(new AccountListModel { Balance = account.Balance, ApplicationUserId = account.ApplicationUserId, AccountNumber = account.AccountNumber, Id = account.Id });
            }
            return View(new SelectList(list,"Id","AccountNumber"));
        }
        
        [HttpPost]
        public IActionResult SendMoney(SendMoneyModel model)
        {
            var senderAccount = _uow.GetRepository<Account>().GetById(model.SenderId);
            senderAccount.Balance -= model.Amount;
            _uow.GetRepository<Account>().Update(senderAccount);

            var account = _uow.GetRepository<Account>().GetById(model.AccountId);
            account.Balance += model.Amount;
            _uow.GetRepository<Account>().Update(account);
            _uow.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
