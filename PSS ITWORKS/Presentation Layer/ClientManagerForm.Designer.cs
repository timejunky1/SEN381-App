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
            this.clientDetail_dgv = new System.Windows.Forms.DataGridView();
            this.getClientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientContract_tbp = new System.Windows.Forms.TabPage();
            this.clientContract_dgv = new System.Windows.Forms.DataGridView();
            this.getClientAndContractInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientJobs_tbp = new System.Windows.Forms.TabPage();
            this.clientJobs_dgv = new System.Windows.Forms.DataGridView();
            this.getClientJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientID_txt = new System.Windows.Forms.TextBox();
            this.clientID_lbl = new System.Windows.Forms.Label();
            this.clientContactDetail_txt = new System.Windows.Forms.TextBox();
            this.clientContactDetail_lbl = new System.Windows.Forms.Label();
            this.clientContract_txt = new System.Windows.Forms.TextBox();
            this.clientContract_lbl = new System.Windows.Forms.Label();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.client_lbl = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.Clients_tbc.SuspendLayout();
            this.Clients_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).BeginInit();
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
            this.WelcomeClientManager_lbl.Size = new System.Drawing.Size(530, 41);
            this.WelcomeClientManager_lbl.TabIndex = 10;
            this.WelcomeClientManager_lbl.Text = "Welcome back  (Client Manager name)";
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
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
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
            // clientDetail_dgv
            // 
            this.clientDetail_dgv.AutoGenerateColumns = false;
            this.clientDetail_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDetail_dgv.DataSource = this.getClientDetailsBindingSource;
            this.clientDetail_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDetail_dgv.Location = new System.Drawing.Point(3, 3);
            this.clientDetail_dgv.Name = "clientDetail_dgv";
            this.clientDetail_dgv.RowHeadersWidth = 51;
            this.clientDetail_dgv.RowTemplate.Height = 24;
            this.clientDetail_dgv.Size = new System.Drawing.Size(746, 362);
            this.clientDetail_dgv.TabIndex = 0;
            // 
            // getClientDetailsBindingSource
            // 
            this.getClientDetailsBindingSource.DataMember = "GetClientDetails";
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
            // clientContract_dgv
            // 
            this.clientContract_dgv.AutoGenerateColumns = false;
            this.clientContract_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientContract_dgv.DataSource = this.getClientAndContractInfoBindingSource;
            this.clientContract_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientContract_dgv.Location = new System.Drawing.Point(3, 3);
            this.clientContract_dgv.Name = "clientContract_dgv";
            this.clientContract_dgv.RowHeadersWidth = 51;
            this.clientContract_dgv.RowTemplate.Height = 24;
            this.clientContract_dgv.Size = new System.Drawing.Size(746, 362);
            this.clientContract_dgv.TabIndex = 1;
            // 
            // getClientAndContractInfoBindingSource
            // 
            this.getClientAndContractInfoBindingSource.DataMember = "GetClientAndContractInfo";
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
            // clientJobs_dgv
            // 
            this.clientJobs_dgv.AutoGenerateColumns = false;
            this.clientJobs_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientJobs_dgv.DataSource = this.getClientJobsBindingSource;
            this.clientJobs_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientJobs_dgv.Location = new System.Drawing.Point(3, 3);
            this.clientJobs_dgv.Name = "clientJobs_dgv";
            this.clientJobs_dgv.RowHeadersWidth = 51;
            this.clientJobs_dgv.RowTemplate.Height = 24;
            this.clientJobs_dgv.Size = new System.Drawing.Size(746, 362);
            this.clientJobs_dgv.TabIndex = 1;
            // 
            // getClientJobsBindingSource
            // 
            this.getClientJobsBindingSource.DataMember = "GetClientJobs";
            // 
            // clientID_txt
            // 
            this.clientID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientID_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_txt.Location = new System.Drawing.Point(27, 197);
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
            this.clientID_lbl.Location = new System.Drawing.Point(20, 162);
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
            this.clientContactDetail_txt.Location = new System.Drawing.Point(28, 285);
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
            this.clientContactDetail_lbl.Location = new System.Drawing.Point(21, 250);
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
            this.clientContract_txt.Location = new System.Drawing.Point(29, 377);
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
            this.clientContract_lbl.Location = new System.Drawing.Point(22, 342);
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
            this.Filter_btn.Location = new System.Drawing.Point(25, 427);
            this.Filter_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(235, 44);
            this.Filter_btn.TabIndex = 20;
            this.Filter_btn.Text = "Filter";
            this.Filter_btn.UseVisualStyleBackColor = false;
            this.Filter_btn.Click += new System.EventHandler(this.Filter_btn_Click);
            // 
            // client_lbl
            // 
            this.client_lbl.AutoSize = true;
            this.client_lbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_lbl.Location = new System.Drawing.Point(20, 121);
            this.client_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.Size = new System.Drawing.Size(108, 38);
            this.client_lbl.TabIndex = 21;
            this.client_lbl.Text = "Clients ";
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_btn.FlatAppearance.BorderSize = 0;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(29, 483);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(235, 38);
            this.Clear_btn.TabIndex = 22;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // ClientManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Clear_btn);
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
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).EndInit();
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
   
        private System.Windows.Forms.Button Clear_btn;
    }
}