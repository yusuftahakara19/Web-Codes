using Udemy.BankProject.Web.Data.Context;
using Udemy.BankProject.Web.Data.Repositories;

namespace Udemy.BankProject.Web.Data.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly BankContext _context;

        public Uow(BankContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context); 
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges(); 
        }
    }
}
