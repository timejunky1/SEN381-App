// StrategyClientManager.cs
using PSS_ITWORKS.LogicLayer;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyClientManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            throw new System.NotImplementedException();
        }

        public void Create(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int ID, string s = "")
        {
            throw new System.NotImplementedException();
        }

        public List<IEntity> Get()
        {
            throw new System.NotImplementedException();
        }

        public IEntity Get(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}