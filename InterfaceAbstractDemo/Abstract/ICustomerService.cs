using InterfaceAbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {

        //Because we are going to save them in a same database we are not implementing interface to the Concrete objects.
        //We are going to create Abstract class because they are going to have same method logic....
        void Save(Customer customer);
    }
}
