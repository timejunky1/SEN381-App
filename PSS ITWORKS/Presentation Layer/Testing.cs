using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.LogicLayer.StrategyMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class Testing : Form
    {
        DatabaseAPI api = new DatabaseAPI();
        public Testing()
        {
            InitializeComponent();
            

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            api.SetConnection("Data Source=DESKTOP-8GCK8IN\\SQLEXPRESS;Initial Catalog=PSS1;Integrated Security=True");
            Test_dgv.DataSource = api.GetEmployees();
        }
    }
}
