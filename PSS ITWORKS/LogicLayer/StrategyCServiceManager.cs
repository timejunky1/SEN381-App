using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyCServiceManager : StrategyAManagement
    {
        public override void Add()
        {
            MessageBox.Show("Add in ServiceManager");
        }

        public override void Sort()
        {
            MessageBox.Show("Sort in ServiceManager");
        }
        //Uses the context to implement the classes
    }
}
