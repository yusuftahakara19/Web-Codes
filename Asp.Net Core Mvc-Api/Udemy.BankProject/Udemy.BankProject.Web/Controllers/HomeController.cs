using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Data.Interfaces;
using Udemy.BankProject.Web.Data.Repositories;
using Udemy.BankProject.Web.Mapping;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        public HomeController(BankContext context, IApplicationUserRepository applicationUserRepository, IUserMapper userMapper)
        {
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_applicationUserRepository.GetAll()));
        }
    }
}
