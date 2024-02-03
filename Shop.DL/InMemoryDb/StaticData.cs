using Shop.Models.SS;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DL.InMemoryDb
{
    public class InMemoryDb
    {
        public List<Product> Products { get; set; }
        public List<Price> Prices { get; set; }

        public InMemoryDb()
        {
            
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Product1", Price = 10.99 },
                new Product { Id = 2, Name = "Product2", Price = 20.49 },
                
            };

            Prices = new List<Price>
            {
                new Price { Id = 1, ProductId = 1, Value = 9.99 },
                new Price { Id = 2, ProductId = 2, Value = 19.99 },
                
            };
        }
    }
}
