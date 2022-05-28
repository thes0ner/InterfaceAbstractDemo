using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entity;

namespace InterfaceAbstractDemo.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            //client.TCKimlikNoDogrulaAsync();
            return true;
        }
    }
}
