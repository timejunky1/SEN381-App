// StrategyUserManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyUserManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
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

        public void Delete(int ID, string s = "")
        {
            api.DeleteUser(ID, s);
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