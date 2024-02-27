using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Data.Interfaces;
using Udemy.BankProject.Web.Data.Repositories;
using Udemy.BankProject.Web.Mapping;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IUserMapper _userMapper;
        private readonly IAccountMapper _accountMapper;

        public AccountController( IApplicationUserRepository applicationUserRepository, IUserMapper userMapper, IAccountRepository accountRepository, IAccountMapper accountMapper)
        {
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
            _accountRepository = accountRepository;
            _accountMapper = accountMapper;
        }

         public IActionResult Create(int Id)
        {
            var userInfo = _userMapper.MapToUserList(_applicationUserRepository.GetById(Id));
            return View(userInfo);
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model) {
            _accountRepository.Create(_accountMapper.Map(model));
            return RedirectToAction("Index","Home");
        }
    }
}
