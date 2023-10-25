// StrategyCCallManagement.cs
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.PSSDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StrategyCallManagement : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public BindingSource Get()
        {
            MessageBox.Show("Get something");
            return null;
        }

        public void Create(IEntity entity)
        {
            try
            {
                EntityJob job = entity as EntityJob;
                api.CreateServiceRequest(job);
            }
            catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
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
            return api.GetEmployeeOverview(ID);
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            return api.GetClientOverview(id1);
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