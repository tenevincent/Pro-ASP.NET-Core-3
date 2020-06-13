using System;
using System.Collections.Generic;
using System.Text;

namespace PartyInvites.Business
{
    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new List<Product>();

        public ShoppingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }

        public IEnumerable<Product> Products { get => products; }
    }
}
