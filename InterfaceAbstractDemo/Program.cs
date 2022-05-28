using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entity;
using InterfaceAbstractDemo.Concrete;



namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbuckCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer() {DateOfBirth = new DateTime(2000,01,21),Id = 1, FirstName = "Soner", LastName = "Abduramanov", NationalityId = "8786543"});
        
        
        }
    }
}
