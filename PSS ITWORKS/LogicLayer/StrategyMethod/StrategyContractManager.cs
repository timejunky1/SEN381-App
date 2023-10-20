// StrategyContractManager.cs
using PSS_ITWORKS.LogicLayer;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContractManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public BindingSource Get()
        {
            BindingSource bs = api.GetServices();
            return bs;
        }

        public void Create(IEntity entity)
        {
            EntityContract contract = entity as EntityContract;
            api.CreateContract( contract );
        }

        public void Delete(int ID)
        {
            api.DeleteContract(ID);
        }

        public void Update(IEntity entity)
        {
            EntityContract contract = entity as EntityContract;
            api.UpdateContract(contract);
        }

        public void Connect(string connString)
        {
            api.SetConnection(connString);
        }

        public void Get(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            api.GetContractStats(id1, id2);
        }
    }
}