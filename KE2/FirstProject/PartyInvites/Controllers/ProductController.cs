using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Business;
using PartyInvites.Business.Repositories;

namespace PartyInvites.Controllers
{
    public class ProductController : Controller
    {
        
        public IDataSource DataSource
        {
            get;
            set;
        } = new ProductDataSource();


        public ViewResult Index()
        {
            return View(DataSource.Products);
        }


        public ViewResult Index02()
        { 

            IProductSelection cart = new ShoppingCart(
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M });
            return View(cart.Products.Select(p => p?.Name));
        }
    }
}