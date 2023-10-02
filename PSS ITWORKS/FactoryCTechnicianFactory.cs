using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS
{
    class FactoryCTechnicianFactory :FactoryAMainFactory
    {
        protected override FactoryIUser CreateIUser()
        {
            FactoryIUser _Details = new FactoryCTechnicianDetails();
            return _Details;
        }
    }
}
