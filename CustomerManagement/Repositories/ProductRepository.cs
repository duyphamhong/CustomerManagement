using CustomerManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

            }

        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Product GetProduct(Guid id)
        {
            return _context.Products.Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts(int numberOfQuantity)
        {
            try
            {
                return _context.Products.Where(x=>x.Quantity >= numberOfQuantity).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
