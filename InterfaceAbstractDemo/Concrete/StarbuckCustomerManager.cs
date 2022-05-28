using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entity;

namespace InterfaceAbstractDemo.Concrete
{
    internal class StarbuckCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbuckCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
                base.Save(customer);
            else
                throw new Exception("Not a valid person.");
        }






    }
}
