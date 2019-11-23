using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using CustomerManagement.Services;
using CustomerManagement.Statics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Controllers
{
    [Authorize(Roles = "InternalUser")]
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

        [Authorize(Policy = Permissions.CreateCustomer)]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", customer);
            }
            _service.AddCustomer(customer);
            return Redirect("Index");
        }

        [Authorize(Roles = "InternalUser")]
        public IActionResult View(string id)
        {
            Customer customer = _service.GetCustomerById(id);
            return View(customer);
        }

        [Authorize(Policy = Permissions.DeleteCustomer)]
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