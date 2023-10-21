// StrategyContractManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContractManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public BindingSource Get()
        {
            return null;
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
            try
            {
                EntityContract contract = entity as EntityContract;
                api.UpdateContract(contract);
            }catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void Connect(string connString)
        {
            api.SetConnection(connString);
        }

        public BindingSource Get(int ID)
        {
            return api.GetClientAndContractInfo(ID);
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            return api.GetContractStats(id1, id2);
        }
    }
}