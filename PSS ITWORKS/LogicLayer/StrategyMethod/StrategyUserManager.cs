﻿// StrategyUserManager.cs
using PSS_ITWORKS.LogicLayer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyUserManager : IStrategyAManagement
    {
        DatabaseAPI api;
        public void Get()
        {
            MessageBox.Show("Get something");
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
            MessageBox.Show("Connect to or something");
        }

        public void Get(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            throw new System.NotImplementedException();
        }
    }
}