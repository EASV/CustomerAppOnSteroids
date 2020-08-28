using System.Collections.Generic;
using CustomerApp.Core.Entity;
using CustomerApp.Core.InfrastructurePorts;

namespace CustomerApp.Infrastructure.Data.SecondaryAdapters
{
    public class CustomerMSSQLRepository: ICustomerRepository
    {
        public CustomerMSSQLRepository()
        {
            //connection SQL db
        }
        public List<Customer> GetCustomers()
        {
            //return conn.query(select * sdlkjnjkfds)
            return null;
        }

        public Customer AddCustomer(Customer customer)
        {
            //return conn.query(insert * sdlkjnjkfds)
            return null;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            // 
            return null;
        }
    }
}