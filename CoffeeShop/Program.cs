using CoffeeShop.Abstract;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;

BaseCustomerManager customerManager = new NeroCustomerManager();
customerManager.Save(new Customer
{
    DateofBirth = new DateTime(1998, 20, 04),
    FirstName = "Seckin",
    LastName = "Soygan",
    NationalityId = "24132135412"
});
