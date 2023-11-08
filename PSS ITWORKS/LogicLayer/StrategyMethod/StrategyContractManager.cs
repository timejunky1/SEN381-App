// StrategyContractManager.cs
using Microsoft.SqlServer.Server;
using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StrategyContractManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            EntityContract contract = entity as EntityContract;
            api.InsertContract(contract);
            foreach(EntityService service in contract.GetServices())
            {
                api.InsertContractRef(contract.GetId(), service.GetId());
            }

        }

        public void Delete(int ID)
        {
            api.DeleteContract(ID);
        }

        public List<IEntity> Get()
        {
            List<EntityContract> conracts = api.GetContracts();
            List<IEntity> entities = new List<IEntity>();
            foreach(EntityContract contract in conracts)
            {
                entities.Add(contract);
            }
            return entities;
        }

        public IEntity Get(int ID)
        {
            EntityContract contract = api.GetContract(ID);
            List<int> serviceids = api.GetContractRef(contract.GetId());
            List<EntityService> services = new List<EntityService>();
            foreach(int i in serviceids)
            {
                services.Add(api.GetService(i));
            }
            List<EntityClient> clients = api.GetClients();
            List<EntityClient> contractClients = new List<EntityClient>();
            foreach(EntityClient client in clients)
            {
                contractClients.Add(client);
            }
            contract.SetServices(services);
            contract.SetClients(contractClients);
            return contract;
        }

        public void Update(IEntity entity)
        {
            EntityContract contract = entity as EntityContract;
            api.DeleteContractRef(contractId: contract.GetId());
            foreach(EntityService service in contract.GetServices())
            {
                api.InsertContractRef(contract.GetId(), service.GetId());
            }
            api.UpdateContract(contract);
        }

        public BindingSource GetSpecific1(string s1)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific2(string s2)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific1(int n1)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific2(int n1)
        {
            throw new NotImplementedException();
        }
    }
}