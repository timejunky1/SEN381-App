using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContextManager
    {
        private readonly StrategyAManagement _strategy;

        public StrategyContextManager(StrategyAManagement strategy)
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
                    _strategy.Create(IEntity entity);
                    break;
                case "delete":
                    _strategy.Delete(int id);
                    break;
                case "update":
                    _strategy.Update(IEntity entity);
                    break;
                case "connect":
                    _strategy.Connect(string someString);
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

        
        //store private variables here and use methods here to add update delete etc

    }
}
