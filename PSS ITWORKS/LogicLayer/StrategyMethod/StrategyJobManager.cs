// StrategyJobManager.cs
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSS_ITWORKS
{
    class StrategyJobManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        SMSAPI sms = new SMSAPI();

        public void Connect(string myString)
        {
            throw new NotImplementedException();
        }

        public void Create(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> Get()
        {
            throw new NotImplementedException();
        }

        public IEntity Get(int ID)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}