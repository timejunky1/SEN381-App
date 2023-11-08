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
using static LoginController;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ClientForm : Form
    {
        private Button Logout_btn;
        private PictureBox Logo_img;
        private TabControl ClientDashboard_tbc;
        private TabPage Dashboard_tbp;
        private TabPage serviceRequest_tbp;
        private TabPage contractInformation_tbp;
        private TabPage communication_tbp;
        private TabPage history_tbp;
        private DataGridView clientMaintenanceOverview_dgv;
        private Label maintenaceInfo_lbl;
        private Label maintenace_lbl;
        private Label serviceRequests_lbl;
        private DataGridView serviceStatusFeedback_dgv;
        private Label statusFeedback_lbl;
        private DataGridView callHistory_dgv;
        private Label callHistory_lbl;
        private DataGridView clientHistory_dgv;
        private Label history_lbl;
        private Label contractOverview_lbl;
        private Label WelcomeClient_lbl;
        private Button newRequest_btn;
        private DataGridView contract_dgv;
        StrategyContextManager theClient;

        public ClientForm()
        {
            InitializeComponent();
            // Set the Client strategy
            theClient = new StrategyContextManager(new StrategyClient());
            theClient.Connect(@"Data Source=JOEKNOWS\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
        }


        private void newRequest_btn_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            //NewServiceRequest().Show();
            


        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // temp id replace with loged in client details
            int id = 1;

            // On Form load clear all outputs
            ClearDataGridViews();

            // populate the datagridviews with details of current client

            // MaintenanceOverview
            FindClientJobs(id);

            //Service requests
            ServiceRequest(id);

            // Contract ddetails
            FindClientContract(id);

            // Call history
            FindClientCalls(id);

            // Client history
            ClientHistory(id);


        }

        

        // Method for populating the Service Request
        private void ServiceRequest(int clientID)
        {
            
            serviceStatusFeedback_dgv.DataSource = null;
            serviceStatusFeedback_dgv.ColumnCount = 5;
            serviceStatusFeedback_dgv.Columns[0].HeaderText = "Job ID";
            serviceStatusFeedback_dgv.Columns[1].HeaderText = "Client ID";
            serviceStatusFeedback_dgv.Columns[2].HeaderText = "Job Priority";
            serviceStatusFeedback_dgv.Columns[3].HeaderText = "Job Status";
            serviceStatusFeedback_dgv.Columns[4].HeaderText = "Job Initiation Date";



            // Get the client jobs and then display that client's jobs in data grid view
            List<IEntity> entities = theClient.Get();
            foreach (EntityJob  entity in entities)
            {
                if (entity.GetClientId() == clientID && entity.GetStatus() == "Pending")
                {

                    serviceStatusFeedback_dgv.Rows.Clear();
                    serviceStatusFeedback_dgv.Rows.Add(entity.GetID(), entity.GetClientId(), entity.GetPriotity(), 
                                                       entity.GetStatus(), entity.GetTimeBegin());
                    

                }
                else
                {
                    MessageBox.Show("Client jobs not found");
                }
            }


        }


        // Method get Client jobs history
        private void ClientHistory(int clientID)
        {

            clientHistory_dgv.DataSource = null;
            clientHistory_dgv.ColumnCount = 5;
            clientHistory_dgv.Columns[0].HeaderText = "Job ID";
            clientHistory_dgv.Columns[1].HeaderText = "Client ID";
            clientHistory_dgv.Columns[2].HeaderText = "Job Priority";
            clientHistory_dgv.Columns[3].HeaderText = "Job Status";
            clientHistory_dgv.Columns[4].HeaderText = "Job Initiation Date";

            // Get the client jobs and then display that client's jobs in data grid view
            List<IEntity> entities = theClient.Get();
            foreach (EntityJob entity in entities)
            {
                if (entity.GetClientId() == clientID && entity.GetStatus() == "Finished")
                {

                    clientHistory_dgv.Rows.Clear();
                    clientHistory_dgv.Rows.Add(entity.GetID(), entity.GetClientId(), entity.GetPriotity(),
                                                       entity.GetStatus(), entity.GetTimeBegin());


                }
                else
                {
                    MessageBox.Show("Client jobs not found");
                }
            }
        }


        // method to clear datagridviews
        private void ClearDataGridViews()
        {
            clientMaintenanceOverview_dgv.DataSource = null;
            clientMaintenanceOverview_dgv.Rows.Clear();
            clientMaintenanceOverview_dgv.Refresh();

            serviceStatusFeedback_dgv.DataSource = null;
            serviceStatusFeedback_dgv.Rows.Clear();
            serviceStatusFeedback_dgv.Refresh();

            contract_dgv.DataSource = null;
            contract_dgv.Rows.Clear();
            contract_dgv.Refresh();

            callHistory_dgv.DataSource = null;
            callHistory_dgv.Rows.Clear();
            callHistory_dgv.Refresh();

            clientHistory_dgv.DataSource = null;
            clientHistory_dgv.Rows.Clear();
            clientHistory_dgv.Refresh();
        }

        private void Dashboard_tbp_Click(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {

            this.Close();

            LogIn loginForm = new LogIn();
            loginForm.Show();
        }

        private void liveChat_lbl_Click(object sender, EventArgs e)
        {

        }


        // Use methods to find the client contracts
        private void FindClientContract(int clientID)
        {
            
            //change strategy to strategycontractmanager
            StrategyContextManager contractManager = new StrategyContextManager(new StrategyContractManager());
            contractManager.Connect(@"Data Source=JOEKNOWS\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");

            // Clear dgv and add headings
            contract_dgv.DataSource = null;
            contract_dgv.ColumnCount = 5;
            contract_dgv.Columns[0].HeaderText = "Contract ID";
            contract_dgv.Columns[1].HeaderText = "Client ID";
            contract_dgv.Columns[2].HeaderText = "Contract Initiation Date";
            contract_dgv.Columns[3].HeaderText = "Contract Expiration Date";
            contract_dgv.Columns[4].HeaderText = "Contract Type";

            // find the client contract in the list of entities by their clientId and then display 
            List<IEntity> contracts = contractManager.Get();
            foreach (EntityContract contract in contracts)
            {

                // add the contract to the data grid view
                contract_dgv.Rows.Add(contract.GetId(), contract.GetClients(), contract.GetStartTime(),
                        CalculateEndDate(contract.GetStartTime(), contract.GetDuration()), contract.GetType());



            }


            // Change strategy back to strategyclientmanager
            theClient = new StrategyContextManager(new StrategyClient());
            theClient.Connect(@"Data Source=JOEKNOWS\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");

        }

        // Use methods to find the client jobs 
        private void FindClientJobs(int clientID)
        {

            clientMaintenanceOverview_dgv.DataSource = null;
            clientMaintenanceOverview_dgv.ColumnCount = 8;
            clientMaintenanceOverview_dgv.Columns[0].HeaderText = "Job ID";
            clientMaintenanceOverview_dgv.Columns[1].HeaderText = "Client ID";
            clientMaintenanceOverview_dgv.Columns[2].HeaderText = "Job Type";
            clientMaintenanceOverview_dgv.Columns[3].HeaderText = "Job Description";
            clientMaintenanceOverview_dgv.Columns[4].HeaderText = "Job Status";
            clientMaintenanceOverview_dgv.Columns[5].HeaderText = "Job Initiation Date";
            clientMaintenanceOverview_dgv.Columns[6].HeaderText = "Job Completion Date";
            clientMaintenanceOverview_dgv.Columns[7].HeaderText = "Job Technician ID";


            // Get the client jobs and then display that client's jobs in data grid view
            List<IEntity> jobs = theClient.Get();
            foreach (EntityClient job in jobs)
            {
                if (job.GetID() == clientID)
                {
                    // add the client jobs to the data grid view
                    clientMaintenanceOverview_dgv.DataSource = job.GetJobs();

                }
                else
                {
                    MessageBox.Show("Client jobs not found");
                }
            }

        }

        // method to get clients calls
        private void FindClientCalls(int clientID)
        {

            callHistory_dgv.DataSource = null;
            callHistory_dgv.Rows.Clear();
            callHistory_dgv.Refresh();

            // Get the client and their associated calls using the StrategyClient
            IEntity client = theClient.Get(clientID);

            if (client != null)
            {
                // Check if the retrieved entity is of type EntityClient
                if (client is EntityClient entityClient)
                {
                    // Populate the DataGridView with the client's calls
                    callHistory_dgv.DataSource = entityClient.GetCalls();
                }
                else
                {
                    MessageBox.Show("Client entity is not of the expected type (EntityClient).");
                }
            }
            else
            {
                MessageBox.Show("Client not found");
            }
        }

        // method used to calculate the end date of contract 
        private DateTime CalculateEndDate(DateTime startDate, int duration)
        {
            DateTime endDate = startDate.AddMonths(duration);
            return endDate;
        }
    }
}
