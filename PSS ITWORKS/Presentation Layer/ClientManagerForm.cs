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
    public partial class ClientManagerForm : Form
    {
        
        StrategyContextManager clientManager;

        public ClientManagerForm()
        {
            InitializeComponent();
            // Set the Client Manager strategy 
            clientManager = new StrategyContextManager(new StrategyClientManager());
            clientManager.Connect(@"Data Source=JOEKNOWS\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
        }
       

        private void ClientManagerForm_Load(object sender, EventArgs e)
        {
            ClearDataGridViews();
            ClearInputs();
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(clientID_txt.Text);


            FindClientDetails(clientID);
            FindClientContract(clientID);
            FindClientJobs(clientID);


        }


        // Use methods to find the client in db
        
        private void FindClientDetails(int clientID)
        {
            // with strategy find the client in db
            // display in clientDetail_dgv datagridview
            clientDetail_dgv.DataSource = null;
            clientDetail_dgv.Rows.Clear();
            clientDetail_dgv.Refresh();
            clientDetail_dgv.DataSource = clientManager.GetSpecific(clientID);


        }

        // Use methods to find the client contracts
        private void FindClientContract(int clientID)
        {
            // with strategy find the client contract in db
            // Display in clientContract_dgv datagridview
            clientContract_dgv.DataSource = null;
            clientContract_dgv.Rows.Clear();
            clientContract_dgv.Refresh();
            clientContract_dgv.DataSource = clientManager.Get(clientID);

        }

        // Use methods to find the client jobs in 
        private void FindClientJobs(int clientID)
        {
            // with strategy find the client jobs in db
            // Display in clientJobs_dgv datagridview
            clientJobs_dgv.DataSource = null;
            clientJobs_dgv.Rows.Clear();
            clientJobs_dgv.Refresh();
            clientJobs_dgv.DataSource = clientManager.GetSpecific1(clientID) ;



        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // method to clear inputs
        private void ClearInputs()
        {
            clientID_txt.Text = "";
            clientID_txt.Focus();
            clientContactDetail_txt.Text = "";
            clientContract_txt.Text = "";
        }

        // method to clear datagridviews
        private void ClearDataGridViews()
        {
            clientDetail_dgv.DataSource = null;
            clientDetail_dgv.Rows.Clear();
            clientDetail_dgv.Refresh();

            clientContract_dgv.DataSource = null;
            clientContract_dgv.Rows.Clear();
            clientContract_dgv.Refresh();

            clientJobs_dgv.DataSource = null;
            clientJobs_dgv.Rows.Clear();
            clientJobs_dgv.Refresh();
        }


    }
}
