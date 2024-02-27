using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Models;

namespace Udemy.BankProject.Web.Mapping
{
    public class AccountMapper : IAccountMapper
    {
        public Account Map(AccountCreateModel account)
        {
            return new Account
            {
                Balance = account.Balance,
                AccountNumber = account.AccountNumber,
                ApplicationUserId = account.ApplicationUserId
            };
        }
    }
}
