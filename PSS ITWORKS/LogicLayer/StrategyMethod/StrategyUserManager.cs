﻿// StrategyUserManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyUserManager : IStrategyAManagement
    {
        DatabaseAPI api;
        public BindingSource Get()
        {
            return api.ViewAllUsers();
        }

        public void Create(IEntity entity)
        {
            try
            {
                EntityUser user = entity as EntityUser;
                api.InsertUser(user);
            }catch(Exception ex)
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
            try
            {
                EntityUser user = entity as EntityUser;
                api.UpdateUser(user);
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
            throw new System.NotImplementedException();
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            return api.FilterUsers(s1);
        }
    }
}