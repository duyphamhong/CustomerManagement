using CustomerManagement.Models;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public interface ITeaOrderService
    {
        List<TeaOrderViewModel> GetOrders();
        TeaOrder GetOrderById(string Id);
        bool EditOrder(TeaOrder customer);
        bool AddOrder(TeaOrderViewModel customer);
        bool DeleteOrder(string id);
        List<Tea> GetTeas();
    }
}
