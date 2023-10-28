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

        private void ContractManagerForm_Load(object sender, EventArgs e)
        {
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            chart1.DataSource = 

        }

        private void ServiceType_lbl_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void UpdateService_btn_Click(object sender, EventArgs e)
        {

        }

        private void Months2_num_ValueChanged(object sender, EventArgs e)
        {
            int months = int.Parse(Months2_num.Value.ToString());
            done2_dgv.DataSource = context.GetSpecific(1,  months, "Finished");
            canceled2_dgv.DataSource = context.GetSpecific(1, months, "Finished");
        }
    }
}
