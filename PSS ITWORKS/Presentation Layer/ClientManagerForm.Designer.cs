﻿namespace PSS_ITWORKS.Presentation_Layer
{
    partial class ClientManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagerForm));
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.WelcomeClientManager_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Clients_tbc = new System.Windows.Forms.TabControl();
            this.Clients_tbp = new System.Windows.Forms.TabPage();
            this.clientDetail_dgv = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSSDataSet = new PSS_ITWORKS.PSSDataSet();
            this.clientContract_tbp = new System.Windows.Forms.TabPage();
            this.clientContract_dgv = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientAndContractInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientJobs_tbp = new System.Windows.Forms.TabPage();
            this.clientJobs_dgv = new System.Windows.Forms.DataGridView();
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientID_txt = new System.Windows.Forms.TextBox();
            this.clientID_lbl = new System.Windows.Forms.Label();
            this.clientContactDetail_txt = new System.Windows.Forms.TextBox();
            this.clientContactDetail_lbl = new System.Windows.Forms.Label();
            this.clientContract_txt = new System.Windows.Forms.TextBox();
            this.clientContract_lbl = new System.Windows.Forms.Label();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.client_lbl = new System.Windows.Forms.Label();
            this.getClientJobsTableAdapter = new PSS_ITWORKS.PSSDataSetTableAdapters.GetClientJobsTableAdapter();
            this.getClientDetailsTableAdapter = new PSS_ITWORKS.PSSDataSetTableAdapters.GetClientDetailsTableAdapter();
            this.getClientAndContractInfoTableAdapter = new PSS_ITWORKS.PSSDataSetTableAdapters.GetClientAndContractInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.Clients_tbc.SuspendLayout();
            this.Clients_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSSDataSet)).BeginInit();
            this.clientContract_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientContract_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientAndContractInfoBindingSource)).BeginInit();
            this.clientJobs_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientJobs_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientJobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo_img.BackgroundImage")));
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(12, 9);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(76, 61);
            this.Logo_img.TabIndex = 11;
            this.Logo_img.TabStop = false;
            // 
            // WelcomeClientManager_lbl
            // 
            this.WelcomeClientManager_lbl.AutoSize = true;
            this.WelcomeClientManager_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeClientManager_lbl.ForeColor = System.Drawing.Color.Black;
            this.WelcomeClientManager_lbl.Location = new System.Drawing.Point(92, 20);
            this.WelcomeClientManager_lbl.Name = "WelcomeClientManager_lbl";
            this.WelcomeClientManager_lbl.Size = new System.Drawing.Size(591, 32);
            this.WelcomeClientManager_lbl.TabIndex = 10;
            this.WelcomeClientManager_lbl.Text = "Welcome back <Name> <Surname> (Client Manager)";
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(749, 26);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(118, 36);
            this.Logout_btn.TabIndex = 12;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Clients_tbc
            // 
            this.Clients_tbc.Controls.Add(this.Clients_tbp);
            this.Clients_tbc.Controls.Add(this.clientContract_tbp);
            this.Clients_tbc.Controls.Add(this.clientJobs_tbp);
            this.Clients_tbc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients_tbc.Location = new System.Drawing.Point(220, 98);
            this.Clients_tbc.Margin = new System.Windows.Forms.Padding(2);
            this.Clients_tbc.Name = "Clients_tbc";
            this.Clients_tbc.SelectedIndex = 0;
            this.Clients_tbc.Size = new System.Drawing.Size(692, 451);
            this.Clients_tbc.TabIndex = 13;
            // 
            // Clients_tbp
            // 
            this.Clients_tbp.BackColor = System.Drawing.Color.Transparent;
            this.Clients_tbp.Controls.Add(this.clientDetail_dgv);
            this.Clients_tbp.Location = new System.Drawing.Point(4, 30);
            this.Clients_tbp.Margin = new System.Windows.Forms.Padding(2);
            this.Clients_tbp.Name = "Clients_tbp";
            this.Clients_tbp.Padding = new System.Windows.Forms.Padding(2);
            this.Clients_tbp.Size = new System.Drawing.Size(684, 417);
            this.Clients_tbp.TabIndex = 0;
            this.Clients_tbp.Text = "Clients";
            // 
            // clientDetail_dgv
            // 
            this.clientDetail_dgv.AutoGenerateColumns = false;
            this.clientDetail_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDetail_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.personnameDataGridViewTextBoxColumn,
            this.personsurnameDataGridViewTextBoxColumn,
            this.streetnoDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.zipcodeDataGridViewTextBoxColumn});
            this.clientDetail_dgv.DataSource = this.getClientDetailsBindingSource;
            this.clientDetail_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDetail_dgv.Location = new System.Drawing.Point(2, 2);
            this.clientDetail_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.clientDetail_dgv.Name = "clientDetail_dgv";
            this.clientDetail_dgv.RowHeadersWidth = 51;
            this.clientDetail_dgv.RowTemplate.Height = 24;
            this.clientDetail_dgv.Size = new System.Drawing.Size(680, 413);
            this.clientDetail_dgv.TabIndex = 0;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Width = 125;
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "company_name";
            this.companynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.Width = 125;
            // 
            // personnameDataGridViewTextBoxColumn
            // 
            this.personnameDataGridViewTextBoxColumn.DataPropertyName = "person_name";
            this.personnameDataGridViewTextBoxColumn.HeaderText = "person_name";
            this.personnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personnameDataGridViewTextBoxColumn.Name = "personnameDataGridViewTextBoxColumn";
            this.personnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // personsurnameDataGridViewTextBoxColumn
            // 
            this.personsurnameDataGridViewTextBoxColumn.DataPropertyName = "person_surname";
            this.personsurnameDataGridViewTextBoxColumn.HeaderText = "person_surname";
            this.personsurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personsurnameDataGridViewTextBoxColumn.Name = "personsurnameDataGridViewTextBoxColumn";
            this.personsurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetnoDataGridViewTextBoxColumn
            // 
            this.streetnoDataGridViewTextBoxColumn.DataPropertyName = "street_no";
            this.streetnoDataGridViewTextBoxColumn.HeaderText = "street_no";
            this.streetnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetnoDataGridViewTextBoxColumn.Name = "streetnoDataGridViewTextBoxColumn";
            this.streetnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "province";
            this.provinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "zipcode";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "zipcode";
            this.zipcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            this.zipcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // getClientDetailsBindingSource
            // 
            this.getClientDetailsBindingSource.DataMember = "GetClientDetails";
            this.getClientDetailsBindingSource.DataSource = this.pSSDataSet;
            // 
            // pSSDataSet
            // 
            this.pSSDataSet.DataSetName = "PSSDataSet";
            this.pSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientContract_tbp
            // 
            this.clientContract_tbp.Controls.Add(this.clientContract_dgv);
            this.clientContract_tbp.Location = new System.Drawing.Point(4, 30);
            this.clientContract_tbp.Margin = new System.Windows.Forms.Padding(2);
            this.clientContract_tbp.Name = "clientContract_tbp";
            this.clientContract_tbp.Padding = new System.Windows.Forms.Padding(2);
            this.clientContract_tbp.Size = new System.Drawing.Size(684, 417);
            this.clientContract_tbp.TabIndex = 1;
            this.clientContract_tbp.Text = "Client Contracts";
            this.clientContract_tbp.UseVisualStyleBackColor = true;
            // 
            // clientContract_dgv
            // 
            this.clientContract_dgv.AutoGenerateColumns = false;
            this.clientContract_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientContract_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn1,
            this.companynameDataGridViewTextBoxColumn1,
            this.sLADataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn});
            this.clientContract_dgv.DataSource = this.getClientAndContractInfoBindingSource;
            this.clientContract_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientContract_dgv.Location = new System.Drawing.Point(2, 2);
            this.clientContract_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.clientContract_dgv.Name = "clientContract_dgv";
            this.clientContract_dgv.RowHeadersWidth = 51;
            this.clientContract_dgv.RowTemplate.Height = 24;
            this.clientContract_dgv.Size = new System.Drawing.Size(680, 413);
            this.clientContract_dgv.TabIndex = 1;
            // 
            // clientidDataGridViewTextBoxColumn1
            // 
            this.clientidDataGridViewTextBoxColumn1.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn1.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn1.Name = "clientidDataGridViewTextBoxColumn1";
            this.clientidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // companynameDataGridViewTextBoxColumn1
            // 
            this.companynameDataGridViewTextBoxColumn1.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn1.HeaderText = "company_name";
            this.companynameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.companynameDataGridViewTextBoxColumn1.Name = "companynameDataGridViewTextBoxColumn1";
            this.companynameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sLADataGridViewTextBoxColumn
            // 
            this.sLADataGridViewTextBoxColumn.DataPropertyName = "SLA";
            this.sLADataGridViewTextBoxColumn.HeaderText = "SLA";
            this.sLADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLADataGridViewTextBoxColumn.Name = "sLADataGridViewTextBoxColumn";
            this.sLADataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "priority";
            this.priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // getClientAndContractInfoBindingSource
            // 
            this.getClientAndContractInfoBindingSource.DataMember = "GetClientAndContractInfo";
            this.getClientAndContractInfoBindingSource.DataSource = this.pSSDataSet;
            // 
            // clientJobs_tbp
            // 
            this.clientJobs_tbp.Controls.Add(this.clientJobs_dgv);
            this.clientJobs_tbp.Location = new System.Drawing.Point(4, 30);
            this.clientJobs_tbp.Margin = new System.Windows.Forms.Padding(2);
            this.clientJobs_tbp.Name = "clientJobs_tbp";
            this.clientJobs_tbp.Padding = new System.Windows.Forms.Padding(2);
            this.clientJobs_tbp.Size = new System.Drawing.Size(684, 417);
            this.clientJobs_tbp.TabIndex = 2;
            this.clientJobs_tbp.Text = "Clients & Jobs";
            this.clientJobs_tbp.UseVisualStyleBackColor = true;
            // 
            // clientJobs_dgv
            // 
            this.clientJobs_dgv.AutoGenerateColumns = false;
            this.clientJobs_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientJobs_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobidDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn2,
            this.serviceidDataGridViewTextBoxColumn,
            this.servicetitleDataGridViewTextBoxColumn,
            this.timebeginDataGridViewTextBoxColumn,
            this.timeendDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.clientJobs_dgv.DataSource = this.getClientJobsBindingSource;
            this.clientJobs_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientJobs_dgv.Location = new System.Drawing.Point(2, 2);
            this.clientJobs_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.clientJobs_dgv.Name = "clientJobs_dgv";
            this.clientJobs_dgv.RowHeadersWidth = 51;
            this.clientJobs_dgv.RowTemplate.Height = 24;
            this.clientJobs_dgv.Size = new System.Drawing.Size(680, 413);
            this.clientJobs_dgv.TabIndex = 1;
            // 
            // jobidDataGridViewTextBoxColumn
            // 
            this.jobidDataGridViewTextBoxColumn.DataPropertyName = "job_id";
            this.jobidDataGridViewTextBoxColumn.HeaderText = "job_id";
            this.jobidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobidDataGridViewTextBoxColumn.Name = "jobidDataGridViewTextBoxColumn";
            this.jobidDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobidDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientidDataGridViewTextBoxColumn2
            // 
            this.clientidDataGridViewTextBoxColumn2.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn2.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn2.Name = "clientidDataGridViewTextBoxColumn2";
            this.clientidDataGridViewTextBoxColumn2.Width = 125;
            // 
            // serviceidDataGridViewTextBoxColumn
            // 
            this.serviceidDataGridViewTextBoxColumn.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceidDataGridViewTextBoxColumn.Name = "serviceidDataGridViewTextBoxColumn";
            this.serviceidDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicetitleDataGridViewTextBoxColumn
            // 
            this.servicetitleDataGridViewTextBoxColumn.DataPropertyName = "service_title";
            this.servicetitleDataGridViewTextBoxColumn.HeaderText = "service_title";
            this.servicetitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicetitleDataGridViewTextBoxColumn.Name = "servicetitleDataGridViewTextBoxColumn";
            this.servicetitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // timebeginDataGridViewTextBoxColumn
            // 
            this.timebeginDataGridViewTextBoxColumn.DataPropertyName = "time_begin";
            this.timebeginDataGridViewTextBoxColumn.HeaderText = "time_begin";
            this.timebeginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timebeginDataGridViewTextBoxColumn.Name = "timebeginDataGridViewTextBoxColumn";
            this.timebeginDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeendDataGridViewTextBoxColumn
            // 
            this.timeendDataGridViewTextBoxColumn.DataPropertyName = "time_end";
            this.timeendDataGridViewTextBoxColumn.HeaderText = "time_end";
            this.timeendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeendDataGridViewTextBoxColumn.Name = "timeendDataGridViewTextBoxColumn";
            this.timeendDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // getClientJobsBindingSource
            // 
            this.getClientJobsBindingSource.DataMember = "GetClientJobs";
            this.getClientJobsBindingSource.DataSource = this.pSSDataSet;
            // 
            // clientID_txt
            // 
            this.clientID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientID_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_txt.Location = new System.Drawing.Point(18, 187);
            this.clientID_txt.Name = "clientID_txt";
            this.clientID_txt.Size = new System.Drawing.Size(177, 29);
            this.clientID_txt.TabIndex = 15;
            this.clientID_txt.Tag = "";
            // 
            // clientID_lbl
            // 
            this.clientID_lbl.AutoSize = true;
            this.clientID_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.clientID_lbl.Location = new System.Drawing.Point(14, 163);
            this.clientID_lbl.Name = "clientID_lbl";
            this.clientID_lbl.Size = new System.Drawing.Size(69, 21);
            this.clientID_lbl.TabIndex = 14;
            this.clientID_lbl.Text = "Client ID";
            // 
            // clientContactDetail_txt
            // 
            this.clientContactDetail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientContactDetail_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContactDetail_txt.Location = new System.Drawing.Point(18, 259);
            this.clientContactDetail_txt.Name = "clientContactDetail_txt";
            this.clientContactDetail_txt.Size = new System.Drawing.Size(177, 29);
            this.clientContactDetail_txt.TabIndex = 17;
            this.clientContactDetail_txt.Tag = "";
            // 
            // clientContactDetail_lbl
            // 
            this.clientContactDetail_lbl.AutoSize = true;
            this.clientContactDetail_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContactDetail_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.clientContactDetail_lbl.Location = new System.Drawing.Point(14, 235);
            this.clientContactDetail_lbl.Name = "clientContactDetail_lbl";
            this.clientContactDetail_lbl.Size = new System.Drawing.Size(114, 21);
            this.clientContactDetail_lbl.TabIndex = 16;
            this.clientContactDetail_lbl.Text = "Contact Details";
            // 
            // clientContract_txt
            // 
            this.clientContract_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientContract_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContract_txt.Location = new System.Drawing.Point(18, 338);
            this.clientContract_txt.Name = "clientContract_txt";
            this.clientContract_txt.Size = new System.Drawing.Size(177, 29);
            this.clientContract_txt.TabIndex = 19;
            this.clientContract_txt.Tag = "";
            // 
            // clientContract_lbl
            // 
            this.clientContract_lbl.AutoSize = true;
            this.clientContract_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContract_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.clientContract_lbl.Location = new System.Drawing.Point(14, 314);
            this.clientContract_lbl.Name = "clientContract_lbl";
            this.clientContract_lbl.Size = new System.Drawing.Size(69, 21);
            this.clientContract_lbl.TabIndex = 18;
            this.clientContract_lbl.Text = "Contract";
            // 
            // Filter_btn
            // 
            this.Filter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.Filter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Filter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter_btn.FlatAppearance.BorderSize = 0;
            this.Filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_btn.Location = new System.Drawing.Point(20, 389);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(175, 36);
            this.Filter_btn.TabIndex = 20;
            this.Filter_btn.Text = "Filter";
            this.Filter_btn.UseVisualStyleBackColor = false;
            // 
            // client_lbl
            // 
            this.client_lbl.AutoSize = true;
            this.client_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_lbl.Location = new System.Drawing.Point(15, 127);
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.Size = new System.Drawing.Size(81, 30);
            this.client_lbl.TabIndex = 21;
            this.client_lbl.Text = "Clients ";
            // 
            // getClientJobsTableAdapter
            // 
            this.getClientJobsTableAdapter.ClearBeforeFill = true;
            // 
            // getClientDetailsTableAdapter
            // 
            this.getClientDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // getClientAndContractInfoTableAdapter
            // 
            this.getClientAndContractInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ClientManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.client_lbl);
            this.Controls.Add(this.Filter_btn);
            this.Controls.Add(this.clientContract_txt);
            this.Controls.Add(this.clientContract_lbl);
            this.Controls.Add(this.clientContactDetail_txt);
            this.Controls.Add(this.clientContactDetail_lbl);
            this.Controls.Add(this.clientID_txt);
            this.Controls.Add(this.clientID_lbl);
            this.Controls.Add(this.Clients_tbc);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Logo_img);
            this.Controls.Add(this.WelcomeClientManager_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Manager";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.Clients_tbc.ResumeLayout(false);
            this.Clients_tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSSDataSet)).EndInit();
            this.clientContract_tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientContract_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientAndContractInfoBindingSource)).EndInit();
            this.clientJobs_tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientJobs_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientJobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.Label WelcomeClientManager_lbl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.TabControl Clients_tbc;
        private System.Windows.Forms.TabPage Clients_tbp;
        private System.Windows.Forms.TabPage clientContract_tbp;
        private System.Windows.Forms.TextBox clientID_txt;
        private System.Windows.Forms.Label clientID_lbl;
        private System.Windows.Forms.TextBox clientContactDetail_txt;
        private System.Windows.Forms.Label clientContactDetail_lbl;
        private System.Windows.Forms.TextBox clientContract_txt;
        private System.Windows.Forms.Label clientContract_lbl;
        private System.Windows.Forms.Button Filter_btn;
        private System.Windows.Forms.Label client_lbl;
        private System.Windows.Forms.TabPage clientJobs_tbp;
        private System.Windows.Forms.DataGridView clientDetail_dgv;
        private System.Windows.Forms.DataGridView clientContract_dgv;
        private System.Windows.Forms.DataGridView clientJobs_dgv;
        private PSSDataSetTableAdapters.GetClientJobsTableAdapter getClientJobsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getClientDetailsBindingSource;
        private PSSDataSet pSSDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getClientAndContractInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timebeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getClientJobsBindingSource;
        private PSSDataSetTableAdapters.GetClientDetailsTableAdapter getClientDetailsTableAdapter;
        private PSSDataSetTableAdapters.GetClientAndContractInfoTableAdapter getClientAndContractInfoTableAdapter;
    }
}