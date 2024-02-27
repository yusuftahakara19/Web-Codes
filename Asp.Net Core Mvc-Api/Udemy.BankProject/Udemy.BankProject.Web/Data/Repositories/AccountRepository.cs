using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Data.Interfaces;

namespace Udemy.BankProject.Web.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        public void Create(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges(); 
        }
    }
}
