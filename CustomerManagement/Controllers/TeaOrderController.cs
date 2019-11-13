using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Services;
using CustomerManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerManagement.Controllers
{
    public class TeaOrderController : Controller
    {
        private readonly ICustomerService _service;
        private readonly ITeaOrderService _orderService;
        public TeaOrderController(ICustomerService service, ITeaOrderService orderService)
        {
            _service = service;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var a = _orderService.GetOrders();
            return View(a);
        }

        public IActionResult Create()
        {
            TeaOrderViewModel model = new TeaOrderViewModel();
            model.CustomerSelections = _service.GetCustomers().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            return View(model);
        }

        public IActionResult SaveCreate(TeaOrderViewModel model)
        {
            _orderService.AddOrder(model);
            return Redirect("Index");
        }
    }
}