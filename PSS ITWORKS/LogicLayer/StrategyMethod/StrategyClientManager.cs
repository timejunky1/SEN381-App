// StrategyClientManager.cs
using PSS_ITWORKS.LogicLayer;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StrategyClientManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            EntityClient client = entity as EntityClient;
            api.InsertClient(client);
        }

        public void Delete(int ID)
        {
            api.DeleteClient(ID);
        }

        public List<IEntity> Get()
        {
            List<IEntity> entities = new List<IEntity>();
            List<EntityClient> clients = api.GetClients();
            foreach (EntityClient client in clients)
            {
                List<EntityJob> jobs = api.GetJobs();
                List<EntityJob> clientJobs = api.GetJobs();
                foreach (EntityJob job in jobs)
                {
                    if(job.GetClientId() == client.GetID())
                    {
                        clientJobs.Add(job);
                    }
                }
                client.SetJobs(clientJobs); 
                entities.Add(client);
            }
            return entities;
        }

        public IEntity Get(int ID)
        {
            EntityClient client = null;
            if(client != null)
            {
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
            }
            return client;

        }

        public void Update(IEntity entity)
        {
            EntityClient client = entity as EntityClient;
            api.UpdateClient(client);
        }
    }
}