using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    // Web API controller inherit the ApiController class
    public class ProductsController : ApiController
    {
        // is this an array? is this the way how to create mutiple objects.
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M },
            
        };

        List<Product> products1 = new List<Product>();


        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            // What is this ? Linq?
           var product = products.FirstOrDefault((p) => p.Id == id);


           


            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
