using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Diagnostics.Contracts;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using entityFramework.Data.EfCore;


namespace entityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                var customers = db.Customers
                    .Where(i => i.Orders.Count() > 0)
                    .Select(i => new
                    {
                        i.FirstName
                    })
                    .ToList();

                foreach (var item in customers)
                {
                    Console.WriteLine(item.FirstName);
                }
            }

        }


    }
}
