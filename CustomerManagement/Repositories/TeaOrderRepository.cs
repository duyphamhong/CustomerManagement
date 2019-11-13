using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Data;
using CustomerManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Repositories
{
    public class TeaOrderRepository : ITeaOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public TeaOrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddOrder(TeaOrder order)
        {
            _context.TeaOrders.Add(order);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteOrder(string id)
        {
            throw new NotImplementedException();
        }

        public bool EditOrder(TeaOrder customer)
        {
            throw new NotImplementedException();
        }

        public TeaOrder GetOrderById(string Id)
        {
            throw new NotImplementedException();
        }

        public List<TeaOrder> GetOrders()
        {
            return _context.TeaOrders.Include(t => t.Customer).ToList();
        }
    }
}
