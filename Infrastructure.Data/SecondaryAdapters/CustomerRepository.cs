using System;
using System.Collections.Generic;
using System.ComponentModel;
using CustomerApp.Core.Entity;
using CustomerApp.Core.InfrastructurePorts;

namespace CustomerApp.Infrastructure.Data.SecondaryAdapters
{
    public class CustomerRepository: ICustomerRepository
    {
        private static int _id = 1;
        private static List<Customer> _customers = new List<Customer>();

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer AddCustomer(Customer customer)
        {
            customer.Id = _id++;
            _customers.Add(customer);
            return customer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            //Find i list og opdater
            return null;
        }
    }
}
