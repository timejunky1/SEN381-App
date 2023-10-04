using PSS_ITWORKS.LogicLayer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContextManager
    {
        private readonly IStrategyAManagement _strategy;
        private readonly IEntity entity;
        private readonly int id;
        private readonly string connectionString;

       
        
        public StrategyContextManager(IStrategyAManagement strategy)
        {
            _strategy = strategy;
        }


        public void ExecuteStrategy(string action)
        {
            switch (action.ToLower())
            {
                case "get":
                    _strategy.Get();
                    break;
                case "create":
                    _strategy.Create(entity);
                    break;
                case "delete":
                    _strategy.Delete(id);
                    break;
                case "update":
                    _strategy.Update(entity);
                    break;
                case "connect":
                    _strategy.Connect(connectionString);
                    break;
                default:
                    MessageBox.Show("No action");
                    break;

            }
        }



        void SetConnection(string conString)
        {
            // set connection
        }

        void SetEntity(string entity)
        {
            // set entity
        }
        void setId()
        {
            // set the id which will be used
        }

        //store private variables here and use methods here to add update delete etc

    }
}