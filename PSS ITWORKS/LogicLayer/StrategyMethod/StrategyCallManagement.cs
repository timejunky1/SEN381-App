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
            EntityCall call = new EntityCall();
            foreach (var item in entity)
            {

            }

            api.InsertCall(entity);
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            api.DeleteCall(ID);
        }

        public List<IEntity> Get()
        {
            List<EntityCall> calls = null;
            calls = api.GetCalls();
            return calls;
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