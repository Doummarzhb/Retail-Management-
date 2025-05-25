using Microsoft.AspNetCore.Mvc;
using RetailManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace RetailManagementSystem.Controllers
{
    public class ProductsController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200.00m, Quantity = 5 },
            new Product { Id = 2, Name = "Smartphone", Price = 800.00m, Quantity = 10 },
            new Product { Id = 3, Name = "Mouse", Price = 20.00m, Quantity = 50 }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
