using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer.StrategyMethod
{
    internal class StratagyTechnician : IStrategyAManagement
    {
        DatabaseAPI api;
        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public BindingSource Get()
        {
            return null;
        }

        public BindingSource Get(int ID)
        {
            return api.GetTechnicianTaskList(ID);
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            return api.GetClientDetails();
        }

        public void Update(IEntity entity)
        {
            try
            {
                EntityJob job = entity as EntityJob;
                api.UpdateJobNotesAndStatus(job);
            }
            catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }
    }
}
