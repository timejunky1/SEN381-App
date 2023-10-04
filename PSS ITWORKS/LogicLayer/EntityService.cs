using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityService : IEntity
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
        private readonly float cost;
        private readonly float duration;
        private readonly int priority;
        private readonly string description;
    }
}
