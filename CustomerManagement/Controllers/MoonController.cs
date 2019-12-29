using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Controllers
{
    public class MoonController : Controller
    {
        public IActionResult Index()
        {

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer
            {
                Name = "Duy",
                Age = 28
            });

            customers.Add(new Customer
            {
                Name = "Hang",
                Age = 29
            });

            return View(customers);
        }

        public IActionResult Detail(string name)
        {
            Customer customer = new Customer
            {
                Name = name
            };
            return View(customer);
        }
    }
}