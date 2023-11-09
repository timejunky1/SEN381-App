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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagerForm));
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.WelcomeClientManager_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Clients_tbc = new System.Windows.Forms.TabControl();
            this.Clients_tbp = new System.Windows.Forms.TabPage();
            this.clientDetail_dgv = new System.Windows.Forms.DataGridView();
            this.clientContract_tbp = new System.Windows.Forms.TabPage();
            this.clientContract_dgv = new System.Windows.Forms.DataGridView();
            this.clientJobs_tbp = new System.Windows.Forms.TabPage();
            this.clientJobs_dgv = new System.Windows.Forms.DataGridView();
            this.clientID_txt = new System.Windows.Forms.TextBox();
            this.clientID_lbl = new System.Windows.Forms.Label();
            this.clientContactDetail_txt = new System.Windows.Forms.TextBox();
            this.clientContactDetail_lbl = new System.Windows.Forms.Label();
            this.clientContract_txt = new System.Windows.Forms.TextBox();
            this.clientContract_lbl = new System.Windows.Forms.Label();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.client_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.Clients_tbc.SuspendLayout();
            this.Clients_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).BeginInit();
            this.clientContract_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientContract_dgv)).BeginInit();
            this.clientJobs_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientJobs_dgv)).BeginInit();
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
            this.clientDetail_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDetail_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDetail_dgv.Location = new System.Drawing.Point(2, 2);
            this.clientDetail_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.clientDetail_dgv.Name = "clientDetail_dgv";
            this.clientDetail_dgv.RowHeadersWidth = 51;
            this.clientDetail_dgv.RowTemplate.Height = 24;
            this.clientDetail_dgv.Size = new System.Drawing.Size(680, 413);
            this.clientDetail_dgv.TabIndex = 0;
            this.clientDetail_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDetail_dgv_CellContentClick);
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
            this.clientContract_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientContract_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientContract_dgv.Location = new System.Drawing.Point(2, 2);
            this.clientContract_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.clientContract_dgv.Name = "clientContract_dgv";
            this.clientContract_dgv.RowHeadersWidth = 51;
            this.clientContract_dgv.RowTemplate.Height = 24;
            this.clientContract_dgv.Size = new System.Drawing.Size(680, 413);
            this.clientContract_dgv.TabIndex = 1;
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
            this.clientJobs_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientJobs_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientJobs_dgv.Location = new System.Drawing.Point(2, 2);
            this.clientJobs_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.clientJobs_dgv.Name = "clientJobs_dgv";
            this.clientJobs_dgv.RowHeadersWidth = 51;
            this.clientJobs_dgv.RowTemplate.Height = 24;
            this.clientJobs_dgv.Size = new System.Drawing.Size(680, 413);
            this.clientJobs_dgv.TabIndex = 1;
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
            this.Filter_btn.Click += new System.EventHandler(this.Filter_btn_Click);
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
            this.Load += new System.EventHandler(this.ClientManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.Clients_tbc.ResumeLayout(false);
            this.Clients_tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDetail_dgv)).EndInit();
            this.clientContract_tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientContract_dgv)).EndInit();
            this.clientJobs_tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientJobs_dgv)).EndInit();
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
    }
}