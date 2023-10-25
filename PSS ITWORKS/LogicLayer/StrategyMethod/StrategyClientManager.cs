// StrategyClientManager.cs
using PSS_ITWORKS.LogicLayer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyClientManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public BindingSource Get()
        {
            MessageBox.Show("Get something");
            return null;
        }

        public void Create(IEntity entity)
        {
            MessageBox.Show("Create something");
        }

        public void Delete(int ID)
        {
            MessageBox.Show("Delete something");
        }

        public void Update(IEntity entity)
        {
            MessageBox.Show("Update something");
        }

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public BindingSource Get(int ID)
        {
            return api.GetClientAndContractInfo(ID);
        }

        public BindingSource GetSpecific(int id1 )
        {
          
            return api.GetClientInfo(id1);
        }

        public BindingSource GetSpecific1(string s1)
        {
            throw new System.NotImplementedException();
        }

        public BindingSource GetSpecific2(string s2)
        {
            throw new System.NotImplementedException();
        }

        public BindingSource GetSpecific1(int id1)
        {
            return api.GetClientJobs(id1);
        }

        public BindingSource GetSpecific2(int n1)
        {
            throw new System.NotImplementedException();
        }
    }
}