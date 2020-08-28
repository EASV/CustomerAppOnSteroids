using System.Collections.Generic;
using CustomerApp.Core.Entity;
using CustomerApp.Core.InfrastructurePorts;

namespace CustomerApp.Infrastructure.Data
{
    public class DataInitializer
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IAddressRepository _addressRepo;

        public DataInitializer(ICustomerRepository customerRepository,
            IAddressRepository addressRepository)
        {
            _customerRepo = customerRepository;
            _addressRepo = addressRepository;
        }

        public void InitData()
        {
            /*var address = new Address()
            {
                StreetName = "smurf"
            };
           address = _addressRepo.AddAddress(address);
*/
            
            var customer1 = new Customer
            {
                FirstName = "John",
                LastName = "Billson",
                /*Address = new List<Address>()
                {
                    address
                }*/
            };
            _customerRepo.AddCustomer(customer1);
            var customer2 = new Customer
            {
                FirstName = "Johnny",
                LastName = "Billsony"
            };
            _customerRepo.AddCustomer(customer2);
        }
    }
}