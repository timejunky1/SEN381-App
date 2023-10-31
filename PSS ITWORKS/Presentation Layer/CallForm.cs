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
    public partial class CallForm : Form
    {
        DatabaseAPI data = new DatabaseAPI();
        public CallForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void CallForm_Load(object sender, EventArgs e)
        {
            string[] message = PSS_lbl.Text.Split(' ');
            string name = message[2];
            Dashboard_dgv.DataSource = data.GetJobsAssignedToEmployeeName(name);

            ///display data in data grid view according to to active tabs
            if (CallEmployee_tc.SelectedTab == CallEmployee_tc.TabPages["Dashboard_tp"])
            {
                Dashboard_dgv.DataSource = data.GetJobsAssignedToEmployeeName(name);
            }
            else if (CallEmployee_tc.SelectedTab == CallEmployee_tc.TabPages["ServiceRequest_tp"])
            {
                PastRequests_dgv.DataSource = data.GetJobsAssignedToEmployeeName(name);
            }
        }
        ///Call form, History tab search
        private void Search_btn_Click(object sender, EventArgs e)
        {
            string clientName = SearchClientName_txt.Text;
            int clientId = int.Parse(clientName);
            PastServiceRequest_dgv.DataSource = data.GetClientOverview(clientId);
        }

        private void SearchClient_btn_Click(object sender, EventArgs e)
        {
            string name = SearchClientName_txt.Text;
            string number = ClientNumber_txt.Text;

            if (number == null && name != null)
            {
                ///search according to name
            }
            else if (number != null && name == null)
            {
                ///search according to number
            }
            else
            {
                MessageBox.Show("Please enter a Client's name or number to search")
            }
        }
    }
}
