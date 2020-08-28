using System.Collections.Generic;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.InfrastructurePorts
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public Customer AddCustomer(Customer customer);

        public Customer UpdateCustomer(Customer customer);
    }
}
