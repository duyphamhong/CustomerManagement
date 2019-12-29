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
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        private readonly IProductService _productService;

        public OrderController(IOrderService service, IProductService productService)
        {
            _service = service;
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            OrderViewModel viewModel = new OrderViewModel();
            viewModel.ProductSelection = _productService.GetAllProducts()
                .Select(x => new SelectListItem 
                { 
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
            return View(viewModel);
        }

        public IActionResult SaveNew(OrderViewModel order)
        {
            _service.Add(order);
            return Redirect("Index");
        }
    }
}