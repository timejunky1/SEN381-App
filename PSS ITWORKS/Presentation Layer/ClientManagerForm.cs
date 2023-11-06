using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
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
            ValidateInputs();
            int clientID = Convert.ToInt32(clientID_txt.Text);

            FindClientDetails(clientID);
            FindClientContract(clientID);
            FindClientJobs(clientID);
        }


        // Use methods to find the client in db
        private void FindClientDetails(int clientID)
        {
            // with strategy find the client in db. Display in clientDetail_dgv datagridview
            clientDetail_dgv.DataSource = null;
            clientDetail_dgv.Rows.Clear();
            clientDetail_dgv.Refresh();
            


            // find the client in the list of entities by their clientId and the display that client's details in data grid view
            List<IEntity> entities = clientManager.Get();
            foreach (EntityClient client in entities)
            {
                if (client.GetID() == clientID)
                {
                    // brake the client details in the entity into pieces and display them in the data grid view
                    clientDetail_dgv.ColumnCount = 12;
                    clientDetail_dgv.Columns[0].HeaderText = "Client ID";
                    clientDetail_dgv.Columns[1].HeaderText = "Company Name";
                    clientDetail_dgv.Columns[2].HeaderText = "Name";
                    clientDetail_dgv.Columns[3].HeaderText = "Surname";
                    clientDetail_dgv.Columns[4].HeaderText = "Role";
                    clientDetail_dgv.Columns[5].HeaderText = "Contract ID";
                    clientDetail_dgv.Columns[6].HeaderText = "Phone";
                    clientDetail_dgv.Columns[7].HeaderText = "Email";
                    clientDetail_dgv.Columns[8].HeaderText = "Contract Initiation Date";
                    clientDetail_dgv.Columns[9].HeaderText = "Street Number";
                    clientDetail_dgv.Columns[10].HeaderText = "Street Name";
                    clientDetail_dgv.Columns[11].HeaderText = "City";
                    clientDetail_dgv.Columns[12].HeaderText = "Province";
                    clientDetail_dgv.Columns[13].HeaderText = "Zip Code";

                    // add the client details to the data grid view
                    clientDetail_dgv.Rows.Add(client.GetID(), client.GetCompanyName(), client.GetName(), 
                                              client.GetSurname(), client.GetRole(), client.GetContractId(), 
                                              client.GetPhone(), client.GetEmail(), client.GetContractInitiationDate(), 
                                              client.GetStreetNumber(), client.GetStreetName(), client.GetCity(), 
                                              client.GetProvince(), client.GetZipCode());
  
                }
                else
                {
                    MessageBox.Show("Client not found");
                }
            }
        }


        // Use methods to find the client contracts
        private void FindClientContract(int clientID)
        {
            // with strategy find the client contract in. Display in clientContract_dgv datagridview
            clientContract_dgv.DataSource = null;
            clientContract_dgv.Rows.Clear();
            clientContract_dgv.Refresh();
            

            //change strategy to strategycontractmanager
            StrategyContextManager contractManager = new StrategyContextManager(new StrategyContractManager());
            contractManager.Connect(@"Data Source=JOEKNOWS\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");

            // find the client contract in the list of entities by their clientId and the display that client's contract in data grid view
            List<IEntity> entities = contractManager.Get();
            foreach (EntityContract contract in entities)
            {
                if (contract.Get() == clientID)
                {
                    // brake the client contract in the entity into pieces and display them in the data grid view
                    clientContract_dgv.ColumnCount = 5;
                    clientContract_dgv.Columns[0].HeaderText = "Contract ID";
                    clientContract_dgv.Columns[1].HeaderText = "Client ID";
                    clientContract_dgv.Columns[2].HeaderText = "Contract Initiation Date";
                    clientContract_dgv.Columns[3].HeaderText = "Contract Expiration Date";
                    clientContract_dgv.Columns[4].HeaderText = "Contract Type";

                    // add the client contract to the data grid view
                    clientContract_dgv.Rows.Add(contract.GetContractId(), contract.GetClientId(), contract.GetContractInitiationDate(),
                                                contract.GetContractExpirationDate(), contract.GetContractType());
                }
                else
                {
                    MessageBox.Show("Client contract not found");
                }
            }


            // Change strategy back to strategyclientmanager
            clientManager = new StrategyContextManager(new StrategyClientManager());
            clientManager.Connect(@"Data Source=JOEKNOWS\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");

        }


        // Use methods to find the client jobs in 
        private void FindClientJobs(int clientID)
        {
            // with strategy find the client jobs in db. Display in clientJobs_dgv datagridview
            clientJobs_dgv.DataSource = null;
            clientJobs_dgv.Rows.Clear();
            clientJobs_dgv.Refresh();
            //clientJobs_dgv.DataSource = clientManager.GetSpecific1(clientID) ;

            // Get the client jobs and then display that client's jobs in data grid view
            List<IEntity> entities = clientManager.Get();
            foreach (EntityClient client in entities)
            {
                if (client.GetID() == clientID)
                {
                    // brake the client jobs in the entity into pieces and display them in the data grid view
                    clientJobs_dgv.ColumnCount = 8;
                    clientJobs_dgv.Columns[0].HeaderText = "Job ID";
                    clientJobs_dgv.Columns[1].HeaderText = "Client ID";
                    clientJobs_dgv.Columns[2].HeaderText = "Job Type";
                    clientJobs_dgv.Columns[3].HeaderText = "Job Description";
                    clientJobs_dgv.Columns[4].HeaderText = "Job Status";
                    clientJobs_dgv.Columns[5].HeaderText = "Job Initiation Date";
                    clientJobs_dgv.Columns[6].HeaderText = "Job Completion Date";
                    clientJobs_dgv.Columns[7].HeaderText = "Job Technician ID";

                    // add the client jobs to the data grid view
                    //clientJobs_dgv.Rows.Add();
                }
                else
                {
                    MessageBox.Show("Client jobs not found");
                }
            }

        }


        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }


        // method to validate user inputs
        private bool ValidateInputs()
        {
            if (clientID_txt.Text == "")
            {
                MessageBox.Show("Please enter a client ID");
                clientID_txt.Focus();
                return false;
            }
            else
            {
                return true;
            }

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
