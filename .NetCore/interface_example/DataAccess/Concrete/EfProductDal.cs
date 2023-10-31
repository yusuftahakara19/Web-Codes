using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interface_example.DataAccess.Abstract;
using interface_example.Entity;

namespace interface_example.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        public Product GetById(int id)
        {
            return new Product();
        }

        public void Update(Product entity)
        {

        }
        public void Create(Product entity)
        {
            Console.WriteLine("EFProduct Created");

        }

        public void Delete(int id)
        {

        }

        public Product[] GetProductsByCategory(int id)
        {
            return new Product[3];
        }

        public Product[] GetPopulerProducts()
        {
            throw new NotImplementedException();
        }
    }
}