

using PSS_ITWORKS.LogicLayer;

namespace PSS_ITWORKS
{
    public class StrategyCallManagement : IStrategyAManagement
    {

        public void Get()
        {
            // get something
            messageBox.Show("Get something");
        }

        public void Create(IEntity entity)
        {
            // create something
            messageBox.Show("Create something");
        }

        public void Delete(int ID)
        {
            // delete something
            messageBox.Show("Delete something");
        }

        public void Update(IEntity entity)
        {
            // update something
            messageBox.Show("Update something");
        }

        public void Connect(string myString)
        {
            // connect to something
            messageBox.Show("Connect to or soemthing");
        }
        //Uses the context to implement the classes
    }
}