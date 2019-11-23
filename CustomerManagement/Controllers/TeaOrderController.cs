using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Services;
using CustomerManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerManagement.Controllers
{
    [Authorize]
    public class TeaOrderController : Controller
    {
        private readonly ICustomerService _service;
        private readonly ITeaOrderService _orderService;
        public TeaOrderController(ICustomerService service, ITeaOrderService orderService)
        {
            _service = service;
            _orderService = orderService;
        }
        [Authorize]
        public IActionResult Index()
        {
            var a = _orderService.GetOrders();
            return View(a);
        }

        public IActionResult OrdersByCustomer(string Id)
        {

            return View();
        }

        [Authorize(Roles = "InternalUser1")]
        public IActionResult Create()
        {
            TeaOrderViewModel model = new TeaOrderViewModel();
            model.CustomerSelections = _service.GetCustomers().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            model.Teas = _orderService.GetTeas().Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();

            return View(model);
        }

        public IActionResult SaveCreate(TeaOrderViewModel model)
        {
            _orderService.AddOrder(model);
            return Redirect("Index");
        }

        public IActionResult Detail(string id)
        {

            return View();
        }
    }
}