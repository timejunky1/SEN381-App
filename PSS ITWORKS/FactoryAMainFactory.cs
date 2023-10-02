using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS
{
    public abstract class FactoryAMainFactory
    {
        protected abstract FactoryIUser CreateIUser();

        public FactoryIUser UserDetails()

        {

          return this.CreateIUser();


        }

        //This uses the interface to show the details of a specific user
    }
}

