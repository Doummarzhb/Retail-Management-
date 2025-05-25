using Microsoft.AspNetCore.Mvc;
using RetailManagementSystem.Models;
using System.Collections.Generic;
using System;

namespace RetailManagementSystem.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
             
            var reports = new List<Report>
            {
                new Report { Id = 1, Title = "Sales Report", CreatedDate = DateTime.Now.AddDays(-5), Summary = "Summary of sales" },
                new Report { Id = 2, Title = "Inventory Report", CreatedDate = DateTime.Now.AddDays(-2), Summary = "Summary of inventory status" },
                new Report { Id = 3, Title = "Profit Report", CreatedDate = DateTime.Now.AddDays(-1), Summary = "Summary of profits and losses" }
            };

            return View(reports);
        }

        public IActionResult Details(int id)
        {
            // Mock single report (replace with actual DB lookup)
            var report = new Report
            {
                Id = id,
                Title = $"Sample Report {id}",
                CreatedDate = DateTime.Now,
                Summary = $"Details of report {id}."
            };

            return View(report);
        }
    }
}
