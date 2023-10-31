using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_example.Entity
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public int Int { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}