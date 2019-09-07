using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                var product = new Product()
                {
                    Name = "apple",
                    Price = 1.2m,
                    Description = "This is an apple",
                    Category = "food",
                };

                ctx.Products.Add(product);
                ctx.SaveChanges();
            }
            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
