using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityContract : IEntity
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
        private List<string> Services = new List<string>();
        private readonly string sla;
        private readonly float duration;
        private readonly int priority;
        

        
    }
}
