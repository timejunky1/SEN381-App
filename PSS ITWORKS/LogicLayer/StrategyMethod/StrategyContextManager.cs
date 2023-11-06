// StrategyContextManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StrategyContextManager
    {
        private readonly IStrategyAManagement _strategy;
        private readonly int id;
        private readonly string connectionString;

        public StrategyContextManager(IStrategyAManagement _strategy)
        {
            this._strategy = _strategy;
        }
        public void Connect(string myString)
        {
            _strategy.Connect(myString);
        }

        public void Create(IEntity entity)
        {
            _strategy.Create(entity);
        }

        public void Delete(int id)
        {
            _strategy.Delete(id);
        }

        public List<IEntity> Get()
        {
            return _strategy.Get();
        }

        public IEntity Get(int ID)
        {
            return _strategy.Get(ID);
        }

        public void Update(IEntity entity)
        {
            _strategy.Update(entity);
        }
    }
}
