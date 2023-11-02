using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSS_ITWORKS.Presentation_Layer;
using System.Data.SqlClient;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class CallForm : Form
    {
        StrategyCallManagement callManagement;
        BindingSource bs;
        SqlConnection con;

        void getContractInfo()
        {
            ///// Coverage_txt.Text = I dont know what the coverage represents
            int durationInMonths = int.Parse(ContractOverview_dgv.SelectedRows[0].Cells[3].Value.ToString());
            ContractDuration_txt.Text = durationInMonths.ToString();
            DateTime date = DateTime.Parse(ContractOverview_dgv.SelectedRows[0].Cells[7].Value.ToString());
            DateTime experationDate = date.AddMonths(durationInMonths);
            ExperationDate_txt.Text = experationDate.ToString();

        }
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
            int empID = 2;////EmpId is hardcoded, will be changed when login details is modified to get employee name and ID

            ///display data in data grid view according to to active tabs
            if (CallEmployee_tc.SelectedTab == CallEmployee_tc.TabPages["Dashboard_tp"])
            {
                //dt = data.GetJobsAssignedToEmployeeName(name);
                Dashboard_dgv.DataSource = callManagement.Get(empID);
            }
            else if (CallEmployee_tc.SelectedTab == CallEmployee_tc.TabPages["ServiceRequest_tp"])
            {
                PastRequests_dgv.DataSource = callManagement.Get(empID);
            }
        }
        ///Call form, History tab search
        private void Search_btn_Click(object sender, EventArgs e)
        {
            string clientName = SearchClientName_txt.Text;
            if (clientName == null)
            {
                MessageBox.Show("Please enter the client's name to search");
            }
            else 
            {
            }
            
        }

        private void SearchClient_btn_Click(object sender, EventArgs e)
        {
            string name = SearchClientName_txt.Text;
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
 
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT c.*, cl.contract_initiation_date FROM contract JOIN client cl ON c.contract_id = cl.contract_id WHERE cl.name = @client_name;");
            cmd.Parameters.AddWithValue("@@client_name", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            ContractOverview_dgv.DataSource = ds;
            getContractInfo();
                
        }

        private void NewServiceRequest_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceRequestForm form = new ServiceRequestForm();
            form.Show();
        }
    }
}
