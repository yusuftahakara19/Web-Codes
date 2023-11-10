using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace entityFramework
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseMySql(@"server=localhost;port=3306;database=ShopDb;user=root;password=mysql123;");
        }
    }

    // One to Many
    // One to One
    // Many to Many

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public Customer Customer { get; set; }
        public List<Address> Addresses { get; set; } // navigation property
    }

    public class Customer
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User User { get; set; } // uniqe olması için hem buna hem de user'a koyduk
        public int UserId { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public User User { get; set; } // navigation property
        public int UserId { get; set; } // int=> null, 1, 2, 3, 4
    }
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ShopContext())
            {
                // var customer = new Customer(){
                //         IdentityNumber="12313132",
                //         FirstName="Sadık",
                //         LastName="Turan",
                //         User = db.Users.FirstOrDefault(i=>i.Id==3)
                // };

                // db.Customers.Add(customer);
                // db.SaveChanges();


                var user = new User()
                {
                    Username = "deneme2",
                    Email = "deneme2@gmail.com",
                };

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        static void InsertUsers()
        {
            var users = new List<User>(){
                new User(){Username="sadikturan",Email="info@sadikturan.com"},
                new User(){Username="cinarturan",Email="info@cinarturan.com"},
                new User(){Username="yigitbilgi",Email="info@yigitbilgi.com"},
                new User(){Username="adabilgi",Email="info@adabilgi.com"},
            };

            using (var db = new ShopContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }
        static void InsertAddresses()
        {
            var addresses = new List<Address>(){
                new Address(){Fullname="Sadık Turan",Title="Ev adresi",Body="Kocaeli",UserId=1},
                new Address(){Fullname="Sadık Turan",Title="İş adresi",Body="Kocaeli",UserId=1},
                new Address(){Fullname="Yiğit Bilgi",Title="Ev adresi",Body="Kocaeli",UserId=3},
                new Address(){Fullname="Yiğit Bilgi",Title="İş adresi",Body="Kocaeli",UserId=3},
                new Address(){Fullname="Çınar Turan",Title="İş adresi",Body="Kocaeli",UserId=2},
                new Address(){Fullname="Ada Bilgi",Title="İş adresi",Body="Kocaeli",UserId=4}

            };

            using (var db = new ShopContext())
            {
                db.Addresses.AddRange(addresses);
                db.SaveChanges();
            }
        }


    }
}
