using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

namespace PSS_ITWORKS.LogicLayer.StrategyMethod
{
    public  class StrategyClient : IStrategyAManagement
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
                entities.Add(client);
            }
            return entities;
        }

        public IEntity Get(int ID)
        {
            EntityClient client = api.GetClient(ID);
            if(client != null)
            {
                List<EntityJob> jobs = api.GetJobs();
                List<EntityJob> clientJobs = new List<EntityJob>();
                foreach(EntityJob job in jobs)
                {
                    if(job.GetClientId() == client.GetID())
                    {
                        clientJobs.Add(job);
                    }
                }
                client.SetJobs(clientJobs);
                List<EntityCall> calls = api.GetCalls();
                List<EntityCall> clientCalls = new List<EntityCall>();
                foreach (EntityCall call in calls)
                {
                    if (call.GetClientId() == client.GetID())
                    {
                        clientCalls.Add(call);
                    }
                }
                client.SetCalls(clientCalls);
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
