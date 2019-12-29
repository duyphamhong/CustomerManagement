using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        List<Product> GetAllProducts();
        Product GetProduct(Guid id);
    }
}
