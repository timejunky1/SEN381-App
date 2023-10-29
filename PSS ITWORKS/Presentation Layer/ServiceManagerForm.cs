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
    public partial class ServiceManagerForm : Form
    {
        private Dashboard dashboard;
        StrategyContextManager cm;
        AssignmentForm af = new AssignmentForm();
        public ServiceManagerForm(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            cm = new StrategyContextManager(new StrategyJobManager());
            cm.Connect(@"Data Source=DESKTOP-TBBSO02\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            Request_dgv.DataSource = cm.GetSpecific();
            AssignmentSchedule_dgv.DataSource = cm.Get();
        }

        private void Filter_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void assign_btn_Click(object sender, EventArgs e)
        {
            af.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();

        }
    }
}
