namespace PSS_ITWORKS.Presentation_Layer
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
            this.clientContract_tbp = new System.Windows.Forms.TabPage();
            this.clientID_txt = new System.Windows.Forms.TextBox();
            this.clientID_lbl = new System.Windows.Forms.Label();
            this.clientContactDetail_txt = new System.Windows.Forms.TextBox();
            this.clientContactDetail_lbl = new System.Windows.Forms.Label();
            this.clientContract_txt = new System.Windows.Forms.TextBox();
            this.clientContract_lbl = new System.Windows.Forms.Label();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.client_lbl = new System.Windows.Forms.Label();
            this.clientJobs_tbp = new System.Windows.Forms.TabPage();
            this.clientDetail_dgv = new System.Windows.Forms.DataGridView();
            this.clientContract_dgv = new System.Windows.Forms.DataGridView();
            this.clientJobs_dgv = new System.Windows.Forms.DataGridView();
            this.getClientJobsTableAdapter = new PSS_ITWORKS.PSSDataSetTableAdapters.GetClientJobsTableAdapter();
            this.pSSDataSet = new PSS_ITWORKS.PSSDataSet();
            this.getClientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientDetailsTableAdapter = new PSS_ITWORKS.PSSDataSetTableAdapters.GetClientDetailsTableAdapter();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientAndContractInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientAndContractInfoTableAdapter = new PSS_ITWORKS.PSSDataSetTableAdapters.GetClientAndContractInfoTableAdapter();
            this.clientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.Clients_tbc.SuspendLayout();
            this.Clients_tbp.SuspendLayout();
            this.clientContract_tbp.SuspendLayout();
            this.clientJobs_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientContract_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientJobs_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientAndContractInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientJobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo_img.BackgroundImage")));
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(13, 13);
            this.Logo_img.Margin = new System.Windows.Forms.Padding(4);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(101, 75);
            this.Logo_img.TabIndex = 11;
            this.Logo_img.TabStop = false;
            // 
            // WelcomeClientManager_lbl
            // 
            this.WelcomeClientManager_lbl.AutoSize = true;
            this.WelcomeClientManager_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeClientManager_lbl.ForeColor = System.Drawing.Color.Black;
            this.WelcomeClientManager_lbl.Location = new System.Drawing.Point(122, 25);
            this.WelcomeClientManager_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeClientManager_lbl.Name = "WelcomeClientManager_lbl";
            this.WelcomeClientManager_lbl.Size = new System.Drawing.Size(448, 41);
            this.WelcomeClientManager_lbl.TabIndex = 10;
            this.WelcomeClientManager_lbl.Text = "Welcome back  (Client Manager)";
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
            this.Logout_btn.TabIndex = 12;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // Clients_tbc
            // 
            this.Clients_tbc.Controls.Add(this.Clients_tbp);
            this.Clients_tbc.Controls.Add(this.clientContract_tbp);
            this.Clients_tbc.Controls.Add(this.clientJobs_tbp);
            this.Clients_tbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients_tbc.Location = new System.Drawing.Point(294, 121);
            this.Clients_tbc.Name = "Clients_tbc";
            this.Clients_tbc.SelectedIndex = 0;
            this.Clients_tbc.Size = new System.Drawing.Size(760, 406);
            this.Clients_tbc.TabIndex = 13;
            // 
            // Clients_tbp
            // 
            this.Clients_tbp.BackColor = System.Drawing.Color.Transparent;
            this.Clients_tbp.Controls.Add(this.clientDetail_dgv);
            this.Clients_tbp.Location = new System.Drawing.Point(4, 34);
            this.Clients_tbp.Name = "Clients_tbp";
            this.Clients_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.Clients_tbp.Size = new System.Drawing.Size(752, 368);
            this.Clients_tbp.TabIndex = 0;
            this.Clients_tbp.Text = "Clients";
            // 
            // clientContract_tbp
            // 
            this.clientContract_tbp.Controls.Add(this.clientContract_dgv);
            this.clientContract_tbp.Location = new System.Drawing.Point(4, 34);
            this.clientContract_tbp.Name = "clientContract_tbp";
            this.clientContract_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.clientContract_tbp.Size = new System.Drawing.Size(752, 368);
            this.clientContract_tbp.TabIndex = 1;
            this.clientContract_tbp.Text = "Client Contracts";
            this.clientContract_tbp.UseVisualStyleBackColor = true;
            // 
            // clientID_txt
            // 
            this.clientID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientID_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_txt.Location = new System.Drawing.Point(25, 236);
            this.clientID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.clientID_txt.Name = "clientID_txt";
            this.clientID_txt.Size = new System.Drawing.Size(235, 34);
            this.clientID_txt.TabIndex = 15;
            this.clientID_txt.Tag = "";
            // 
            // clientID_lbl
            // 
            this.clientID_lbl.AutoSize = true;
            this.clientID_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_lbl.Location = new System.Drawing.Point(18, 201);
            this.clientID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientID_lbl.Name = "clientID_lbl";
            this.clientID_lbl.Size = new System.Drawing.Size(86, 28);
            this.clientID_lbl.TabIndex = 14;
            this.clientID_lbl.Text = "Client ID";
            // 
            // clientContactDetail_txt
            // 
            this.clientContactDetail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientContactDetail_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContactDetail_txt.Location = new System.Drawing.Point(26, 324);
            this.clientContactDetail_txt.Margin = new System.Windows.Forms.Padding(4);
            this.clientContactDetail_txt.Name = "clientContactDetail_txt";
            this.clientContactDetail_txt.Size = new System.Drawing.Size(235, 34);
            this.clientContactDetail_txt.TabIndex = 17;
            this.clientContactDetail_txt.Tag = "";
            // 
            // clientContactDetail_lbl
            // 
            this.clientContactDetail_lbl.AutoSize = true;
            this.clientContactDetail_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContactDetail_lbl.Location = new System.Drawing.Point(19, 289);
            this.clientContactDetail_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientContactDetail_lbl.Name = "clientContactDetail_lbl";
            this.clientContactDetail_lbl.Size = new System.Drawing.Size(144, 28);
            this.clientContactDetail_lbl.TabIndex = 16;
            this.clientContactDetail_lbl.Text = "Contact Details";
            // 
            // clientContract_txt
            // 
            this.clientContract_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientContract_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContract_txt.Location = new System.Drawing.Point(27, 416);
            this.clientContract_txt.Margin = new System.Windows.Forms.Padding(4);
            this.clientContract_txt.Name = "clientContract_txt";
            this.clientContract_txt.Size = new System.Drawing.Size(235, 34);
            this.clientContract_txt.TabIndex = 19;
            this.clientContract_txt.Tag = "";
            // 
            // clientContract_lbl
            // 
            this.clientContract_lbl.AutoSize = true;
            this.clientContract_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContract_lbl.Location = new System.Drawing.Point(20, 381);
            this.clientContract_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientContract_lbl.Name = "clientContract_lbl";
            this.clientContract_lbl.Size = new System.Drawing.Size(87, 28);
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
            this.Filter_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_btn.Location = new System.Drawing.Point(27, 479);
            this.Filter_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(233, 44);
            this.Filter_btn.TabIndex = 20;
            this.Filter_btn.Text = "Filter";
            this.Filter_btn.UseVisualStyleBackColor = false;
            // 
            // client_lbl
            // 
            this.client_lbl.AutoSize = true;
            this.client_lbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_lbl.Location = new System.Drawing.Point(28, 146);
            this.client_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.Size = new System.Drawing.Size(108, 38);
            this.client_lbl.TabIndex = 21;
            this.client_lbl.Text = "Clients ";
            // 
            // clientJobs_tbp
            // 
            this.clientJobs_tbp.Controls.Add(this.clientJobs_dgv);
            this.clientJobs_tbp.Location = new System.Drawing.Point(4, 34);
            this.clientJobs_tbp.Name = "clientJobs_tbp";
            this.clientJobs_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.clientJobs_tbp.Size = new System.Drawing.Size(752, 368);
            this.clientJobs_tbp.TabIndex = 2;
            this.clientJobs_tbp.Text = "Clients & Jobs";
            this.clientJobs_tbp.UseVisualStyleBackColor = true;
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
            this.clientDetail_dgv.Location = new System.Drawing.Point(3, 3);
            this.clientDetail_dgv.Name = "clientDetail_dgv";
            this.clientDetail_dgv.RowHeadersWidth = 51;
            this.clientDetail_dgv.RowTemplate.Height = 24;
            this.clientDetail_dgv.Size = new System.Drawing.Size(746, 362);
            this.clientDetail_dgv.TabIndex = 0;
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
            this.clientContract_dgv.Location = new System.Drawing.Point(3, 3);
            this.clientContract_dgv.Name = "clientContract_dgv";
            this.clientContract_dgv.RowHeadersWidth = 51;
            this.clientContract_dgv.RowTemplate.Height = 24;
            this.clientContract_dgv.Size = new System.Drawing.Size(746, 362);
            this.clientContract_dgv.TabIndex = 1;
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
            this.clientJobs_dgv.Location = new System.Drawing.Point(3, 3);
            this.clientJobs_dgv.Name = "clientJobs_dgv";
            this.clientJobs_dgv.RowHeadersWidth = 51;
            this.clientJobs_dgv.RowTemplate.Height = 24;
            this.clientJobs_dgv.Size = new System.Drawing.Size(746, 362);
            this.clientJobs_dgv.TabIndex = 1;
            // 
            // getClientJobsTableAdapter
            // 
            this.getClientJobsTableAdapter.ClearBeforeFill = true;
            // 
            // pSSDataSet
            // 
            this.pSSDataSet.DataSetName = "PSSDataSet";
            this.pSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getClientDetailsBindingSource
            // 
            this.getClientDetailsBindingSource.DataMember = "GetClientDetails";
            this.getClientDetailsBindingSource.DataSource = this.pSSDataSet;
            // 
            // getClientDetailsTableAdapter
            // 
            this.getClientDetailsTableAdapter.ClearBeforeFill = true;
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
            // getClientAndContractInfoBindingSource
            // 
            this.getClientAndContractInfoBindingSource.DataMember = "GetClientAndContractInfo";
            this.getClientAndContractInfoBindingSource.DataSource = this.pSSDataSet;
            // 
            // getClientAndContractInfoTableAdapter
            // 
            this.getClientAndContractInfoTableAdapter.ClearBeforeFill = true;
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
            // getClientJobsBindingSource
            // 
            this.getClientJobsBindingSource.DataMember = "GetClientJobs";
            this.getClientJobsBindingSource.DataSource = this.pSSDataSet;
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
            // ClientManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Name = "ClientManagerForm";
            this.Text = "ClientManagerForm";
            this.Load += new System.EventHandler(this.ClientManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.Clients_tbc.ResumeLayout(false);
            this.Clients_tbp.ResumeLayout(false);
            this.clientContract_tbp.ResumeLayout(false);
            this.clientJobs_tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientContract_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientJobs_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientAndContractInfoBindingSource)).EndInit();
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