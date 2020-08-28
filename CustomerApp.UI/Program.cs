using System;
using CustomerApp.Core.InfrastructurePorts;
using CustomerApp.Core.PrimaryDriverAdapters.Services;
using CustomerApp.Core.PrimaryDriverPorts;
using CustomerApp.Infrastructure.Data;
using CustomerApp.Infrastructure.Data.SecondaryAdapters;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            var provider = services.BuildServiceProvider();
            var custRepo = provider.GetService<ICustomerRepository>();
            var dataInitializer = new DataInitializer(custRepo, null);
            dataInitializer.InitData();

            var custService = provider.GetService<ICustomerService>();
            var printer = new Printer(custService);
            printer.ListAllCustomers();
            printer.CreateCustomer();
           
            Console.WriteLine("After add");
            printer.ListAllCustomers();
            /*
                       ICustomerRepository customerRepository = new CustomerRepository();
                       ///if(development mode) {
                       /// }
                       ///
                       ///
                       
                       var dataInitializer = new DataInitializer(customerRepository, null);
                       dataInitializer.InitData();
                       //comment
                       var service = new CustomerService(customerRepository);
                       var printer = new Printer(service);
                       printer.ListAllCustomers();
           
                       printer.CreateCustomer();
           
                       Console.WriteLine("After add");
                       printer.ListAllCustomers();
                       
                       */
        }
    }
}
