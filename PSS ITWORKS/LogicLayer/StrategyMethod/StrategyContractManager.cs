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
    class StrategyContractManager : IStrategyAManagement
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
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}