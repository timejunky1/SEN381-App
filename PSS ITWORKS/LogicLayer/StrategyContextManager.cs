using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContextManager
    {
        private StrategyAManagement stratagy;
        public void ExecuteStrategy(string action)
        {
            switch (action.ToLower())
            {
                case "add":
                    stratagy.Add();
                    break;
                case "sort":
                    stratagy.Sort();
                    break;
                default:
                    MessageBox.Show("No action");
                    break;

            }
        }

        public void SetStratagy(StrategyAManagement strategy)
        {
            this.stratagy = strategy;
        }
        //store private variables here and use methods here to add update delete etc

    }
}
