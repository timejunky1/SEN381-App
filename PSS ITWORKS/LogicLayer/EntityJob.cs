using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityJob : IEntity
    {
        public void Get()
        {
            throw new NotImplementedException();
        }

        public void Set()
        {
            throw new NotImplementedException();
        }

        private readonly int Id;
        private readonly int technicianId;
        private readonly int clientId;
        private readonly int serviceId;
        private readonly DateTime time_begin;
        private readonly DateTime time_end;
        private readonly string status;
        private readonly int callId;
    }
}
