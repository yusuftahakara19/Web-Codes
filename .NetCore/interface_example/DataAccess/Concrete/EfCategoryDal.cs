using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using interface_example.DataAccess.Abstract;
using interface_example.Entity;

namespace interface_example.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public Category GetById(int id)
        {
            return new Category();
        }

        public void Update(Category entity)
        {

        }
        public void Create(Category entity)
        {
        }

        public void Delete(int id)
        {

        }
    }
}