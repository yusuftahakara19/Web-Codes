using Udemy.BankProject.Web.Data.Repositories;

namespace Udemy.BankProject.Web.Data.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : class, new();
        void SaveChanges();
    }
}