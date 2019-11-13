using CustomerManagement.Data;
using CustomerManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {

                _context.Customers.Add(customer);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool DeleteCustomer(string id)
        {
            try
            {

                _context.Customers.Remove(_context.Customers.FirstOrDefault(c => c.Id == new Guid(id)));
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EditCustomer(Customer customer)
        {
            try
            {

                var customerEntity = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);

                customerEntity.Name = customer.Name;
                customerEntity.Age = customer.Age;

                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Customer GetCustomerById(string id)
        {
            try
            {

                var listCustomer = _context.Customers.Include(x => x.Orders).FirstOrDefault(x => x.Id == new Guid(id));
                return listCustomer;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Customer> GetCustomers()
        {
            try
            {

                var listCustomer = _context.Customers.ToList();
                return listCustomer;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public TeaOrder GetTeaOrder()
        {
            try
            {

                var order = _context.TeaOrders.FirstOrDefault();

                return order;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
