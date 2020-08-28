using System;
using CustomerApp.Core.InfrastructurePorts;
using CustomerApp.Core.PrimaryDriverAdapters.Services;
using CustomerApp.Infrastructure.Data;
using CustomerApp.Infrastructure.Data.SecondaryAdapters;

namespace CustomerApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            ///if(development mode) {
            /// }
            ///
            ///
            
            var dataInitializer = new DataInitializer(customerRepository, null);
            dataInitializer.InitData();
            
            var service = new CustomerService(customerRepository);
            var printer = new Printer(service);
            printer.ListAllCustomers();

            printer.CreateCustomer();

            Console.WriteLine("After add");
            printer.ListAllCustomers();
        }
    }
}
