﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer.StrategyMethod
{
    internal class StratagyTechnician : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID, string s = "")
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
            return api.GetClientDetails(id1);
        }

        public BindingSource GetSpecific1(string s1)
        {
            return api.GetServiceOverview(s1);
        }

        public BindingSource GetSpecific1(int n1)
        {
            return api.GetTechnicianSchedule(n1);
        }

        public BindingSource GetSpecific2(string s2)
        {
            return api.GetClientOverview(s2);
        }

        public BindingSource GetSpecific2(int n1)
        {
            throw new NotImplementedException();
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
