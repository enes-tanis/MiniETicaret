using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            =>new() 
            {

                    new() { Id = Guid.NewGuid(), Name = "Product 1", Stock = 100, Price = 110 },
                    new() { Id = Guid.NewGuid(), Name = "Product 2", Stock = 150, Price = 120 },
                    new() { Id = Guid.NewGuid(), Name = "Product 3", Stock = 80, Price = 90 },
                    new() { Id = Guid.NewGuid(), Name = "Product 4", Stock = 200, Price = 80 },
                    new() { Id = Guid.NewGuid(), Name = "Product 5", Stock = 50, Price = 150 },
                    new() { Id = Guid.NewGuid(), Name = "Product 6", Stock = 120, Price = 100 },
                    new() { Id = Guid.NewGuid(), Name = "Product 7", Stock = 75, Price = 130 },
                    new() { Id = Guid.NewGuid(), Name = "Product 8", Stock = 180, Price = 95 },
                    new() { Id = Guid.NewGuid(), Name = "Product 9", Stock = 110, Price = 140 },
                    new() { Id = Guid.NewGuid(), Name = "Product 10", Stock = 160, Price = 75 }
            };
        
    }
}
