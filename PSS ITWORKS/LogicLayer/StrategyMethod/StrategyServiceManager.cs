﻿// StrategyServiceManager.cs
using PSS_ITWORKS.LogicLayer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyServiceManager : IStrategyAManagement
    {
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
    }
}