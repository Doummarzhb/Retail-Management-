using Microsoft.AspNetCore.Mvc;
using RetailManagementSystem.Models;

namespace RetailManagementSystem.Controllers
{
    public class OrdersController : Controller
    {
        private static List<Order> _orders = new List<Order>();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                order.Id = _orders.Count + 1;
                _orders.Add(order);
                return RedirectToAction("Details", new { id = order.Id });
            }
            return View(order);
        }

        public IActionResult Details(int id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return View(order);
        }
    }
}
