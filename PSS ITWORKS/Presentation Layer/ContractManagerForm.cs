using PSS_ITWORKS.LogicLayer;
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
    public partial class ContractManagerForm : Form
    {
        StrategyContextManager context;
        public ContractManagerForm()
        {
            InitializeComponent();
            context = new StrategyContextManager(new StrategyContractManager());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.Update(new EntityContract(1,"ewqw",2,2,2,"unavailable"));
            dataGridView1.DataSource = context.Get();
        }

        private void ContractManagerForm_Load(object sender, EventArgs e)
        {
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
        }

        private void ServiceType_lbl_Click(object sender, EventArgs e)
        {
            Visible = true;
        }
    }
}
