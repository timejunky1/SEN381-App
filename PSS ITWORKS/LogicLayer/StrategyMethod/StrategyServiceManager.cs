﻿// StrategyServiceManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyServiceManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public BindingSource Get()
        {
            return api.GetServices();
        }

        public void Create(IEntity entity)
        {
            try
            {
                EntityService service = entity as EntityService;
                api.CreateService(service);
            }catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void Delete(int ID, string s = "")
        {
            api.DeleteService(ID);
        }

        public void Update(IEntity entity)
        {
            try
            {
                EntityService service = entity as EntityService;
                api.UpdateService(service);
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public BindingSource Get(int ID)
        {
            return api.GetService(ID);
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            throw new System.NotImplementedException();
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