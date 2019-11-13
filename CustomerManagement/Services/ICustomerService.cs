using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(string Id);
        bool EditCustomer(Customer customer);
        bool AddCustomer(Customer customer);
        bool DeleteCustomer(string id);

        TeaOrder GetTeaOrder();
    }
}
