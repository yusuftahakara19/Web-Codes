using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Mapping
{
    public interface IAccountMapper
    {
        Account Map(AccountCreateModel account);
    }
}
