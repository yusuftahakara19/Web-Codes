using EfCore.Query.Data.Configurations;
using EfCore.Query.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Query.Data.Context
{
    public class BlogContext: DbContext
    {
        public DbSet<Blog> Blogs{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ARC166NB\\SQLEXPRESS; database=UdemyEfCore.Query;integrated security=true;");
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
