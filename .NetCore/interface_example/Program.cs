using System;
using interface_example.DataAccess.Abstract;
using interface_example.DataAccess.Concrete;
using interface_example.Entity;

namespace interface_example
{

    class ProductManager : IProductRepository
    {
        IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Create(Product entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);

        }

        public Product GetById(int id)
        {
            return _repository.GetById(id);
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

    class Program
    {
        static void Main(string[] args)
        {

            var productDal = new EfProductDal();
            // productDal.Create(new Product());

            var productRepository = new ProductManager(productDal);

            productRepository.Create(new Product());

        }
    }
}
