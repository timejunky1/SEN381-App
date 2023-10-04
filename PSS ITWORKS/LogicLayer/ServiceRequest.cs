using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class ServiceRequest
    {
        private int callEmpId;
        private int serviceEmpId;


        public ServiceRequest(int callEmpId, int serviceEmpId)
        {
            this.callEmpId = callEmpId;
            this.serviceEmpId = serviceEmpId;
        }
    }
}
