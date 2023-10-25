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

        public void Delete(int ID, string s = "")
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

        public BindingSource GetSpecific1(string s1)
        {
            return _strategy.GetSpecific1(s1);
        }
        public BindingSource GetSpecific2(string s2)
        {
            return _strategy.GetSpecific2(s2);
        }
        public BindingSource GetSpecific1(int n1)
        {
            return _strategy.GetSpecific1(n1);
        }
        public BindingSource GetSpecific2(int n2)
        {
            return _strategy.GetSpecific1(n2);
        }
    }
}
