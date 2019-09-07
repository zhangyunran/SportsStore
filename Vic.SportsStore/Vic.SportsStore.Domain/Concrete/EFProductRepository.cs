using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.Domain.Concrete
{
    public class EFProductRepository: InMemoryProductsRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Product
        {
            get { return context.Products;}
        }
    }
}
