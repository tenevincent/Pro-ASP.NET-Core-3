using System;
using System.Collections.Generic;
using System.Text;

namespace PartyInvites.Business.Repositories
{
    public interface IDataSource
    { 
        IEnumerable<Product> Products { get; }
    }
     
    public class ProductDataSource : IDataSource
    {
        public IEnumerable<Product> Products =>
            new Product[] {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };
    }
}
