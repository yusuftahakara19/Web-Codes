using EfCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Data.Contexts
{
    public class UdemyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ARC166NB\\SQLEXPRESS; database=UdemyEfCore;integrated security=true;");
        }

    }
}
