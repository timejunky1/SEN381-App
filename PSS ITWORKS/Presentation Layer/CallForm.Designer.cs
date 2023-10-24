namespace PSS_ITWORKS.Presentation_Layer
{
    partial class CallForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header_pnl = new System.Windows.Forms.Panel();
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.CallEmployee_tbc = new System.Windows.Forms.TabControl();
            this.Dashboard_tbp = new System.Windows.Forms.TabPage();
            this.ServiceRequest_tbp = new System.Windows.Forms.TabPage();
            this.Client_tbp = new System.Windows.Forms.TabPage();
            this.History_tbp = new System.Windows.Forms.TabPage();
            this.MaintananceOverview_lbl = new System.Windows.Forms.Label();
            this.PastJobRequest_lbl = new System.Windows.Forms.Label();
            this.Dashboard_dgv = new System.Windows.Forms.DataGridView();
            this.ServiceRequest_lbl = new System.Windows.Forms.Label();
            this.NewServiceRequest_btn = new System.Windows.Forms.Button();
            this.PastRequests_lbl = new System.Windows.Forms.Label();
            this.PastRequests_dgv = new System.Windows.Forms.DataGridView();
            this.SearchClient_lbl = new System.Windows.Forms.Label();
            this.ClientName_lbl = new System.Windows.Forms.Label();
            this.ClientName_txt = new System.Windows.Forms.TextBox();
            this.ClientNumber_txt = new System.Windows.Forms.TextBox();
            this.ClientNumber_lbl = new System.Windows.Forms.Label();
            this.SearchClient_btn = new System.Windows.Forms.Button();
            this.ContractDetailsOverview_gbx = new System.Windows.Forms.GroupBox();
            this.ContractType_lbl = new System.Windows.Forms.Label();
            this.ContractType_txt = new System.Windows.Forms.TextBox();
            this.Coverage_txt = new System.Windows.Forms.TextBox();
            this.Coverage_lbl = new System.Windows.Forms.Label();
            this.ExperationDate_txt = new System.Windows.Forms.TextBox();
            this.ExperationDate_lbl = new System.Windows.Forms.Label();
            this.RenewalOptions_lbl = new System.Windows.Forms.Label();
            this.RenewalOptionView_btn = new System.Windows.Forms.Button();
            this.RenewalOptionsDownload_btn = new System.Windows.Forms.Button();
            this.CostDownload_btn = new System.Windows.Forms.Button();
            this.CostView_btn = new System.Windows.Forms.Button();
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.ProcedureDownload_btn = new System.Windows.Forms.Button();
            this.ProcedureView_btn = new System.Windows.Forms.Button();
            this.Procedure_lbl = new System.Windows.Forms.Label();
            this.PastServiceRequest_lbl = new System.Windows.Forms.Label();
            this.PastServiceRequest_dgv = new System.Windows.Forms.DataGridView();
            this.ClientNameOrNumber_lbl = new System.Windows.Forms.Label();
            this.ClientNameOrNumber_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.CallEmployee_tbc.SuspendLayout();
            this.Dashboard_tbp.SuspendLayout();
            this.ServiceRequest_tbp.SuspendLayout();
            this.Client_tbp.SuspendLayout();
            this.History_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastRequests_dgv)).BeginInit();
            this.ContractDetailsOverview_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastServiceRequest_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_pnl
            // 
            this.Header_pnl.AutoSize = true;
            this.Header_pnl.Controls.Add(this.Logout_btn);
            this.Header_pnl.Controls.Add(this.PSS_lbl);
            this.Header_pnl.Controls.Add(this.PSS_img);
            this.Header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(1067, 89);
            this.Header_pnl.TabIndex = 0;
            // 
            // PSS_img
            // 
            this.PSS_img.Location = new System.Drawing.Point(16, 11);
            this.PSS_img.Name = "PSS_img";
            this.PSS_img.Size = new System.Drawing.Size(101, 75);
            this.PSS_img.TabIndex = 0;
            this.PSS_img.TabStop = false;
            // 
            // PSS_lbl
            // 
            this.PSS_lbl.AutoSize = true;
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.PSS_lbl.Location = new System.Drawing.Point(125, 23);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(276, 50);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back";
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(938, 23);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(102, 50);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // CallEmployee_tbc
            // 
            this.CallEmployee_tbc.Controls.Add(this.Dashboard_tbp);
            this.CallEmployee_tbc.Controls.Add(this.ServiceRequest_tbp);
            this.CallEmployee_tbc.Controls.Add(this.Client_tbp);
            this.CallEmployee_tbc.Controls.Add(this.History_tbp);
            this.CallEmployee_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CallEmployee_tbc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallEmployee_tbc.Location = new System.Drawing.Point(0, 89);
            this.CallEmployee_tbc.Name = "CallEmployee_tbc";
            this.CallEmployee_tbc.SelectedIndex = 0;
            this.CallEmployee_tbc.Size = new System.Drawing.Size(1067, 465);
            this.CallEmployee_tbc.TabIndex = 1;
            // 
            // Dashboard_tbp
            // 
            this.Dashboard_tbp.Controls.Add(this.Dashboard_dgv);
            this.Dashboard_tbp.Controls.Add(this.PastJobRequest_lbl);
            this.Dashboard_tbp.Controls.Add(this.MaintananceOverview_lbl);
            this.Dashboard_tbp.Location = new System.Drawing.Point(4, 34);
            this.Dashboard_tbp.Name = "Dashboard_tbp";
            this.Dashboard_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard_tbp.Size = new System.Drawing.Size(1059, 427);
            this.Dashboard_tbp.TabIndex = 0;
            this.Dashboard_tbp.Text = "Dashboard";
            this.Dashboard_tbp.UseVisualStyleBackColor = true;
            // 
            // ServiceRequest_tbp
            // 
            this.ServiceRequest_tbp.Controls.Add(this.PastRequests_dgv);
            this.ServiceRequest_tbp.Controls.Add(this.PastRequests_lbl);
            this.ServiceRequest_tbp.Controls.Add(this.NewServiceRequest_btn);
            this.ServiceRequest_tbp.Controls.Add(this.ServiceRequest_lbl);
            this.ServiceRequest_tbp.Location = new System.Drawing.Point(4, 34);
            this.ServiceRequest_tbp.Name = "ServiceRequest_tbp";
            this.ServiceRequest_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceRequest_tbp.Size = new System.Drawing.Size(1059, 427);
            this.ServiceRequest_tbp.TabIndex = 1;
            this.ServiceRequest_tbp.Text = "Service Request";
            this.ServiceRequest_tbp.UseVisualStyleBackColor = true;
            // 
            // Client_tbp
            // 
            this.Client_tbp.Controls.Add(this.ContractDetailsOverview_gbx);
            this.Client_tbp.Controls.Add(this.SearchClient_btn);
            this.Client_tbp.Controls.Add(this.ClientNumber_txt);
            this.Client_tbp.Controls.Add(this.ClientNumber_lbl);
            this.Client_tbp.Controls.Add(this.ClientName_txt);
            this.Client_tbp.Controls.Add(this.ClientName_lbl);
            this.Client_tbp.Controls.Add(this.SearchClient_lbl);
            this.Client_tbp.Location = new System.Drawing.Point(4, 34);
            this.Client_tbp.Name = "Client_tbp";
            this.Client_tbp.Size = new System.Drawing.Size(1059, 427);
            this.Client_tbp.TabIndex = 2;
            this.Client_tbp.Text = "Client";
            this.Client_tbp.UseVisualStyleBackColor = true;
            // 
            // History_tbp
            // 
            this.History_tbp.Controls.Add(this.Search_btn);
            this.History_tbp.Controls.Add(this.ClientNameOrNumber_txt);
            this.History_tbp.Controls.Add(this.ClientNameOrNumber_lbl);
            this.History_tbp.Controls.Add(this.PastServiceRequest_dgv);
            this.History_tbp.Controls.Add(this.PastServiceRequest_lbl);
            this.History_tbp.Location = new System.Drawing.Point(4, 34);
            this.History_tbp.Name = "History_tbp";
            this.History_tbp.Size = new System.Drawing.Size(1059, 427);
            this.History_tbp.TabIndex = 3;
            this.History_tbp.Text = "History";
            this.History_tbp.UseVisualStyleBackColor = true;
            // 
            // MaintananceOverview_lbl
            // 
            this.MaintananceOverview_lbl.AutoSize = true;
            this.MaintananceOverview_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintananceOverview_lbl.Location = new System.Drawing.Point(23, 16);
            this.MaintananceOverview_lbl.Name = "MaintananceOverview_lbl";
            this.MaintananceOverview_lbl.Size = new System.Drawing.Size(251, 31);
            this.MaintananceOverview_lbl.TabIndex = 0;
            this.MaintananceOverview_lbl.Text = "Maintanance Overview";
            // 
            // PastJobRequest_lbl
            // 
            this.PastJobRequest_lbl.AutoSize = true;
            this.PastJobRequest_lbl.Location = new System.Drawing.Point(29, 51);
            this.PastJobRequest_lbl.Name = "PastJobRequest_lbl";
            this.PastJobRequest_lbl.Size = new System.Drawing.Size(155, 25);
            this.PastJobRequest_lbl.TabIndex = 1;
            this.PastJobRequest_lbl.Text = "Past Job Requests";
            // 
            // Dashboard_dgv
            // 
            this.Dashboard_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dashboard_dgv.Location = new System.Drawing.Point(29, 92);
            this.Dashboard_dgv.Name = "Dashboard_dgv";
            this.Dashboard_dgv.RowHeadersWidth = 51;
            this.Dashboard_dgv.RowTemplate.Height = 24;
            this.Dashboard_dgv.Size = new System.Drawing.Size(995, 314);
            this.Dashboard_dgv.TabIndex = 2;
            // 
            // ServiceRequest_lbl
            // 
            this.ServiceRequest_lbl.AutoSize = true;
            this.ServiceRequest_lbl.Location = new System.Drawing.Point(22, 16);
            this.ServiceRequest_lbl.Name = "ServiceRequest_lbl";
            this.ServiceRequest_lbl.Size = new System.Drawing.Size(136, 25);
            this.ServiceRequest_lbl.TabIndex = 0;
            this.ServiceRequest_lbl.Text = "Service Request";
            // 
            // NewServiceRequest_btn
            // 
            this.NewServiceRequest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NewServiceRequest_btn.Location = new System.Drawing.Point(27, 54);
            this.NewServiceRequest_btn.Name = "NewServiceRequest_btn";
            this.NewServiceRequest_btn.Size = new System.Drawing.Size(235, 37);
            this.NewServiceRequest_btn.TabIndex = 1;
            this.NewServiceRequest_btn.Text = "New Service Request";
            this.NewServiceRequest_btn.UseVisualStyleBackColor = false;
            // 
            // PastRequests_lbl
            // 
            this.PastRequests_lbl.AutoSize = true;
            this.PastRequests_lbl.Location = new System.Drawing.Point(22, 108);
            this.PastRequests_lbl.Name = "PastRequests_lbl";
            this.PastRequests_lbl.Size = new System.Drawing.Size(295, 25);
            this.PastRequests_lbl.TabIndex = 2;
            this.PastRequests_lbl.Text = "Past Requests, Status and Feedback";
            // 
            // PastRequests_dgv
            // 
            this.PastRequests_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastRequests_dgv.Location = new System.Drawing.Point(27, 151);
            this.PastRequests_dgv.Name = "PastRequests_dgv";
            this.PastRequests_dgv.RowHeadersWidth = 51;
            this.PastRequests_dgv.RowTemplate.Height = 24;
            this.PastRequests_dgv.Size = new System.Drawing.Size(1009, 250);
            this.PastRequests_dgv.TabIndex = 3;
            // 
            // SearchClient_lbl
            // 
            this.SearchClient_lbl.AutoSize = true;
            this.SearchClient_lbl.Location = new System.Drawing.Point(24, 15);
            this.SearchClient_lbl.Name = "SearchClient_lbl";
            this.SearchClient_lbl.Size = new System.Drawing.Size(116, 25);
            this.SearchClient_lbl.TabIndex = 0;
            this.SearchClient_lbl.Text = "Search Client";
            // 
            // ClientName_lbl
            // 
            this.ClientName_lbl.AutoSize = true;
            this.ClientName_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ClientName_lbl.Location = new System.Drawing.Point(29, 44);
            this.ClientName_lbl.Name = "ClientName_lbl";
            this.ClientName_lbl.Size = new System.Drawing.Size(112, 25);
            this.ClientName_lbl.TabIndex = 1;
            this.ClientName_lbl.Text = "Client Name";
            // 
            // ClientName_txt
            // 
            this.ClientName_txt.Location = new System.Drawing.Point(43, 73);
            this.ClientName_txt.Name = "ClientName_txt";
            this.ClientName_txt.Size = new System.Drawing.Size(100, 32);
            this.ClientName_txt.TabIndex = 2;
            // 
            // ClientNumber_txt
            // 
            this.ClientNumber_txt.Location = new System.Drawing.Point(243, 73);
            this.ClientNumber_txt.Name = "ClientNumber_txt";
            this.ClientNumber_txt.Size = new System.Drawing.Size(100, 32);
            this.ClientNumber_txt.TabIndex = 4;
            // 
            // ClientNumber_lbl
            // 
            this.ClientNumber_lbl.AutoSize = true;
            this.ClientNumber_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ClientNumber_lbl.Location = new System.Drawing.Point(229, 44);
            this.ClientNumber_lbl.Name = "ClientNumber_lbl";
            this.ClientNumber_lbl.Size = new System.Drawing.Size(78, 25);
            this.ClientNumber_lbl.TabIndex = 3;
            this.ClientNumber_lbl.Text = "Number";
            // 
            // SearchClient_btn
            // 
            this.SearchClient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SearchClient_btn.ForeColor = System.Drawing.Color.Black;
            this.SearchClient_btn.Location = new System.Drawing.Point(449, 73);
            this.SearchClient_btn.Name = "SearchClient_btn";
            this.SearchClient_btn.Size = new System.Drawing.Size(88, 32);
            this.SearchClient_btn.TabIndex = 5;
            this.SearchClient_btn.Text = "Search";
            this.SearchClient_btn.UseVisualStyleBackColor = false;
            // 
            // ContractDetailsOverview_gbx
            // 
            this.ContractDetailsOverview_gbx.Controls.Add(this.ProcedureDownload_btn);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ProcedureView_btn);
            this.ContractDetailsOverview_gbx.Controls.Add(this.Procedure_lbl);
            this.ContractDetailsOverview_gbx.Controls.Add(this.CostDownload_btn);
            this.ContractDetailsOverview_gbx.Controls.Add(this.CostView_btn);
            this.ContractDetailsOverview_gbx.Controls.Add(this.Cost_lbl);
            this.ContractDetailsOverview_gbx.Controls.Add(this.RenewalOptionsDownload_btn);
            this.ContractDetailsOverview_gbx.Controls.Add(this.RenewalOptionView_btn);
            this.ContractDetailsOverview_gbx.Controls.Add(this.RenewalOptions_lbl);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ExperationDate_txt);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ExperationDate_lbl);
            this.ContractDetailsOverview_gbx.Controls.Add(this.Coverage_txt);
            this.ContractDetailsOverview_gbx.Controls.Add(this.Coverage_lbl);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ContractType_txt);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ContractType_lbl);
            this.ContractDetailsOverview_gbx.Location = new System.Drawing.Point(29, 142);
            this.ContractDetailsOverview_gbx.Name = "ContractDetailsOverview_gbx";
            this.ContractDetailsOverview_gbx.Size = new System.Drawing.Size(1007, 277);
            this.ContractDetailsOverview_gbx.TabIndex = 6;
            this.ContractDetailsOverview_gbx.TabStop = false;
            this.ContractDetailsOverview_gbx.Text = "Contract Details Overview";
            // 
            // ContractType_lbl
            // 
            this.ContractType_lbl.AutoSize = true;
            this.ContractType_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ContractType_lbl.Location = new System.Drawing.Point(27, 42);
            this.ContractType_lbl.Name = "ContractType_lbl";
            this.ContractType_lbl.Size = new System.Drawing.Size(123, 25);
            this.ContractType_lbl.TabIndex = 0;
            this.ContractType_lbl.Text = "Contract Type";
            // 
            // ContractType_txt
            // 
            this.ContractType_txt.Location = new System.Drawing.Point(32, 71);
            this.ContractType_txt.Name = "ContractType_txt";
            this.ContractType_txt.Size = new System.Drawing.Size(100, 32);
            this.ContractType_txt.TabIndex = 1;
            // 
            // Coverage_txt
            // 
            this.Coverage_txt.Location = new System.Drawing.Point(32, 148);
            this.Coverage_txt.Name = "Coverage_txt";
            this.Coverage_txt.Size = new System.Drawing.Size(100, 32);
            this.Coverage_txt.TabIndex = 3;
            // 
            // Coverage_lbl
            // 
            this.Coverage_lbl.AutoSize = true;
            this.Coverage_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Coverage_lbl.Location = new System.Drawing.Point(27, 119);
            this.Coverage_lbl.Name = "Coverage_lbl";
            this.Coverage_lbl.Size = new System.Drawing.Size(87, 25);
            this.Coverage_lbl.TabIndex = 2;
            this.Coverage_lbl.Text = "Coverage";
            // 
            // ExperationDate_txt
            // 
            this.ExperationDate_txt.Location = new System.Drawing.Point(32, 229);
            this.ExperationDate_txt.Name = "ExperationDate_txt";
            this.ExperationDate_txt.Size = new System.Drawing.Size(100, 32);
            this.ExperationDate_txt.TabIndex = 5;
            // 
            // ExperationDate_lbl
            // 
            this.ExperationDate_lbl.AutoSize = true;
            this.ExperationDate_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ExperationDate_lbl.Location = new System.Drawing.Point(27, 200);
            this.ExperationDate_lbl.Name = "ExperationDate_lbl";
            this.ExperationDate_lbl.Size = new System.Drawing.Size(140, 25);
            this.ExperationDate_lbl.TabIndex = 4;
            this.ExperationDate_lbl.Text = "Experation Date";
            this.ExperationDate_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // RenewalOptions_lbl
            // 
            this.RenewalOptions_lbl.AutoSize = true;
            this.RenewalOptions_lbl.ForeColor = System.Drawing.Color.Blue;
            this.RenewalOptions_lbl.Location = new System.Drawing.Point(477, 42);
            this.RenewalOptions_lbl.Name = "RenewalOptions_lbl";
            this.RenewalOptions_lbl.Size = new System.Drawing.Size(148, 25);
            this.RenewalOptions_lbl.TabIndex = 6;
            this.RenewalOptions_lbl.Text = "Renewal Options";
            // 
            // RenewalOptionView_btn
            // 
            this.RenewalOptionView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RenewalOptionView_btn.Location = new System.Drawing.Point(482, 68);
            this.RenewalOptionView_btn.Name = "RenewalOptionView_btn";
            this.RenewalOptionView_btn.Size = new System.Drawing.Size(119, 36);
            this.RenewalOptionView_btn.TabIndex = 7;
            this.RenewalOptionView_btn.Text = "View";
            this.RenewalOptionView_btn.UseVisualStyleBackColor = false;
            // 
            // RenewalOptionsDownload_btn
            // 
            this.RenewalOptionsDownload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RenewalOptionsDownload_btn.Location = new System.Drawing.Point(636, 68);
            this.RenewalOptionsDownload_btn.Name = "RenewalOptionsDownload_btn";
            this.RenewalOptionsDownload_btn.Size = new System.Drawing.Size(119, 36);
            this.RenewalOptionsDownload_btn.TabIndex = 8;
            this.RenewalOptionsDownload_btn.Text = "Download";
            this.RenewalOptionsDownload_btn.UseVisualStyleBackColor = false;
            // 
            // CostDownload_btn
            // 
            this.CostDownload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CostDownload_btn.Location = new System.Drawing.Point(636, 145);
            this.CostDownload_btn.Name = "CostDownload_btn";
            this.CostDownload_btn.Size = new System.Drawing.Size(119, 36);
            this.CostDownload_btn.TabIndex = 11;
            this.CostDownload_btn.Text = "Download";
            this.CostDownload_btn.UseVisualStyleBackColor = false;
            // 
            // CostView_btn
            // 
            this.CostView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CostView_btn.Location = new System.Drawing.Point(482, 145);
            this.CostView_btn.Name = "CostView_btn";
            this.CostView_btn.Size = new System.Drawing.Size(119, 36);
            this.CostView_btn.TabIndex = 10;
            this.CostView_btn.Text = "View";
            this.CostView_btn.UseVisualStyleBackColor = false;
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Cost_lbl.Location = new System.Drawing.Point(477, 119);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(47, 25);
            this.Cost_lbl.TabIndex = 9;
            this.Cost_lbl.Text = "Cost";
            // 
            // ProcedureDownload_btn
            // 
            this.ProcedureDownload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProcedureDownload_btn.Location = new System.Drawing.Point(636, 226);
            this.ProcedureDownload_btn.Name = "ProcedureDownload_btn";
            this.ProcedureDownload_btn.Size = new System.Drawing.Size(119, 36);
            this.ProcedureDownload_btn.TabIndex = 14;
            this.ProcedureDownload_btn.Text = "Download";
            this.ProcedureDownload_btn.UseVisualStyleBackColor = false;
            // 
            // ProcedureView_btn
            // 
            this.ProcedureView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProcedureView_btn.Location = new System.Drawing.Point(482, 226);
            this.ProcedureView_btn.Name = "ProcedureView_btn";
            this.ProcedureView_btn.Size = new System.Drawing.Size(119, 36);
            this.ProcedureView_btn.TabIndex = 13;
            this.ProcedureView_btn.Text = "View";
            this.ProcedureView_btn.UseVisualStyleBackColor = false;
            // 
            // Procedure_lbl
            // 
            this.Procedure_lbl.AutoSize = true;
            this.Procedure_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Procedure_lbl.Location = new System.Drawing.Point(477, 200);
            this.Procedure_lbl.Name = "Procedure_lbl";
            this.Procedure_lbl.Size = new System.Drawing.Size(93, 25);
            this.Procedure_lbl.TabIndex = 12;
            this.Procedure_lbl.Text = "Procedure";
            // 
            // PastServiceRequest_lbl
            // 
            this.PastServiceRequest_lbl.AutoSize = true;
            this.PastServiceRequest_lbl.Location = new System.Drawing.Point(12, 15);
            this.PastServiceRequest_lbl.Name = "PastServiceRequest_lbl";
            this.PastServiceRequest_lbl.Size = new System.Drawing.Size(468, 25);
            this.PastServiceRequest_lbl.TabIndex = 0;
            this.PastServiceRequest_lbl.Text = "Past Service Request, Maintanance activities and invoices";
            // 
            // PastServiceRequest_dgv
            // 
            this.PastServiceRequest_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastServiceRequest_dgv.Location = new System.Drawing.Point(17, 57);
            this.PastServiceRequest_dgv.Name = "PastServiceRequest_dgv";
            this.PastServiceRequest_dgv.RowHeadersWidth = 51;
            this.PastServiceRequest_dgv.RowTemplate.Height = 24;
            this.PastServiceRequest_dgv.Size = new System.Drawing.Size(1019, 296);
            this.PastServiceRequest_dgv.TabIndex = 1;
            // 
            // ClientNameOrNumber_lbl
            // 
            this.ClientNameOrNumber_lbl.AutoSize = true;
            this.ClientNameOrNumber_lbl.Location = new System.Drawing.Point(39, 360);
            this.ClientNameOrNumber_lbl.Name = "ClientNameOrNumber_lbl";
            this.ClientNameOrNumber_lbl.Size = new System.Drawing.Size(205, 25);
            this.ClientNameOrNumber_lbl.TabIndex = 2;
            this.ClientNameOrNumber_lbl.Text = "Client Name or Number";
            // 
            // ClientNameOrNumber_txt
            // 
            this.ClientNameOrNumber_txt.Location = new System.Drawing.Point(44, 389);
            this.ClientNameOrNumber_txt.Name = "ClientNameOrNumber_txt";
            this.ClientNameOrNumber_txt.Size = new System.Drawing.Size(100, 32);
            this.ClientNameOrNumber_txt.TabIndex = 3;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Search_btn.Location = new System.Drawing.Point(298, 389);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(99, 32);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CallEmployee_tbc);
            this.Controls.Add(this.Header_pnl);
            this.Name = "CallForm";
            this.Text = "CallForm";
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.CallEmployee_tbc.ResumeLayout(false);
            this.Dashboard_tbp.ResumeLayout(false);
            this.Dashboard_tbp.PerformLayout();
            this.ServiceRequest_tbp.ResumeLayout(false);
            this.ServiceRequest_tbp.PerformLayout();
            this.Client_tbp.ResumeLayout(false);
            this.Client_tbp.PerformLayout();
            this.History_tbp.ResumeLayout(false);
            this.History_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastRequests_dgv)).EndInit();
            this.ContractDetailsOverview_gbx.ResumeLayout(false);
            this.ContractDetailsOverview_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastServiceRequest_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.TabControl CallEmployee_tbc;
        private System.Windows.Forms.TabPage Dashboard_tbp;
        private System.Windows.Forms.TabPage ServiceRequest_tbp;
        private System.Windows.Forms.TabPage Client_tbp;
        private System.Windows.Forms.TabPage History_tbp;
        private System.Windows.Forms.DataGridView Dashboard_dgv;
        private System.Windows.Forms.Label PastJobRequest_lbl;
        private System.Windows.Forms.Label MaintananceOverview_lbl;
        private System.Windows.Forms.DataGridView PastRequests_dgv;
        private System.Windows.Forms.Label PastRequests_lbl;
        private System.Windows.Forms.Button NewServiceRequest_btn;
        private System.Windows.Forms.Label ServiceRequest_lbl;
        private System.Windows.Forms.GroupBox ContractDetailsOverview_gbx;
        private System.Windows.Forms.TextBox ExperationDate_txt;
        private System.Windows.Forms.Label ExperationDate_lbl;
        private System.Windows.Forms.TextBox Coverage_txt;
        private System.Windows.Forms.Label Coverage_lbl;
        private System.Windows.Forms.TextBox ContractType_txt;
        private System.Windows.Forms.Label ContractType_lbl;
        private System.Windows.Forms.Button SearchClient_btn;
        private System.Windows.Forms.TextBox ClientNumber_txt;
        private System.Windows.Forms.Label ClientNumber_lbl;
        private System.Windows.Forms.TextBox ClientName_txt;
        private System.Windows.Forms.Label ClientName_lbl;
        private System.Windows.Forms.Label SearchClient_lbl;
        private System.Windows.Forms.Button ProcedureDownload_btn;
        private System.Windows.Forms.Button ProcedureView_btn;
        private System.Windows.Forms.Label Procedure_lbl;
        private System.Windows.Forms.Button CostDownload_btn;
        private System.Windows.Forms.Button CostView_btn;
        private System.Windows.Forms.Label Cost_lbl;
        private System.Windows.Forms.Button RenewalOptionsDownload_btn;
        private System.Windows.Forms.Button RenewalOptionView_btn;
        private System.Windows.Forms.Label RenewalOptions_lbl;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox ClientNameOrNumber_txt;
        private System.Windows.Forms.Label ClientNameOrNumber_lbl;
        private System.Windows.Forms.DataGridView PastServiceRequest_dgv;
        private System.Windows.Forms.Label PastServiceRequest_lbl;
    }
}