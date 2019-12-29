using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.ViewModels;

namespace CustomerManagement.Services
{
    public interface IOrderService
    {
        void Add(OrderViewModel order);
    }
}
