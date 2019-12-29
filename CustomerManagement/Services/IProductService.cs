using CustomerManagement.Repositories;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public interface IProductService
    {
        void AddProduct(ProductViewModel product);

        List<ProductViewModel> GetAllProducts();

        double CalculateTotalPrices(Product product);
        ProductViewModel GetProduct(Guid id);
    }
}
