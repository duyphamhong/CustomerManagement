using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using CustomerManagement.Repositories;

namespace CustomerManagement.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public bool AddCustomer(Customer customer)
        {
            return _repo.AddCustomer(customer);
        }

        public bool DeleteCustomer(string id)
        {
            return _repo.DeleteCustomer(id);
        }

        public bool EditCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(string Id)
        {
            return _repo.GetCustomerById(Id);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public TeaOrder GetTeaOrder()
        {
            return _repo.GetTeaOrder();
        }
    }
}
