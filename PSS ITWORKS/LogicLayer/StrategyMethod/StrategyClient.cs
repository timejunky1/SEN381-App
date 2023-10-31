﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer.StrategyMethod
{
    internal class StrategyClient : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public void Connect(string myString)
        {
            api.SetConnection(myString);
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
            throw new NotImplementedException();
        }

        public BindingSource Get()
        {
            throw new NotImplementedException();
        }

        public BindingSource Get(int ID)
        {
            BindingSource bs = api.GetClientWithDetails(ID);
            return bs;
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific1(string s1)
        {
            throw new NotImplementedException();
        }

        // Get client overview
        public BindingSource GetSpecific1(int n1)
        {
            return api.GetClientOverview(n1);
        }


        // Get contract details wit contract id
        public BindingSource GetSpecific2(string s2)
        {
            int id = Convert.ToInt32(s2);
            return api.GetContracts(id);
            
        }

        // Get client Service requests
        public BindingSource GetSpecific2(int n1)
        {
            // return api.get
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
