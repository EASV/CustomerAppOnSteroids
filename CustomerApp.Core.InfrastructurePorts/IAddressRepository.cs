using CustomerApp.Core.Entity;

namespace CustomerApp.Core.InfrastructurePorts
{
    public interface IAddressRepository
    {
        Address AddAddress(Address address);
    }
}