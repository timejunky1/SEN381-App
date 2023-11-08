using System.Collections.Generic;

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
            EntityClient client = null;
            client = api.GetClient(ID);

            List<EntityJob> jobs = api.GetJobs();
            List<EntityJob> clientJobs = new List<EntityJob>();

            foreach (EntityJob job in jobs)
            {
                if (job.GetClientId() == client.GetID())
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

            // Now, you can call the GetStatus method with the list of clientJobs
            string status = client.GetStatus(clientJobs);

            // You can use the 'status' variable as needed in your code

            return client;
        }


        public void Update(IEntity entity)
        {
            EntityClient client = entity as EntityClient;
            api.UpdateClient(client);
        }
    }
}
