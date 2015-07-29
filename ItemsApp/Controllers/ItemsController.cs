using ItemsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ItemsApp.Controllers
{
    public class ItemsController : ApiController
    {
        Item[] items = new Item[]
        {
            new Item { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Item { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Item { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        public IEnumerable<Item> GetAllProducts()
        {
            return items;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = items.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
