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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallForm));
            this.Header_pnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.CallEmployee_tc = new System.Windows.Forms.TabControl();
            this.Dashboard_tp = new System.Windows.Forms.TabPage();
            this.Dashboard_dgv = new System.Windows.Forms.DataGridView();
            this.PastJobRequest_lbl = new System.Windows.Forms.Label();
            this.MaintananceOverview_lbl = new System.Windows.Forms.Label();
            this.ServiceRequest_tp = new System.Windows.Forms.TabPage();
            this.NewServiceClientName_lbl = new System.Windows.Forms.Label();
            this.NewServiceClientName_txt = new System.Windows.Forms.TextBox();
            this.PastRequests_dgv = new System.Windows.Forms.DataGridView();
            this.PastRequests_lbl = new System.Windows.Forms.Label();
            this.NewServiceRequest_btn = new System.Windows.Forms.Button();
            this.ServiceRequest_lbl = new System.Windows.Forms.Label();
            this.Client_tp = new System.Windows.Forms.TabPage();
            this.ContractDetailsOverview_gbx = new System.Windows.Forms.GroupBox();
            this.ContractOverview_dgv = new System.Windows.Forms.DataGridView();
            this.ExperationDate_txt = new System.Windows.Forms.TextBox();
            this.ExperationDate_lbl = new System.Windows.Forms.Label();
            this.Priority_txt = new System.Windows.Forms.TextBox();
            this.ContractDuration_txt = new System.Windows.Forms.TextBox();
            this.ContractDuration_lbl = new System.Windows.Forms.Label();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.SearchClient_btn = new System.Windows.Forms.Button();
            this.ClientName_txt = new System.Windows.Forms.TextBox();
            this.ClientName_lbl = new System.Windows.Forms.Label();
            this.SearchClient_lbl = new System.Windows.Forms.Label();
            this.History_tbp = new System.Windows.Forms.TabPage();
            this.Search_btn = new System.Windows.Forms.Button();
            this.SearchClientName_txt = new System.Windows.Forms.TextBox();
            this.SearchClientName_lbl = new System.Windows.Forms.Label();
            this.PastServiceRequest_dgv = new System.Windows.Forms.DataGridView();
            this.PastServiceRequest_lbl = new System.Windows.Forms.Label();
            this.History_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.CallEmployee_tc.SuspendLayout();
            this.Dashboard_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard_dgv)).BeginInit();
            this.ServiceRequest_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastRequests_dgv)).BeginInit();
            this.Client_tp.SuspendLayout();
            this.ContractDetailsOverview_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractOverview_dgv)).BeginInit();
            this.History_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastServiceRequest_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_pnl
            // 
            this.Header_pnl.AutoSize = true;
            this.Header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(923, 0);
            this.Header_pnl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(763, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Location = new System.Drawing.Point(793, 5);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(75, 23);
            this.Logout_btn.TabIndex = 0;
            // 
            // PSS_lbl
            // 
            this.PSS_lbl.AutoSize = true;
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.ForeColor = System.Drawing.Color.Black;
            this.PSS_lbl.Location = new System.Drawing.Point(94, 26);
            this.PSS_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(544, 32);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back <Name> <Surname> (Call Centre)";
            // 
            // PSS_img
            // 
            this.PSS_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PSS_img.BackgroundImage")));
            this.PSS_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PSS_img.Location = new System.Drawing.Point(12, 9);
            this.PSS_img.Margin = new System.Windows.Forms.Padding(2);
            this.PSS_img.Name = "PSS_img";
            this.PSS_img.Size = new System.Drawing.Size(76, 61);
            this.PSS_img.TabIndex = 0;
            this.PSS_img.TabStop = false;
            // 
            // CallEmployee_tc
            // 
            this.CallEmployee_tc.Controls.Add(this.Dashboard_tp);
            this.CallEmployee_tc.Controls.Add(this.ServiceRequest_tp);
            this.CallEmployee_tc.Controls.Add(this.Client_tp);
            this.CallEmployee_tc.Controls.Add(this.History_tbp);
            this.CallEmployee_tc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallEmployee_tc.Location = new System.Drawing.Point(12, 100);
            this.CallEmployee_tc.Margin = new System.Windows.Forms.Padding(2);
            this.CallEmployee_tc.Name = "CallEmployee_tc";
            this.CallEmployee_tc.SelectedIndex = 0;
            this.CallEmployee_tc.Size = new System.Drawing.Size(873, 456);
            this.CallEmployee_tc.TabIndex = 1;
            // 
            // Dashboard_tp
            // 
            this.Dashboard_tp.Controls.Add(this.Dashboard_dgv);
            this.Dashboard_tp.Controls.Add(this.PastJobRequest_lbl);
            this.Dashboard_tp.Controls.Add(this.MaintananceOverview_lbl);
            this.Dashboard_tp.Location = new System.Drawing.Point(4, 39);
            this.Dashboard_tp.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard_tp.Name = "Dashboard_tp";
            this.Dashboard_tp.Padding = new System.Windows.Forms.Padding(2);
            this.Dashboard_tp.Size = new System.Drawing.Size(865, 413);
            this.Dashboard_tp.TabIndex = 0;
            this.Dashboard_tp.Text = "Dashboard";
            this.Dashboard_tp.UseVisualStyleBackColor = true;
            // 
            // Dashboard_dgv
            // 
            this.Dashboard_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dashboard_dgv.Location = new System.Drawing.Point(22, 75);
            this.Dashboard_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard_dgv.Name = "Dashboard_dgv";
            this.Dashboard_dgv.RowHeadersWidth = 51;
            this.Dashboard_dgv.RowTemplate.Height = 24;
            this.Dashboard_dgv.Size = new System.Drawing.Size(830, 324);
            this.Dashboard_dgv.TabIndex = 2;
            // 
            // PastJobRequest_lbl
            // 
            this.PastJobRequest_lbl.AutoSize = true;
            this.PastJobRequest_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastJobRequest_lbl.Location = new System.Drawing.Point(17, 43);
            this.PastJobRequest_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PastJobRequest_lbl.Name = "PastJobRequest_lbl";
            this.PastJobRequest_lbl.Size = new System.Drawing.Size(159, 25);
            this.PastJobRequest_lbl.TabIndex = 1;
            this.PastJobRequest_lbl.Text = "Past Job Requests";
            // 
            // MaintananceOverview_lbl
            // 
            this.MaintananceOverview_lbl.AutoSize = true;
            this.MaintananceOverview_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintananceOverview_lbl.Location = new System.Drawing.Point(17, 13);
            this.MaintananceOverview_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaintananceOverview_lbl.Name = "MaintananceOverview_lbl";
            this.MaintananceOverview_lbl.Size = new System.Drawing.Size(225, 30);
            this.MaintananceOverview_lbl.TabIndex = 0;
            this.MaintananceOverview_lbl.Text = "Maintanance Overview";
            // 
            // ServiceRequest_tp
            // 
            this.ServiceRequest_tp.Controls.Add(this.NewServiceClientName_lbl);
            this.ServiceRequest_tp.Controls.Add(this.NewServiceClientName_txt);
            this.ServiceRequest_tp.Controls.Add(this.PastRequests_dgv);
            this.ServiceRequest_tp.Controls.Add(this.PastRequests_lbl);
            this.ServiceRequest_tp.Controls.Add(this.NewServiceRequest_btn);
            this.ServiceRequest_tp.Controls.Add(this.ServiceRequest_lbl);
            this.ServiceRequest_tp.Location = new System.Drawing.Point(4, 39);
            this.ServiceRequest_tp.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceRequest_tp.Name = "ServiceRequest_tp";
            this.ServiceRequest_tp.Padding = new System.Windows.Forms.Padding(2);
            this.ServiceRequest_tp.Size = new System.Drawing.Size(865, 413);
            this.ServiceRequest_tp.TabIndex = 1;
            this.ServiceRequest_tp.Text = "Service Request";
            this.ServiceRequest_tp.UseVisualStyleBackColor = true;
            // 
            // NewServiceClientName_lbl
            // 
            this.NewServiceClientName_lbl.AutoSize = true;
            this.NewServiceClientName_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewServiceClientName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.NewServiceClientName_lbl.Location = new System.Drawing.Point(17, 57);
            this.NewServiceClientName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewServiceClientName_lbl.Name = "NewServiceClientName_lbl";
            this.NewServiceClientName_lbl.Size = new System.Drawing.Size(96, 21);
            this.NewServiceClientName_lbl.TabIndex = 5;
            this.NewServiceClientName_lbl.Text = "Client Name";
            // 
            // NewServiceClientName_txt
            // 
            this.NewServiceClientName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewServiceClientName_txt.Location = new System.Drawing.Point(21, 80);
            this.NewServiceClientName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.NewServiceClientName_txt.Name = "NewServiceClientName_txt";
            this.NewServiceClientName_txt.Size = new System.Drawing.Size(141, 29);
            this.NewServiceClientName_txt.TabIndex = 4;
            // 
            // PastRequests_dgv
            // 
            this.PastRequests_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastRequests_dgv.Location = new System.Drawing.Point(20, 172);
            this.PastRequests_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.PastRequests_dgv.Name = "PastRequests_dgv";
            this.PastRequests_dgv.RowHeadersWidth = 51;
            this.PastRequests_dgv.RowTemplate.Height = 24;
            this.PastRequests_dgv.Size = new System.Drawing.Size(832, 233);
            this.PastRequests_dgv.TabIndex = 3;
            // 
            // PastRequests_lbl
            // 
            this.PastRequests_lbl.AutoSize = true;
            this.PastRequests_lbl.Location = new System.Drawing.Point(16, 131);
            this.PastRequests_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PastRequests_lbl.Name = "PastRequests_lbl";
            this.PastRequests_lbl.Size = new System.Drawing.Size(341, 30);
            this.PastRequests_lbl.TabIndex = 2;
            this.PastRequests_lbl.Text = "Past Requests, Status and Feedback";
            // 
            // NewServiceRequest_btn
            // 
            this.NewServiceRequest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.NewServiceRequest_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.NewServiceRequest_btn.FlatAppearance.BorderSize = 0;
            this.NewServiceRequest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewServiceRequest_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewServiceRequest_btn.Location = new System.Drawing.Point(199, 76);
            this.NewServiceRequest_btn.Margin = new System.Windows.Forms.Padding(2);
            this.NewServiceRequest_btn.Name = "NewServiceRequest_btn";
            this.NewServiceRequest_btn.Size = new System.Drawing.Size(158, 35);
            this.NewServiceRequest_btn.TabIndex = 1;
            this.NewServiceRequest_btn.Text = "New Service Request";
            this.NewServiceRequest_btn.UseVisualStyleBackColor = false;
            this.NewServiceRequest_btn.Click += new System.EventHandler(this.NewServiceRequest_btn_Click);
            // 
            // ServiceRequest_lbl
            // 
            this.ServiceRequest_lbl.AutoSize = true;
            this.ServiceRequest_lbl.Location = new System.Drawing.Point(16, 13);
            this.ServiceRequest_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceRequest_lbl.Name = "ServiceRequest_lbl";
            this.ServiceRequest_lbl.Size = new System.Drawing.Size(158, 30);
            this.ServiceRequest_lbl.TabIndex = 0;
            this.ServiceRequest_lbl.Text = "Service Request";
            // 
            // Client_tp
            // 
            this.Client_tp.Controls.Add(this.ContractDetailsOverview_gbx);
            this.Client_tp.Controls.Add(this.SearchClient_btn);
            this.Client_tp.Controls.Add(this.ClientName_txt);
            this.Client_tp.Controls.Add(this.ClientName_lbl);
            this.Client_tp.Controls.Add(this.SearchClient_lbl);
            this.Client_tp.Location = new System.Drawing.Point(4, 39);
            this.Client_tp.Margin = new System.Windows.Forms.Padding(2);
            this.Client_tp.Name = "Client_tp";
            this.Client_tp.Size = new System.Drawing.Size(865, 413);
            this.Client_tp.TabIndex = 2;
            this.Client_tp.Text = "Client";
            this.Client_tp.UseVisualStyleBackColor = true;
            // 
            // ContractDetailsOverview_gbx
            // 
            this.ContractDetailsOverview_gbx.Controls.Add(this.ContractOverview_dgv);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ExperationDate_txt);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ExperationDate_lbl);
            this.ContractDetailsOverview_gbx.Controls.Add(this.Priority_txt);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ContractDuration_txt);
            this.ContractDetailsOverview_gbx.Controls.Add(this.ContractDuration_lbl);
            this.ContractDetailsOverview_gbx.Controls.Add(this.Priority_lbl);
            this.ContractDetailsOverview_gbx.Location = new System.Drawing.Point(15, 99);
            this.ContractDetailsOverview_gbx.Margin = new System.Windows.Forms.Padding(2);
            this.ContractDetailsOverview_gbx.Name = "ContractDetailsOverview_gbx";
            this.ContractDetailsOverview_gbx.Padding = new System.Windows.Forms.Padding(2);
            this.ContractDetailsOverview_gbx.Size = new System.Drawing.Size(837, 305);
            this.ContractDetailsOverview_gbx.TabIndex = 6;
            this.ContractDetailsOverview_gbx.TabStop = false;
            this.ContractDetailsOverview_gbx.Text = "Contract Details Overview";
            // 
            // ContractOverview_dgv
            // 
            this.ContractOverview_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractOverview_dgv.Location = new System.Drawing.Point(12, 32);
            this.ContractOverview_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.ContractOverview_dgv.Name = "ContractOverview_dgv";
            this.ContractOverview_dgv.RowHeadersWidth = 51;
            this.ContractOverview_dgv.RowTemplate.Height = 24;
            this.ContractOverview_dgv.Size = new System.Drawing.Size(806, 190);
            this.ContractOverview_dgv.TabIndex = 6;
            // 
            // ExperationDate_txt
            // 
            this.ExperationDate_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExperationDate_txt.Location = new System.Drawing.Point(606, 261);
            this.ExperationDate_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ExperationDate_txt.Name = "ExperationDate_txt";
            this.ExperationDate_txt.Size = new System.Drawing.Size(158, 29);
            this.ExperationDate_txt.TabIndex = 5;
            // 
            // ExperationDate_lbl
            // 
            this.ExperationDate_lbl.AutoSize = true;
            this.ExperationDate_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExperationDate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ExperationDate_lbl.Location = new System.Drawing.Point(602, 238);
            this.ExperationDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExperationDate_lbl.Name = "ExperationDate_lbl";
            this.ExperationDate_lbl.Size = new System.Drawing.Size(119, 21);
            this.ExperationDate_lbl.TabIndex = 4;
            this.ExperationDate_lbl.Text = "Experation Date";
            this.ExperationDate_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Priority_txt
            // 
            this.Priority_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_txt.Location = new System.Drawing.Point(43, 261);
            this.Priority_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Priority_txt.Name = "Priority_txt";
            this.Priority_txt.Size = new System.Drawing.Size(158, 29);
            this.Priority_txt.TabIndex = 3;
            this.Priority_txt.TextChanged += new System.EventHandler(this.Title_txt_TextChanged);
            // 
            // ContractDuration_txt
            // 
            this.ContractDuration_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractDuration_txt.Location = new System.Drawing.Point(321, 261);
            this.ContractDuration_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ContractDuration_txt.Name = "ContractDuration_txt";
            this.ContractDuration_txt.Size = new System.Drawing.Size(158, 29);
            this.ContractDuration_txt.TabIndex = 1;
            // 
            // ContractDuration_lbl
            // 
            this.ContractDuration_lbl.AutoSize = true;
            this.ContractDuration_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractDuration_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ContractDuration_lbl.Location = new System.Drawing.Point(317, 238);
            this.ContractDuration_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractDuration_lbl.Name = "ContractDuration_lbl";
            this.ContractDuration_lbl.Size = new System.Drawing.Size(134, 21);
            this.ContractDuration_lbl.TabIndex = 0;
            this.ContractDuration_lbl.Text = "Contract Duration";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Priority_lbl.Location = new System.Drawing.Point(41, 238);
            this.Priority_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(61, 21);
            this.Priority_lbl.TabIndex = 2;
            this.Priority_lbl.Text = "Priority";
            // 
            // SearchClient_btn
            // 
            this.SearchClient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.SearchClient_btn.FlatAppearance.BorderSize = 0;
            this.SearchClient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchClient_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClient_btn.ForeColor = System.Drawing.Color.Black;
            this.SearchClient_btn.Location = new System.Drawing.Point(260, 60);
            this.SearchClient_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchClient_btn.Name = "SearchClient_btn";
            this.SearchClient_btn.Size = new System.Drawing.Size(158, 35);
            this.SearchClient_btn.TabIndex = 5;
            this.SearchClient_btn.Text = "Search";
            this.SearchClient_btn.UseVisualStyleBackColor = false;
            this.SearchClient_btn.Click += new System.EventHandler(this.SearchClient_btn_Click);
            // 
            // ClientName_txt
            // 
            this.ClientName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName_txt.Location = new System.Drawing.Point(25, 66);
            this.ClientName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ClientName_txt.Name = "ClientName_txt";
            this.ClientName_txt.Size = new System.Drawing.Size(158, 29);
            this.ClientName_txt.TabIndex = 2;
            // 
            // ClientName_lbl
            // 
            this.ClientName_lbl.AutoSize = true;
            this.ClientName_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ClientName_lbl.Location = new System.Drawing.Point(21, 43);
            this.ClientName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientName_lbl.Name = "ClientName_lbl";
            this.ClientName_lbl.Size = new System.Drawing.Size(96, 21);
            this.ClientName_lbl.TabIndex = 1;
            this.ClientName_lbl.Text = "Client Name";
            // 
            // SearchClient_lbl
            // 
            this.SearchClient_lbl.AutoSize = true;
            this.SearchClient_lbl.Location = new System.Drawing.Point(20, 4);
            this.SearchClient_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchClient_lbl.Name = "SearchClient_lbl";
            this.SearchClient_lbl.Size = new System.Drawing.Size(134, 30);
            this.SearchClient_lbl.TabIndex = 0;
            this.SearchClient_lbl.Text = "Search Client";
            // 
            // History_tbp
            // 
            this.History_tbp.Controls.Add(this.History_lbl);
            this.History_tbp.Controls.Add(this.Search_btn);
            this.History_tbp.Controls.Add(this.SearchClientName_txt);
            this.History_tbp.Controls.Add(this.SearchClientName_lbl);
            this.History_tbp.Controls.Add(this.PastServiceRequest_dgv);
            this.History_tbp.Controls.Add(this.PastServiceRequest_lbl);
            this.History_tbp.Location = new System.Drawing.Point(4, 39);
            this.History_tbp.Margin = new System.Windows.Forms.Padding(2);
            this.History_tbp.Name = "History_tbp";
            this.History_tbp.Size = new System.Drawing.Size(865, 413);
            this.History_tbp.TabIndex = 3;
            this.History_tbp.Text = "History";
            this.History_tbp.UseVisualStyleBackColor = true;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(292, 66);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(158, 35);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // SearchClientName_txt
            // 
            this.SearchClientName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClientName_txt.Location = new System.Drawing.Point(23, 70);
            this.SearchClientName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchClientName_txt.Name = "SearchClientName_txt";
            this.SearchClientName_txt.Size = new System.Drawing.Size(158, 29);
            this.SearchClientName_txt.TabIndex = 3;
            // 
            // SearchClientName_lbl
            // 
            this.SearchClientName_lbl.AutoSize = true;
            this.SearchClientName_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClientName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.SearchClientName_lbl.Location = new System.Drawing.Point(19, 46);
            this.SearchClientName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchClientName_lbl.Name = "SearchClientName_lbl";
            this.SearchClientName_lbl.Size = new System.Drawing.Size(96, 21);
            this.SearchClientName_lbl.TabIndex = 2;
            this.SearchClientName_lbl.Text = "Client Name";
            // 
            // PastServiceRequest_dgv
            // 
            this.PastServiceRequest_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastServiceRequest_dgv.Location = new System.Drawing.Point(13, 164);
            this.PastServiceRequest_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.PastServiceRequest_dgv.Name = "PastServiceRequest_dgv";
            this.PastServiceRequest_dgv.RowHeadersWidth = 51;
            this.PastServiceRequest_dgv.RowTemplate.Height = 24;
            this.PastServiceRequest_dgv.Size = new System.Drawing.Size(839, 232);
            this.PastServiceRequest_dgv.TabIndex = 1;
            // 
            // PastServiceRequest_lbl
            // 
            this.PastServiceRequest_lbl.AutoSize = true;
            this.PastServiceRequest_lbl.Location = new System.Drawing.Point(8, 122);
            this.PastServiceRequest_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PastServiceRequest_lbl.Name = "PastServiceRequest_lbl";
            this.PastServiceRequest_lbl.Size = new System.Drawing.Size(541, 30);
            this.PastServiceRequest_lbl.TabIndex = 0;
            this.PastServiceRequest_lbl.Text = "Past Service Request, Maintanance activities and invoices";
            // 
            // History_lbl
            // 
            this.History_lbl.AutoSize = true;
            this.History_lbl.Location = new System.Drawing.Point(18, 15);
            this.History_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.History_lbl.Name = "History_lbl";
            this.History_lbl.Size = new System.Drawing.Size(78, 30);
            this.History_lbl.TabIndex = 5;
            this.History_lbl.Text = "History";
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CallEmployee_tc);
            this.Controls.Add(this.Header_pnl);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.PSS_img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CallForm";
            this.Text = "Call Centre";
            this.Load += new System.EventHandler(this.CallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.CallEmployee_tc.ResumeLayout(false);
            this.Dashboard_tp.ResumeLayout(false);
            this.Dashboard_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard_dgv)).EndInit();
            this.ServiceRequest_tp.ResumeLayout(false);
            this.ServiceRequest_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastRequests_dgv)).EndInit();
            this.Client_tp.ResumeLayout(false);
            this.Client_tp.PerformLayout();
            this.ContractDetailsOverview_gbx.ResumeLayout(false);
            this.ContractDetailsOverview_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractOverview_dgv)).EndInit();
            this.History_tbp.ResumeLayout(false);
            this.History_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastServiceRequest_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.TabControl CallEmployee_tc;
        private System.Windows.Forms.TabPage Dashboard_tp;
        private System.Windows.Forms.TabPage ServiceRequest_tp;
        private System.Windows.Forms.TabPage Client_tp;
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
        private System.Windows.Forms.TextBox Priority_txt;
        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.TextBox ContractDuration_txt;
        private System.Windows.Forms.Label ContractDuration_lbl;
        private System.Windows.Forms.TextBox ClientName_txt;
        private System.Windows.Forms.Label ClientName_lbl;
        private System.Windows.Forms.Label SearchClient_lbl;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox SearchClientName_txt;
        private System.Windows.Forms.Label SearchClientName_lbl;
        private System.Windows.Forms.DataGridView PastServiceRequest_dgv;
        private System.Windows.Forms.Label PastServiceRequest_lbl;
        private System.Windows.Forms.Button SearchClient_btn;
        private System.Windows.Forms.DataGridView ContractOverview_dgv;
        private System.Windows.Forms.Label NewServiceClientName_lbl;
        private System.Windows.Forms.TextBox NewServiceClientName_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label History_lbl;
    }
}