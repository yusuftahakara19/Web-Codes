using System.Collections.Generic;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Data.Entities;
using Udemy.BankProject.Web.Data.Interfaces;

namespace Udemy.BankProject.Web.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }

        public List<ApplicationUser> GetAll()
        {
          return  _context.ApplicationUsers.ToList();
        }

        public ApplicationUser GetById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }
    }
}
