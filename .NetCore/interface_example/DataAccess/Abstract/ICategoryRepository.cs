using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interface_example.Entity;

namespace interface_example.DataAccess.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {

    }
}