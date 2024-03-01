using System.Collections.Generic;
using System.Linq;
using Udemy.BankProject.Web.Data.Context;

namespace Udemy.BankProject.Web.Data.Repositories
{
    public class Repository<T>: IRepository<T> where T : class, new()
    {
        private readonly BankContext _context;

        public Repository(BankContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }
    }
}
