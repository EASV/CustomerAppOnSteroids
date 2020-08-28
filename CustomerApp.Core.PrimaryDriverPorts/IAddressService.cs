using CustomerApp.Core.Entity;

namespace CustomerApp.Core.PrimaryDriverPorts
{
    public interface IAddressService
    {
        public Address CreateAddress(Address address);
    }
}