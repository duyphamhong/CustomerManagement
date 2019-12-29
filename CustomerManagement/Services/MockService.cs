using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public static class MockService
    {
        public static List<Customer> Customers = new List<Customer>();

        public static List<Customer> AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            return Customers;
        }

        public static List<Customer> GetCustomers()
        {
            return Customers;
        }

        public static Customer GetCustomerById(Guid id)
        {
            return Customers.FirstOrDefault(c=>c.Id == id);
        }

    }
}
