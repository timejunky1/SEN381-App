// StrategyCCallManagement.cs
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.PSSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StrategyCallManagement : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            throw new NotImplementedException();
        }

        public void Create(IEntity entity)
        {
            api.InsertCall(entity as EntityCall);
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> Get()
        {
            api.GetCalls();
            throw new NotImplementedException();
        }

        public IEntity Get(int ID)
        {
            return api.GetCall(ID);
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}