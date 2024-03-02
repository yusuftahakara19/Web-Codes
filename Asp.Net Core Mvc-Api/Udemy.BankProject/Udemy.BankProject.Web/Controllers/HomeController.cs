using Microsoft.AspNetCore.Mvc;
using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Data.UnitOfWork;
using Udemy.BankProject.Web.Mapping;

namespace Udemy.BankProject.Web.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IUserMapper _userMapper;
        private readonly IUow _uow;
        public HomeController(IUow uow, IUserMapper userMapper)
        {
            _uow = uow;
            _userMapper = userMapper;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GetAll()));
        }
    }
}
