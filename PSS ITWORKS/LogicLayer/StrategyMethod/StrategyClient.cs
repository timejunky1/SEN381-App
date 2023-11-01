using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer.StrategyMethod
{
    internal class StrategyClient : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            throw new NotImplementedException();
        }

        public void Create(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> Get()
        {
            throw new NotImplementedException();
        }

        public IEntity Get(int ID)
        {
            EntityClient client = null;
            client = api.GetClient(ID);
            List<EntityJob> jobs= api.GetJobs();
            foreach(EntityJob job in jobs)
            {
                if(job.GetClientId() == client.GetID())
                {
                    jobs.Add(job);
                }
            }
            client.SetJobs(jobs);
            List<EntityCall> calls = api.GetCalls();
            foreach (EntityCall call in calls)
            {
                if (call.GetClientId() == client.GetID())
                {
                    calls.Add(call);
                }
            }
            client.SetCalls(calls);
            return client;

        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
