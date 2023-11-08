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

        // DONT REMOVE THIS
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.WelcomeClient_lbl = new System.Windows.Forms.Label();
            this.ClientDashboard_tbc = new System.Windows.Forms.TabControl();
            this.Dashboard_tbp = new System.Windows.Forms.TabPage();
            this.clientMaintenanceOverview_dgv = new System.Windows.Forms.DataGridView();
            this.maintenaceInfo_lbl = new System.Windows.Forms.Label();
            this.maintenace_lbl = new System.Windows.Forms.Label();
            this.serviceRequest_tbp = new System.Windows.Forms.TabPage();
            this.serviceStatusFeedback_dgv = new System.Windows.Forms.DataGridView();
            this.statusFeedback_lbl = new System.Windows.Forms.Label();
            this.newRequest_btn = new System.Windows.Forms.Button();
            this.serviceRequests_lbl = new System.Windows.Forms.Label();
            this.contractInformation_tbp = new System.Windows.Forms.TabPage();
            this.contractOverview_lbl = new System.Windows.Forms.Label();
            this.communication_tbp = new System.Windows.Forms.TabPage();
            this.callHistory_dgv = new System.Windows.Forms.DataGridView();
            this.callHistory_lbl = new System.Windows.Forms.Label();
            this.history_tbp = new System.Windows.Forms.TabPage();
            this.clientHistory_dgv = new System.Windows.Forms.DataGridView();
            this.history_lbl = new System.Windows.Forms.Label();
            this.contract_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.ClientDashboard_tbc.SuspendLayout();
            this.Dashboard_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientMaintenanceOverview_dgv)).BeginInit();
            this.serviceRequest_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStatusFeedback_dgv)).BeginInit();
            this.contractInformation_tbp.SuspendLayout();
            this.communication_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callHistory_dgv)).BeginInit();
            this.history_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientHistory_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(874, 26);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(180, 44);
            this.Logout_btn.TabIndex = 15;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo_img.BackgroundImage")));
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(13, 13);
            this.Logo_img.Margin = new System.Windows.Forms.Padding(4);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(101, 75);
            this.Logo_img.TabIndex = 14;
            this.Logo_img.TabStop = false;
            // 
            // WelcomeClient_lbl
            // 
            this.WelcomeClient_lbl.AutoSize = true;
            this.WelcomeClient_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeClient_lbl.ForeColor = System.Drawing.Color.Black;
            this.WelcomeClient_lbl.Location = new System.Drawing.Point(122, 25);
            this.WelcomeClient_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeClient_lbl.Name = "WelcomeClient_lbl";
            this.WelcomeClient_lbl.Size = new System.Drawing.Size(228, 41);
            this.WelcomeClient_lbl.TabIndex = 13;
            this.WelcomeClient_lbl.Text = "Welcome back  ";
            // 
            // ClientDashboard_tbc
            // 
            this.ClientDashboard_tbc.Controls.Add(this.Dashboard_tbp);
            this.ClientDashboard_tbc.Controls.Add(this.serviceRequest_tbp);
            this.ClientDashboard_tbc.Controls.Add(this.contractInformation_tbp);
            this.ClientDashboard_tbc.Controls.Add(this.communication_tbp);
            this.ClientDashboard_tbc.Controls.Add(this.history_tbp);
            this.ClientDashboard_tbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientDashboard_tbc.Location = new System.Drawing.Point(13, 128);
            this.ClientDashboard_tbc.Name = "ClientDashboard_tbc";
            this.ClientDashboard_tbc.SelectedIndex = 0;
            this.ClientDashboard_tbc.Size = new System.Drawing.Size(1041, 414);
            this.ClientDashboard_tbc.TabIndex = 16;
            // 
            // Dashboard_tbp
            // 
            this.Dashboard_tbp.Controls.Add(this.clientMaintenanceOverview_dgv);
            this.Dashboard_tbp.Controls.Add(this.maintenaceInfo_lbl);
            this.Dashboard_tbp.Controls.Add(this.maintenace_lbl);
            this.Dashboard_tbp.Location = new System.Drawing.Point(4, 34);
            this.Dashboard_tbp.Name = "Dashboard_tbp";
            this.Dashboard_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard_tbp.Size = new System.Drawing.Size(1033, 376);
            this.Dashboard_tbp.TabIndex = 0;
            this.Dashboard_tbp.Text = "Dashboard";
            this.Dashboard_tbp.UseVisualStyleBackColor = true;
            this.Dashboard_tbp.Click += new System.EventHandler(this.Dashboard_tbp_Click);
            // 
            // clientMaintenanceOverview_dgv
            // 
            this.clientMaintenanceOverview_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientMaintenanceOverview_dgv.Location = new System.Drawing.Point(9, 88);
            this.clientMaintenanceOverview_dgv.Name = "clientMaintenanceOverview_dgv";
            this.clientMaintenanceOverview_dgv.RowHeadersWidth = 51;
            this.clientMaintenanceOverview_dgv.RowTemplate.Height = 24;
            this.clientMaintenanceOverview_dgv.Size = new System.Drawing.Size(1018, 273);
            this.clientMaintenanceOverview_dgv.TabIndex = 2;
            // 
            // maintenaceInfo_lbl
            // 
            this.maintenaceInfo_lbl.AutoSize = true;
            this.maintenaceInfo_lbl.Location = new System.Drawing.Point(8, 48);
            this.maintenaceInfo_lbl.Name = "maintenaceInfo_lbl";
            this.maintenaceInfo_lbl.Size = new System.Drawing.Size(495, 25);
            this.maintenaceInfo_lbl.TabIndex = 1;
            this.maintenaceInfo_lbl.Text = "Ongoing Tasks, Service Requests, and Contract Details";
            // 
            // maintenace_lbl
            // 
            this.maintenace_lbl.AutoSize = true;
            this.maintenace_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenace_lbl.Location = new System.Drawing.Point(3, 10);
            this.maintenace_lbl.Name = "maintenace_lbl";
            this.maintenace_lbl.Size = new System.Drawing.Size(303, 32);
            this.maintenace_lbl.TabIndex = 0;
            this.maintenace_lbl.Text = "Maintenance Overview";
            // 
            // serviceRequest_tbp
            // 
            this.serviceRequest_tbp.Controls.Add(this.serviceStatusFeedback_dgv);
            this.serviceRequest_tbp.Controls.Add(this.statusFeedback_lbl);
            this.serviceRequest_tbp.Controls.Add(this.newRequest_btn);
            this.serviceRequest_tbp.Controls.Add(this.serviceRequests_lbl);
            this.serviceRequest_tbp.Location = new System.Drawing.Point(4, 34);
            this.serviceRequest_tbp.Name = "serviceRequest_tbp";
            this.serviceRequest_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.serviceRequest_tbp.Size = new System.Drawing.Size(1033, 376);
            this.serviceRequest_tbp.TabIndex = 1;
            this.serviceRequest_tbp.Text = "Service Request";
            this.serviceRequest_tbp.UseVisualStyleBackColor = true;
            // 
            // serviceStatusFeedback_dgv
            // 
            this.serviceStatusFeedback_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceStatusFeedback_dgv.Location = new System.Drawing.Point(9, 152);
            this.serviceStatusFeedback_dgv.Name = "serviceStatusFeedback_dgv";
            this.serviceStatusFeedback_dgv.RowHeadersWidth = 51;
            this.serviceStatusFeedback_dgv.RowTemplate.Height = 24;
            this.serviceStatusFeedback_dgv.Size = new System.Drawing.Size(1015, 218);
            this.serviceStatusFeedback_dgv.TabIndex = 23;
            // 
            // statusFeedback_lbl
            // 
            this.statusFeedback_lbl.AutoSize = true;
            this.statusFeedback_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusFeedback_lbl.Location = new System.Drawing.Point(6, 107);
            this.statusFeedback_lbl.Name = "statusFeedback_lbl";
            this.statusFeedback_lbl.Size = new System.Drawing.Size(472, 32);
            this.statusFeedback_lbl.TabIndex = 22;
            this.statusFeedback_lbl.Text = "Service request status and feedback";
            // 
            // newRequest_btn
            // 
            this.newRequest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.newRequest_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newRequest_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRequest_btn.FlatAppearance.BorderSize = 0;
            this.newRequest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRequest_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRequest_btn.Location = new System.Drawing.Point(9, 46);
            this.newRequest_btn.Margin = new System.Windows.Forms.Padding(4);
            this.newRequest_btn.Name = "newRequest_btn";
            this.newRequest_btn.Size = new System.Drawing.Size(235, 44);
            this.newRequest_btn.TabIndex = 21;
            this.newRequest_btn.Text = "New Request";
            this.newRequest_btn.UseVisualStyleBackColor = false;
            this.newRequest_btn.Click += new System.EventHandler(this.newRequest_btn_Click);
            // 
            // serviceRequests_lbl
            // 
            this.serviceRequests_lbl.AutoSize = true;
            this.serviceRequests_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceRequests_lbl.Location = new System.Drawing.Point(3, 10);
            this.serviceRequests_lbl.Name = "serviceRequests_lbl";
            this.serviceRequests_lbl.Size = new System.Drawing.Size(236, 32);
            this.serviceRequests_lbl.TabIndex = 1;
            this.serviceRequests_lbl.Text = "Service Requests";
            // 
            // contractInformation_tbp
            // 
            this.contractInformation_tbp.Controls.Add(this.contract_dgv);
            this.contractInformation_tbp.Controls.Add(this.contractOverview_lbl);
            this.contractInformation_tbp.Location = new System.Drawing.Point(4, 34);
            this.contractInformation_tbp.Name = "contractInformation_tbp";
            this.contractInformation_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.contractInformation_tbp.Size = new System.Drawing.Size(1033, 376);
            this.contractInformation_tbp.TabIndex = 2;
            this.contractInformation_tbp.Text = "Contract Information";
            this.contractInformation_tbp.UseVisualStyleBackColor = true;
            // 
            // contractOverview_lbl
            // 
            this.contractOverview_lbl.AutoSize = true;
            this.contractOverview_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractOverview_lbl.Location = new System.Drawing.Point(3, 10);
            this.contractOverview_lbl.Name = "contractOverview_lbl";
            this.contractOverview_lbl.Size = new System.Drawing.Size(341, 32);
            this.contractOverview_lbl.TabIndex = 2;
            this.contractOverview_lbl.Text = "Contract Details Overview";
            // 
            // communication_tbp
            // 
            this.communication_tbp.Controls.Add(this.callHistory_dgv);
            this.communication_tbp.Controls.Add(this.callHistory_lbl);
            this.communication_tbp.Location = new System.Drawing.Point(4, 34);
            this.communication_tbp.Name = "communication_tbp";
            this.communication_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.communication_tbp.Size = new System.Drawing.Size(1033, 376);
            this.communication_tbp.TabIndex = 3;
            this.communication_tbp.Text = "Communication";
            this.communication_tbp.UseVisualStyleBackColor = true;
            // 
            // callHistory_dgv
            // 
            this.callHistory_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callHistory_dgv.Location = new System.Drawing.Point(8, 67);
            this.callHistory_dgv.Name = "callHistory_dgv";
            this.callHistory_dgv.RowHeadersWidth = 51;
            this.callHistory_dgv.RowTemplate.Height = 24;
            this.callHistory_dgv.Size = new System.Drawing.Size(1018, 298);
            this.callHistory_dgv.TabIndex = 4;
            // 
            // callHistory_lbl
            // 
            this.callHistory_lbl.AutoSize = true;
            this.callHistory_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callHistory_lbl.Location = new System.Drawing.Point(4, 13);
            this.callHistory_lbl.Name = "callHistory_lbl";
            this.callHistory_lbl.Size = new System.Drawing.Size(159, 32);
            this.callHistory_lbl.TabIndex = 3;
            this.callHistory_lbl.Text = "Call History";
            this.callHistory_lbl.Click += new System.EventHandler(this.liveChat_lbl_Click);
            // 
            // history_tbp
            // 
            this.history_tbp.Controls.Add(this.clientHistory_dgv);
            this.history_tbp.Controls.Add(this.history_lbl);
            this.history_tbp.Location = new System.Drawing.Point(4, 34);
            this.history_tbp.Name = "history_tbp";
            this.history_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.history_tbp.Size = new System.Drawing.Size(1033, 376);
            this.history_tbp.TabIndex = 4;
            this.history_tbp.Text = "History";
            this.history_tbp.UseVisualStyleBackColor = true;
            // 
            // clientHistory_dgv
            // 
            this.clientHistory_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientHistory_dgv.Location = new System.Drawing.Point(7, 69);
            this.clientHistory_dgv.Name = "clientHistory_dgv";
            this.clientHistory_dgv.RowHeadersWidth = 51;
            this.clientHistory_dgv.RowTemplate.Height = 24;
            this.clientHistory_dgv.Size = new System.Drawing.Size(1018, 298);
            this.clientHistory_dgv.TabIndex = 5;
            // 
            // history_lbl
            // 
            this.history_lbl.AutoSize = true;
            this.history_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_lbl.Location = new System.Drawing.Point(4, 13);
            this.history_lbl.Name = "history_lbl";
            this.history_lbl.Size = new System.Drawing.Size(755, 32);
            this.history_lbl.TabIndex = 3;
            this.history_lbl.Text = "Past service requests, maintenance activities, and invoices";
            // 
            // contract_dgv
            // 
            this.contract_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contract_dgv.Location = new System.Drawing.Point(7, 59);
            this.contract_dgv.Name = "contract_dgv";
            this.contract_dgv.RowHeadersWidth = 51;
            this.contract_dgv.RowTemplate.Height = 24;
            this.contract_dgv.Size = new System.Drawing.Size(1018, 310);
            this.contract_dgv.TabIndex = 3;
            // 
            // ClientForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ClientDashboard_tbc);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Logo_img);
            this.Controls.Add(this.WelcomeClient_lbl);
            this.Name = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.ClientDashboard_tbc.ResumeLayout(false);
            this.Dashboard_tbp.ResumeLayout(false);
            this.Dashboard_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientMaintenanceOverview_dgv)).EndInit();
            this.serviceRequest_tbp.ResumeLayout(false);
            this.serviceRequest_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStatusFeedback_dgv)).EndInit();
            this.contractInformation_tbp.ResumeLayout(false);
            this.contractInformation_tbp.PerformLayout();
            this.communication_tbp.ResumeLayout(false);
            this.communication_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callHistory_dgv)).EndInit();
            this.history_tbp.ResumeLayout(false);
            this.history_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientHistory_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
