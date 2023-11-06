// StrategyServiceManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StrategyServiceManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            EntityService service = entity as EntityService;
            api.InsertService(service);
        }

        public void Delete(int ID)
        {
            api.DeleteService(ID);
        }

        public List<IEntity> Get()
        {
            List<EntityService> services = api.GetServices();
            List<IEntity> entities = new List<IEntity>();
            foreach (EntityService service in services)
            {
                entities.Add(service);
            }
            return entities;
        }

        public IEntity Get(int ID)
        {
            EntityService sevice = api.GetService(ID);
            List<EntityContract> contracts = new List<EntityContract>();
            List<int> contractIds = api.GetContractRef(serviceId: ID);
            foreach (int contractId in contractIds)
            {
                contracts.Add(api.GetContract(contractId));
            }
            sevice.SetContracts(contracts);
            return sevice;
        }

        public void Update(IEntity entity)
        {
            EntityService service = entity as EntityService;
            api.UpdateService(service);
        }
    }
}