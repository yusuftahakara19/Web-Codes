using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using Udemy.BankProject.Web.Data.Configurations;
using Udemy.BankProject.Web.Data.Entities;

namespace Udemy.BankProject.Web.Data.Context
{
    public class BankContext:DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers{ get; set; }
        public DbSet<Account> Accounts{ get; set; }
        public BankContext(DbContextOptions<BankContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=ARC166NB\\SQLEXPRESS; database=UdemyEfCore.Query;integrated security=true;");
        //    optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
