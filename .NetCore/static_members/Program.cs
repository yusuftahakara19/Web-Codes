﻿using System;

namespace static_members
{

    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
    }

    static class ProductManager
    {
        static Product[] Products;

        static ProductManager()
        {
            Products = new Product[5];
            Products[0] = new Product { ProductId = 1, ProductName = "Iphone5", Price = 2000, IsApproved = false };
            Products[1] = new Product { ProductId = 2, ProductName = "Iphone6", Price = 3000, IsApproved = false };
            Products[2] = new Product { ProductId = 3, ProductName = "Iphone7", Price = 4000, IsApproved = true };
            Products[3] = new Product { ProductId = 4, ProductName = "Iphone8", Price = 5000, IsApproved = true };
            Products[4] = new Product { ProductId = 5, ProductName = "Iphone9", Price = 6000, IsApproved = true };
        }

        public static Product[] GetProducts()
        {
            return Products;
        }

        public static Product GetProductById(int id)
        {
            Product product = null;
            foreach (var p in Products)
            {
                if (p.ProductId == id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }

        public static Product GetProductByName(string name)
        {
            Product product = null;
            foreach (var p in Products)
            {
                if (p.ProductName.ToLower().Contains(name.ToLower()))
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Product p = ProductManager.GetProductById(2);
            Console.WriteLine($"Name : {p.ProductName} Price : ${p.Price}");
            p = ProductManager.GetProductByName("Iphone7");
            Console.WriteLine($"Name : {p.ProductName} Price : ${p.Price}");

            p = ProductManager.GetProductByName("Iphone");
            Console.WriteLine($"Name : {p.ProductName} Price : ${p.Price}");




            // var products = ProductManager.GetProducts();

            // foreach (var p in products)
            // {
            //     Console.WriteLine($"Name : {p.ProductName} Price : ${p.Price}");
            // }
        }
    }
}
