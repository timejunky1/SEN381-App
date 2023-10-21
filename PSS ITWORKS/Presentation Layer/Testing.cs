using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.LogicLayer.StrategyMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            StrategyContextManager context = new StrategyContextManager(new StrategyClient());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            //dataGridView1.DataSource =  context.Get(10);
            context.Create(new EntityJob(10,5,"Some Notes"));
        }
    }
}
