using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS
{
    class FactoryCManagerFactory : FactoryAMainFactory
    {
        protected override FactoryIUser CreateIUser()
        {
            FactoryIUser _Details = new FactoryCManagerDetails();
            return _Details;
        }
    }
}
