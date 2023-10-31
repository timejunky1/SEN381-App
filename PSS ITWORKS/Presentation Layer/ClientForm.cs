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
        private Button newRequest_btn;
        private DataGridView liveChat_dgv;
        private Label liveChat_lbl;
        private DataGridView clientHistory_dgv;
        private Label history_lbl;
        private Label contractOverview_lbl;
        private TextBox experationDate_txt;
        private Label experationDate_lbl;
        private TextBox coverage_txt;
        private Label coverage_lbl;
        private TextBox contractType_txt;
        private Label contractType_lbl;
        private Button downloadTnC_btn;
        private Button renewOption_btn;
        private Label label3;
        private Button procedures_btn;
        private Label cost;
        private Button cost_btn;
        private Label renewal_lbl;
        private Button renewal_btn;
        private Label termsCon_lbl;
        private Label WelcomeClient_lbl;




        StrategyClientManager theClient;

        public ClientForm()
        {
            InitializeComponent();
            // Set the Client strategy
            theClient = new StrategyContextManager(new StrategyClient());
            theClient.Connect(@"Data Source=JOEKNOWS\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
        }

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
            this.label3 = new System.Windows.Forms.Label();
            this.procedures_btn = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.Label();
            this.cost_btn = new System.Windows.Forms.Button();
            this.renewal_lbl = new System.Windows.Forms.Label();
            this.renewal_btn = new System.Windows.Forms.Button();
            this.termsCon_lbl = new System.Windows.Forms.Label();
            this.downloadTnC_btn = new System.Windows.Forms.Button();
            this.renewOption_btn = new System.Windows.Forms.Button();
            this.experationDate_txt = new System.Windows.Forms.TextBox();
            this.experationDate_lbl = new System.Windows.Forms.Label();
            this.coverage_txt = new System.Windows.Forms.TextBox();
            this.coverage_lbl = new System.Windows.Forms.Label();
            this.contractType_txt = new System.Windows.Forms.TextBox();
            this.contractType_lbl = new System.Windows.Forms.Label();
            this.contractOverview_lbl = new System.Windows.Forms.Label();
            this.communication_tbp = new System.Windows.Forms.TabPage();
            this.liveChat_dgv = new System.Windows.Forms.DataGridView();
            this.liveChat_lbl = new System.Windows.Forms.Label();
            this.history_tbp = new System.Windows.Forms.TabPage();
            this.clientHistory_dgv = new System.Windows.Forms.DataGridView();
            this.history_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.ClientDashboard_tbc.SuspendLayout();
            this.Dashboard_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientMaintenanceOverview_dgv)).BeginInit();
            this.serviceRequest_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStatusFeedback_dgv)).BeginInit();
            this.contractInformation_tbp.SuspendLayout();
            this.communication_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liveChat_dgv)).BeginInit();
            this.history_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientHistory_dgv)).BeginInit();
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
            this.WelcomeClient_lbl.Size = new System.Drawing.Size(404, 41);
            this.WelcomeClient_lbl.TabIndex = 13;
            this.WelcomeClient_lbl.Text = "Welcome back  (Client name)";
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
            this.contractInformation_tbp.Controls.Add(this.label3);
            this.contractInformation_tbp.Controls.Add(this.procedures_btn);
            this.contractInformation_tbp.Controls.Add(this.cost);
            this.contractInformation_tbp.Controls.Add(this.cost_btn);
            this.contractInformation_tbp.Controls.Add(this.renewal_lbl);
            this.contractInformation_tbp.Controls.Add(this.renewal_btn);
            this.contractInformation_tbp.Controls.Add(this.termsCon_lbl);
            this.contractInformation_tbp.Controls.Add(this.downloadTnC_btn);
            this.contractInformation_tbp.Controls.Add(this.renewOption_btn);
            this.contractInformation_tbp.Controls.Add(this.experationDate_txt);
            this.contractInformation_tbp.Controls.Add(this.experationDate_lbl);
            this.contractInformation_tbp.Controls.Add(this.coverage_txt);
            this.contractInformation_tbp.Controls.Add(this.coverage_lbl);
            this.contractInformation_tbp.Controls.Add(this.contractType_txt);
            this.contractInformation_tbp.Controls.Add(this.contractType_lbl);
            this.contractInformation_tbp.Controls.Add(this.contractOverview_lbl);
            this.contractInformation_tbp.Location = new System.Drawing.Point(4, 34);
            this.contractInformation_tbp.Name = "contractInformation_tbp";
            this.contractInformation_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.contractInformation_tbp.Size = new System.Drawing.Size(1033, 376);
            this.contractInformation_tbp.TabIndex = 2;
            this.contractInformation_tbp.Text = "Contract Information";
            this.contractInformation_tbp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Terms and Conditions";
            // 
            // procedures_btn
            // 
            this.procedures_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.procedures_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.procedures_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.procedures_btn.FlatAppearance.BorderSize = 0;
            this.procedures_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procedures_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procedures_btn.Location = new System.Drawing.Point(570, 222);
            this.procedures_btn.Margin = new System.Windows.Forms.Padding(4);
            this.procedures_btn.Name = "procedures_btn";
            this.procedures_btn.Size = new System.Drawing.Size(208, 30);
            this.procedures_btn.TabIndex = 28;
            this.procedures_btn.Text = "Download";
            this.procedures_btn.UseVisualStyleBackColor = false;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(565, 123);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(53, 25);
            this.cost.TabIndex = 27;
            this.cost.Text = "Cost";
            // 
            // cost_btn
            // 
            this.cost_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.cost_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cost_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cost_btn.FlatAppearance.BorderSize = 0;
            this.cost_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cost_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_btn.Location = new System.Drawing.Point(570, 152);
            this.cost_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cost_btn.Name = "cost_btn";
            this.cost_btn.Size = new System.Drawing.Size(208, 30);
            this.cost_btn.TabIndex = 26;
            this.cost_btn.Text = "Download";
            this.cost_btn.UseVisualStyleBackColor = false;
            // 
            // renewal_lbl
            // 
            this.renewal_lbl.AutoSize = true;
            this.renewal_lbl.Location = new System.Drawing.Point(565, 56);
            this.renewal_lbl.Name = "renewal_lbl";
            this.renewal_lbl.Size = new System.Drawing.Size(160, 25);
            this.renewal_lbl.TabIndex = 25;
            this.renewal_lbl.Text = "Renewal Options";
            // 
            // renewal_btn
            // 
            this.renewal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.renewal_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.renewal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renewal_btn.FlatAppearance.BorderSize = 0;
            this.renewal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renewal_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewal_btn.Location = new System.Drawing.Point(570, 85);
            this.renewal_btn.Margin = new System.Windows.Forms.Padding(4);
            this.renewal_btn.Name = "renewal_btn";
            this.renewal_btn.Size = new System.Drawing.Size(208, 30);
            this.renewal_btn.TabIndex = 24;
            this.renewal_btn.Text = "Download";
            this.renewal_btn.UseVisualStyleBackColor = false;
            // 
            // termsCon_lbl
            // 
            this.termsCon_lbl.AutoSize = true;
            this.termsCon_lbl.Location = new System.Drawing.Point(24, 263);
            this.termsCon_lbl.Name = "termsCon_lbl";
            this.termsCon_lbl.Size = new System.Drawing.Size(204, 25);
            this.termsCon_lbl.TabIndex = 23;
            this.termsCon_lbl.Text = "Terms and Conditions";
            // 
            // downloadTnC_btn
            // 
            this.downloadTnC_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.downloadTnC_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.downloadTnC_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadTnC_btn.FlatAppearance.BorderSize = 0;
            this.downloadTnC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadTnC_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadTnC_btn.Location = new System.Drawing.Point(29, 292);
            this.downloadTnC_btn.Margin = new System.Windows.Forms.Padding(4);
            this.downloadTnC_btn.Name = "downloadTnC_btn";
            this.downloadTnC_btn.Size = new System.Drawing.Size(208, 30);
            this.downloadTnC_btn.TabIndex = 22;
            this.downloadTnC_btn.Text = "Download";
            this.downloadTnC_btn.UseVisualStyleBackColor = false;
            // 
            // renewOption_btn
            // 
            this.renewOption_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.renewOption_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.renewOption_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renewOption_btn.FlatAppearance.BorderSize = 0;
            this.renewOption_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renewOption_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewOption_btn.Location = new System.Drawing.Point(29, 337);
            this.renewOption_btn.Margin = new System.Windows.Forms.Padding(4);
            this.renewOption_btn.Name = "renewOption_btn";
            this.renewOption_btn.Size = new System.Drawing.Size(208, 30);
            this.renewOption_btn.TabIndex = 21;
            this.renewOption_btn.Text = "Renewal Options";
            this.renewOption_btn.UseVisualStyleBackColor = false;
            // 
            // experationDate_txt
            // 
            this.experationDate_txt.Location = new System.Drawing.Point(29, 221);
            this.experationDate_txt.Name = "experationDate_txt";
            this.experationDate_txt.Size = new System.Drawing.Size(208, 30);
            this.experationDate_txt.TabIndex = 8;
            // 
            // experationDate_lbl
            // 
            this.experationDate_lbl.AutoSize = true;
            this.experationDate_lbl.Location = new System.Drawing.Point(24, 193);
            this.experationDate_lbl.Name = "experationDate_lbl";
            this.experationDate_lbl.Size = new System.Drawing.Size(151, 25);
            this.experationDate_lbl.TabIndex = 7;
            this.experationDate_lbl.Text = "Experation Date";
            // 
            // coverage_txt
            // 
            this.coverage_txt.Location = new System.Drawing.Point(29, 151);
            this.coverage_txt.Name = "coverage_txt";
            this.coverage_txt.Size = new System.Drawing.Size(208, 30);
            this.coverage_txt.TabIndex = 6;
            // 
            // coverage_lbl
            // 
            this.coverage_lbl.AutoSize = true;
            this.coverage_lbl.Location = new System.Drawing.Point(24, 123);
            this.coverage_lbl.Name = "coverage_lbl";
            this.coverage_lbl.Size = new System.Drawing.Size(98, 25);
            this.coverage_lbl.TabIndex = 5;
            this.coverage_lbl.Text = "Coverage";
            // 
            // contractType_txt
            // 
            this.contractType_txt.Location = new System.Drawing.Point(29, 84);
            this.contractType_txt.Name = "contractType_txt";
            this.contractType_txt.Size = new System.Drawing.Size(208, 30);
            this.contractType_txt.TabIndex = 4;
            // 
            // contractType_lbl
            // 
            this.contractType_lbl.AutoSize = true;
            this.contractType_lbl.Location = new System.Drawing.Point(24, 56);
            this.contractType_lbl.Name = "contractType_lbl";
            this.contractType_lbl.Size = new System.Drawing.Size(136, 25);
            this.contractType_lbl.TabIndex = 3;
            this.contractType_lbl.Text = "Contract Type";
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
            this.communication_tbp.Controls.Add(this.liveChat_dgv);
            this.communication_tbp.Controls.Add(this.liveChat_lbl);
            this.communication_tbp.Location = new System.Drawing.Point(4, 34);
            this.communication_tbp.Name = "communication_tbp";
            this.communication_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.communication_tbp.Size = new System.Drawing.Size(1033, 376);
            this.communication_tbp.TabIndex = 3;
            this.communication_tbp.Text = "Communication";
            this.communication_tbp.UseVisualStyleBackColor = true;
            // 
            // liveChat_dgv
            // 
            this.liveChat_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liveChat_dgv.Location = new System.Drawing.Point(8, 67);
            this.liveChat_dgv.Name = "liveChat_dgv";
            this.liveChat_dgv.RowHeadersWidth = 51;
            this.liveChat_dgv.RowTemplate.Height = 24;
            this.liveChat_dgv.Size = new System.Drawing.Size(1018, 298);
            this.liveChat_dgv.TabIndex = 4;
            // 
            // liveChat_lbl
            // 
            this.liveChat_lbl.AutoSize = true;
            this.liveChat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveChat_lbl.Location = new System.Drawing.Point(4, 13);
            this.liveChat_lbl.Name = "liveChat_lbl";
            this.liveChat_lbl.Size = new System.Drawing.Size(134, 32);
            this.liveChat_lbl.TabIndex = 3;
            this.liveChat_lbl.Text = "Live Chat";
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
            ((System.ComponentModel.ISupportInitialize)(this.liveChat_dgv)).EndInit();
            this.history_tbp.ResumeLayout(false);
            this.history_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientHistory_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void newRequest_btn_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            //On Form load clear all outputs
            ClearDataGridViews();

            // populate the datagridviews
            MaintenanceOverview();
            ServiceRequest();
            ClientHistory();
            ContractDetails();
            LiveChat();


        }

        


        // Method for populating the Maintenacce overview
        private void MaintenanceOverview()
        {
            int id = 1;// temp id

            clientMaintenanceOverview_dgv.DataSource = null;
            clientMaintenanceOverview_dgv.Rows.Clear();
            clientMaintenanceOverview_dgv.Refresh();
            clientMaintenanceOverview_dgv.DataSource = theClient.GetSpecific1(id);



;        }

        // Method for populating the Service Request
        private void ServiceRequest()
        {
            int id = 1;// temp id

            serviceStatusFeedback_dgv.DataSource = null;
            serviceStatusFeedback_dgv.Rows.Clear();
            serviceStatusFeedback_dgv.Refresh();
            serviceStatusFeedback_dgv.DataSource = theClient.GetSpecific2(id);
        }

        // Method to get client Contract details
        private void ContractDetails()
        {
            int id = 1;// temp id


            BindingSource bsContract = theClient.Get(id);
            
            string contractID = bsContract[9].ToString();

            BindingSource bsDetailsContract = theClient.GetSpecific2(contractID);



            //int contract = int.Parse(contractValue);


            // populate the text boxes
            //contractType_txt.Text = bsContract[0].ToString();
            //coverage_txt.Text = bsContract[1].ToString();
            //experationDate_txt.Text = bsContract[2].ToString();


        }

        // Method to get client Communication 'Live chat'
        private void LiveChat()
        {
            // Not sure what we want to do here
        }

        // Method get Client jobs history
        private void ClientHistory()
        {
            int id = 1;// temp id

            clientHistory_dgv.DataSource = null;
            clientHistory_dgv.Rows.Clear();
            clientHistory_dgv.Refresh();
            clientHistory_dgv.DataSource = theClient.GetSpecific3(id);// replace with correct method for getting history
        }



        // method to clear inputs
        private void ClearInputs()
        {

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

            liveChat_dgv.DataSource = null;
            liveChat_dgv.Rows.Clear();
            liveChat_dgv.Refresh();

            clientHistory_dgv.DataSource = null;
            clientHistory_dgv.Rows.Clear();
            clientHistory_dgv.Refresh();
        }

        private void Dashboard_tbp_Click(object sender, EventArgs e)
        {

        }
    }
}
