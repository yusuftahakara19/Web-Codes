using System.Collections.Generic;
using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        UserListModel MapToUserList(ApplicationUser user);  
    }
}
