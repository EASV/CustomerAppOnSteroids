using System;
using System.Collections.Generic;
using System.IO;
using CustomerApp.Core.Entity;
using CustomerApp.Core.InfrastructurePorts;
using CustomerApp.Core.PrimaryDriverPorts;

namespace CustomerApp.Core.PrimaryDriverAdapters.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = null,
            };
            _customerRepository = customerRepository;
        }

        public Customer CreateCustomer(string firstName, string lastName, DateTime birthDate)
        {
            
            
            if (firstName.Length < 2)
            {
                throw new InvalidDataException("Firstnme mys ldskfn");
            }
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };
            return _customerRepository.AddCustomer(customer);
        }

        public List<Customer> ReadAllCustomers()
        {
            return  _customerRepository.GetCustomers();
        }
    }
}
