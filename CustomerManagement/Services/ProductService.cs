using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustomerManagement.Repositories;
using CustomerManagement.ViewModels;

namespace CustomerManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void AddProduct(ProductViewModel product)
        {
            _repo.AddProduct(_mapper.Map<Product>(product));
        }

        public double CalculateTotalPrices(Product product)
        {
            return product.Quantity * product.Price;
        }

        public List<ProductViewModel> GetAllProducts()
        {
            var products = _repo.GetAllProducts();
            List<ProductViewModel> viewModels = new List<ProductViewModel>();
            foreach (var product in products)
            {
                viewModels.Add(new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    TotalPrice = CalculateTotalPrices(product)
                });
            }
            return viewModels;
        }

        public ProductViewModel GetProduct(Guid id)
        {
            var productModel = _repo.GetProduct(id);
            var viewModel = new ProductViewModel
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Quantity = productModel.Quantity,
                Price = productModel.Price,
                TotalPrice = CalculateTotalPrices(productModel),
                Category = productModel.Category
            };
            return viewModel;
        }

        public List<ProductViewModel> GetProducts(int numberOfQuantity)
        {
            var products = _repo.GetProducts(numberOfQuantity);
            List<ProductViewModel> viewModels = new List<ProductViewModel>();
            foreach (var product in products)
            {
                viewModels.Add(new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    TotalPrice = CalculateTotalPrices(product)
                });
            }
            return viewModels;
        }
    }
}
