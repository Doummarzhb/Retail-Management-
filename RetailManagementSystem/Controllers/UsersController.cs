using Microsoft.AspNetCore.Mvc;
using RetailManagementSystem.Models;
using System.Collections.Generic;

namespace RetailManagementSystem.Controllers
{
    public class UsersController : Controller
    {
        // Simulating a data source (replace with EF DbContext later)
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Username = "admin", Email = "admin@example.com", Password = "admin123", Role = "Admin" },
            new User { Id = 2, Username = "employee", Email = "emp@example.com", Password = "emp123", Role = "Employee" }
        };

        public IActionResult Index()
        {
            return View(users); // Pass list to the view
        }

        public IActionResult Details(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null) return NotFound();
            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = users.Count + 1;
                users.Add(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}
