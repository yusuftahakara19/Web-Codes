using Udemy.BankProject.Web.Data.Entities;

namespace Udemy.BankProject.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        void Create(Account account);
    }
}
