using System.Collections.Generic;
using Udemy.BankProject.Web.Data.Entities;

namespace Udemy.BankProject.Web.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
    }
}
