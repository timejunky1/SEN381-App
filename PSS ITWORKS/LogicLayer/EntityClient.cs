using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityClient : IEntity
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
        private readonly string clientName;
        private readonly string address;
        private readonly string contactDetails;
        private readonly string clientRole;
        private readonly int contract;

    }
}
