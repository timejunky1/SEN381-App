using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class StrategyJobManager : IStrategyManagement
    {


        public void Get()
        {
            // get something
            messageBox.Show("Get something");
        }

        public void Create()
        {
            // create something
            messageBox.Show("Create something");
        }

        public void Delete(int ID)
        {
            // delete something
            messageBox.Show("Delete something");
        }

        public void Update()
        {
            // update something
            messageBox.Show("Update something");
        }

        public void Connect(string myString)
        {
            // connect to something
            messageBox.Show("Connect to or soemthing");
        }
    }
}
