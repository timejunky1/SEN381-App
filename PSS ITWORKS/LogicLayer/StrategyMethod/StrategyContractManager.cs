// StrategyContractManager.cs
using PSS_ITWORKS.LogicLayer;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContractManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public void Get()
        {
           api.GetServices();
        }

        public void Create(IEntity entity)
        {
            EntityContract contract = entity as EntityContract;
            ErrorHandler.DisplayError($"{contract.GetId()}");
            api.CreateContract( contract );
        }

        public void Delete(int ID)
        {
            api.DeleteContract(ID);
        }

        public void Update(IEntity entity)
        {
            EntityContract contract = entity as EntityContract;
            ErrorHandler.DisplayError($"{contract.GetId()}");
            api.UpdateContract(contract);
        }

        public void Connect(string myString)
        {
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