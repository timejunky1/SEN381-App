using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class ServiceRequest
    {
        private intiger callEmpId;
        private intiger serviceEmpId;


        public ServiceRequest(intiger callEmpId, intiger serviceEmpId)
        {
            this.callEmpId = callEmpId;
            this.serviceEmpId = serviceEmpId;
        }
    }
}
