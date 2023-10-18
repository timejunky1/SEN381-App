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

        public void Get()
        {
            _strategy.Get();
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

        public void Get(int ID, string s1 = "", string s2 = "")
        {
            _strategy.Get(ID, s1, s2);
        }
    }
}
