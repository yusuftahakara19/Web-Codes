using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Data.Interfaces;
using Udemy.BankProject.Web.Data.Repositories;
using Udemy.BankProject.Web.Mapping;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IApplicationUserRepository _applicationUserRepository;
        //private readonly IAccountRepository _accountRepository;
        //private readonly IUserMapper _userMapper;
        //private readonly IAccountMapper _accountMapper;

        //public AccountController( IApplicationUserRepository applicationUserRepository, IUserMapper userMapper, IAccountRepository accountRepository, IAccountMapper accountMapper)
        //{
        //    _applicationUserRepository = applicationUserRepository;
        //    _userMapper = userMapper;
        //    _accountRepository = accountRepository;
        //    _accountMapper = accountMapper;
        //}
        private readonly IRepository<Account> _accountRepository;
        private readonly IApplicationUserRepository _applicationUserRepository;

        public AccountController(IRepository<Account> accountRepository, IApplicationUserRepository applicationUserRepository)
        {
            _accountRepository = accountRepository;
            _applicationUserRepository = applicationUserRepository;
        }

        public IActionResult Create(int Id)
        {
            var userInfo = _applicationUserRepository.GetById(Id);
            return View(new UserListModel { Id = userInfo.Id, Name = userInfo.Name, Surname = userInfo.Surname });
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {
            _accountRepository.Create(new Account
            {
                Balance = model.Balance,
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId
            });
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult GetAccountsByUserId(int userId)
        {
            var query = _accountRepository.GetQueryable();
            var accounts = query.Where(x => x.ApplicationUserId == userId).ToList();
            var user = _applicationUserRepository.GetById(userId);
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
            var query = _accountRepository.GetQueryable();
            var accounts = query.Where(x => x.Id != accountId).ToList();
            var list = new List<AccountListModel>();
            ViewBag.SenderId = accountId;
            foreach (var account in accounts)
            {
                list.Add(new AccountListModel { Balance = account.Balance, ApplicationUserId = account.ApplicationUserId, AccountNumber = account.AccountNumber, Id = account.Id });
            }
            return View(list);
        }
    }
}
