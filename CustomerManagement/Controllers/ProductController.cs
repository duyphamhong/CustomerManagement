using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Services;
using CustomerManagement.Statics;
using CustomerManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService service, ICategoryService categoryService)
        {
            _service = service;
            _categoryService = categoryService;
        }

       // [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var listProducts = _service.GetAllProducts();
            return View(listProducts);
        }

        [Authorize(Policy = Permissions.CreateCustomer)]
        public IActionResult Create()
        {
            ProductViewModel model = new ProductViewModel();
            model.CategorySelections = _categoryService.GetCategorySelection();
            return View(model);
        }

        public IActionResult SaveNew(ProductViewModel product)
        {
            _service.AddProduct(product);
            return Redirect("Index");
        }

        public IActionResult View(Guid id)
        {
            var product = _service.GetProduct(id);
            return View(product);
        }

        [HttpGet]
        public Task<List<ProductViewModel>> Products(int numberOfQuantity)
        {
            var listProducts = _service.GetProducts(numberOfQuantity);
            return Task.FromResult(listProducts);
        }
    }
}