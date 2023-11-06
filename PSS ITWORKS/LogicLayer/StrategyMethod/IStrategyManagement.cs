// IStrategyAManagement.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public interface IStrategyAManagement
    {
        List<IEntity> Get();
        IEntity Get(int ID);
        void Create(IEntity entity);
        void Delete(int ID);
        void Update(IEntity entity);
        void Connect(string myString);
    }
}