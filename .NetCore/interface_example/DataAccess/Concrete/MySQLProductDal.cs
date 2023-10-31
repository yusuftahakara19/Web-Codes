using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interface_example.DataAccess.Abstract;
using interface_example.Entity;

namespace interface_example.DataAccess.Concrete
{
    public class MySQLProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            Console.WriteLine("MySQLProductDal Create");

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetPopulerProducts()
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}