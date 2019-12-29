using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;

namespace CustomerManagement.Repositories
{
    public interface IOrderRepository
    {
        void AddOrder(Order orderModel);
    }
}
