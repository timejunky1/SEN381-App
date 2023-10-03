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
                case "add":
                    _strategy.Add();
                    break;
                case "sort":
                    _strategy.Sort();
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
