using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityCall : IEntity
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
        private readonly string eUsername;
        private readonly int clientId;
        private readonly DateTime time;
        private readonly string service;
        private readonly string clientDescription;
    }
}
