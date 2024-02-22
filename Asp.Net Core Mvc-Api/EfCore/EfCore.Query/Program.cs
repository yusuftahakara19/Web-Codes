using EfCore.Query.Data.Context;
using System;
using System.Linq;

namespace EfCore.Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlogContext context = new BlogContext();
            //context.Blogs.Add(new Data.Entities.Blog { Title = "blog-2", Url = "ytk.com/blog-2" });
            //context.Blogs.Add(new Data.Entities.Blog { Title = "blog-3", Url = "ytk.com/blog-3" });
            //context.Blogs.Add(new Data.Entities.Blog { Title = "blog-4", Url = "ytk.com/blog-4" });
            //context.SaveChanges();  
            var query = context.Blogs.AsQueryable();
            var blogs = query.Where(x => x.Title.Contains("-") || x.Title.Contains("l")).ToList();
            
            foreach(var blog in blogs) { 
                Console.WriteLine(blog.Title);
            }

            Console.WriteLine("finish!");
        }
    } 
}
