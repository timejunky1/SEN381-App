// StrategyContextManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public class StrategyContextManager
    {
        private readonly IStrategyAManagement _strategy;
        private readonly int id;
        private readonly string connectionString;

        public StrategyContextManager(IStrategyAManagement strategy)
        {
            _strategy = strategy;
        }

        public BindingSource Get()
        {
            BindingSource bs = _strategy.Get();
            return bs;
        }

        public void Create(IEntity entity)
        {
            _strategy.Create(entity);
        }

        public void Delete(int ID)
        {
            _strategy.Delete(ID);
        }

        public void Update(IEntity entity)
        {

            _strategy.Update(entity);
        }

        public void Connect(string myString)
        {
            _strategy.Connect(myString);
        }

        public BindingSource Get(int id)
        {
            BindingSource bs = _strategy.Get(id);
            return bs;
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            BindingSource bs = _strategy.GetSpecific(id1, id2, s1, s2);
            return bs;
        }
    }
}
