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
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            EntityCall call = entity as EntityCall;
            api.InsertCall(call);
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            api.DeleteCall(ID);
        }

        public List<IEntity> Get()
        {

            return api.GetCalls();
        }

        public IEntity Get(int ID)
        {
            EntityCall call = null;
            call = api.GetCalls(ID);
            return call;
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}