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
                for (int i = 0; i < 20; i++)
                {
                    var product1 = new Product()
                    {
                        Name = $"apple{i}",
                        Price = i + 1m,
                        Description = $"This is an apple {i}",
                        Category = "food",
                    };

                    var product2 = new Product()
                    {
                        Name = $"book{i}",
                        Price = i + 1m,
                        Description = $"this is a book {i}",
                        Category = "book"

                    };
                    ctx.Products.Add(product1);
                    ctx.Products.Add(product2);
                }
                ctx.SaveChanges();
            }
                Console.WriteLine("done");
                Console.ReadLine();
        }
    }
}
