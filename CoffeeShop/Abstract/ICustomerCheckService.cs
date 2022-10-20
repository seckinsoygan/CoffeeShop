using CoffeeShop.Entities;

namespace CoffeeShop.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
