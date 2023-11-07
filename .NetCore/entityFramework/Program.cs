using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Runtime.CompilerServices;

namespace entityFramework
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseLoggerFactory(MyLoggerFactory)
            .UseSqlite("Data Source=shop.db");
        }
        public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddConsole(); });
    }

    public class Product
    {
        public int ProductId { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DeleteProduct();
        }
        static void DeleteProduct()
        {
            using (var db = new ShopContext())
            {
                var p = new Product() { ProductId = 5 };
                //   db.Products.Remove(p);
                db.Entry(p).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        static void DeleteProduct2(int id)
        {
            using (var db = new ShopContext())
            {
                var p = db.Products.FirstOrDefault(i => i.ProductId == id);

                if (p != null)
                {
                    db.Products.Remove(p);
                    // db.Remove(p);
                    db.SaveChanges();

                    Console.WriteLine("Veri Silindi");
                }
            }
        }
        static void UpdateProduct()
        {
            using (var db = new ShopContext())
            {
                var p = db.Products.Where(i => i.ProductId == 1).FirstOrDefault();
                if (p != null)
                {
                    p.Price = 1900;
                    db.Products.Update(p);
                    db.SaveChanges();
                }
            }
        }
        static void UpdateProduct2()
        {
            using (var db = new ShopContext())
            {
                var entity = new Product() { ProductId = 1 };
                db.Products.Attach(entity);
                entity.Price = 50000;
                db.SaveChanges();
            }
        }
        static void UpdateProduct3()
        {
            using (var db = new ShopContext())
            {
                // change tracking ile alınan objenin takibi yapılır.
                /*
                var product = db.Products.AsNoTracking().Where(i => i.ProductId == 1).FirstOrDefault();
                yaparsan p objesi takip edilmez. update yapılmaz.

                AsNoTracking fonksiyonunu veritabanından bir kayıt alıp herhangi değişiklik yapmayacağın durumlarda kullanmalısın.

                */
                // db.SaveChanges(); dediğin anda tüm değişiklikler uygulanır.
                var product = db.Products.Where(i => i.ProductId == 1).FirstOrDefault();
                if (product != null)
                {
                    product.Price *= 1.2m;
                    db.SaveChanges();

                    Console.WriteLine("Güncelleme Yapıldı");
                }
            }
        }
        static void GetAllProductByName(string name)
        {
            using (var context = new ShopContext())
            {
                // var products = context.Products; // Bir listenin referasını alırız. bu haliyle
                var results =
                    context
                    .Products
                    .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                    .Select(p => new { p.Name, p.Price })
                .ToList(); // tolist demeye gerek yok çünkü bir list dönmeyecek
                           //firstOrDefalt kayıt bulursa onu gönderir bulamazsa null koyar.

                foreach (var item in results)
                {
                    System.Console.WriteLine($"NAME : {item.Name} Price : {item.Price}");

                }


            }
        }

        static void GetAllProductById(int id)
        {
            using (var context = new ShopContext())
            {
                // var products = context.Products; // Bir listenin referasını alırız. bu haliyle
                var result =
                    context
                    .Products
                    .Where(p => p.ProductId == id)
                    .Select(p => new { p.Name, p.Price })
                    .FirstOrDefault(); // tolist demeye gerek yok çünkü bir list dönmeyecek
                                       // firstOrDefault kayıt bulursa onu dönderir bulamazsa null koyar.
                System.Console.WriteLine($"NAME : {result.Name} Price : {result.Price}");


            }
        }

        static void GetAllProducts()
        {
            using (var context = new ShopContext())
            {
                // var products = context.Products; // Bir listenin referasını alırız. bu haliyle
                var products =
                context
                .Products
                .Select(p => new
                { p.Name, p.Price })
                .ToList(); // veritabanına select sorgusunu gönderdik

                foreach (var item in products)
                {
                    System.Console.WriteLine($"NAME : {item.Name} Price : {item.Price}");
                }
            }
        }

        static void AddProducts()
        {
            using (var db = new ShopContext())
            {
                var products = new List<Product>
                {
                    new Product { Name = "Iphone S6", Price = 3000 },
                    new Product { Name = "Iphone S7", Price = 4000 },
                    new Product { Name = "Iphone S8", Price = 5000 },
                    new Product { Name = "Iphone S9", Price = 6000 }
                };

                // Add bir tane ekler
                // AddRange collection ekler
                db.Products.AddRange(products);

                db.SaveChanges(); // Olan tüm değişiklikleri database'e yansıtır.

                Console.WriteLine("Veriler eklendi");
            }
        }

        static void AddProduct()
        {
            using (var db = new ShopContext())
            {
                var product = new Product { Name = "Samsung S10", Price = 8000 };
                db.Products.Add(product);
                db.SaveChanges();
                Console.WriteLine("Veri eklendi");
            }
        }

    }
}