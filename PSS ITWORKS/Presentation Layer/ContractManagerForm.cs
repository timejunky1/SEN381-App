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
        private Dashboard dashboard;
        StrategyContextManager context;
        public ContractManagerForm(Dashboard dashboard)
        {
            InitializeComponent();
            context = new StrategyContextManager(new StrategyContractManager());
            this.dashboard = dashboard;
        }

        private void ContractManagerForm_Load(object sender, EventArgs e)
        {
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
        }

        private void ServiceType_lbl_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();

        }
    }
}
