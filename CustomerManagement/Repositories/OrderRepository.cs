using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Data;
using CustomerManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddOrder(Order orderModel)
        {
            using (var dbTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Orders.Add(orderModel);
                    _context.SaveChanges();
                    dbTransaction.Commit();
                }
                catch(Exception e)
                {
                    dbTransaction.Rollback();
                }
            }
        }
    }
}
