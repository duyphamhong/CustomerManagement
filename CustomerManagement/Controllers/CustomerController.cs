using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using CustomerManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var listCustomer = _service.GetCustomers();
            return View(listCustomer);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(Customer customer)
        {
            _service.AddCustomer(customer);
            return Redirect("Index");
        }
        public IActionResult View(string id)
        {
            Customer customer = _service.GetCustomerById(id);
            return View(customer);
        }

        public IActionResult Delete(string id)
        {
            _service.DeleteCustomer(id);
            return RedirectToAction("Index");
        }

        public IActionResult ListOrderByCustomer(string id)
        {
            Customer customer = _service.GetCustomerById(id);
            return View(customer);
        }
    }
}