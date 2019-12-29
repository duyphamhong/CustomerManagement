using CustomerManagement.Models;
using System;
using System.Collections.Generic;

namespace CustomerManagement.Repositories
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}