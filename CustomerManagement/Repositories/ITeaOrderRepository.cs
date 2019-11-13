using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories
{
    public interface ITeaOrderRepository
    {
        List<TeaOrder> GetOrders();
        TeaOrder GetOrderById(string Id);
        bool EditOrder(TeaOrder order);
        bool AddOrder(TeaOrder order);
        bool DeleteOrder(string id);
        List<Tea> GetTeas();
    }
}
