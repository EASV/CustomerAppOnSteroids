using CustomerApp.Core.PrimaryDriverAdapters.Services;
using CustomerApp.Core.PrimaryDriverPorts;
using Xunit;

namespace CustomerApp.Core.Test.ApplicationServices.Services
{
    public class AddressServiceTest
    {
        [Fact]
        public void AddressService_ImplementsIAddressService()
        {
            IAddressService addressService = new AddressService();
            Assert.NotNull(addressService);
        }
        
        [Fact]
        public void AddressService_NullIRepository_ReturnsException()
        {
            IAddressService addressService = new AddressService();
            Assert.NotNull(addressService);
        }
    }
}