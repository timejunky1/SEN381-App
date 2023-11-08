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
            this.Header_pnl.SuspendLayout();
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
            this.Header_pnl.Controls.Add(this.Logout_btn);
            this.Header_pnl.Controls.Add(this.PSS_lbl);
            this.Header_pnl.Controls.Add(this.PSS_img);
            this.Header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(1231, 89);
            this.Header_pnl.TabIndex = 0;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(999, 32);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(157, 44);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // PSS_lbl
            // 
            this.PSS_lbl.AutoSize = true;
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.ForeColor = System.Drawing.Color.Black;
            this.PSS_lbl.Location = new System.Drawing.Point(125, 32);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(212, 41);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back";
            // 
            // PSS_img
            // 
            this.PSS_img.Location = new System.Drawing.Point(16, 11);
            this.PSS_img.Name = "PSS_img";
            this.PSS_img.Size = new System.Drawing.Size(101, 75);
            this.PSS_img.TabIndex = 0;
            this.PSS_img.TabStop = false;
            // 
            // CallEmployee_tc
            // 
            this.CallEmployee_tc.Controls.Add(this.Dashboard_tp);
            this.CallEmployee_tc.Controls.Add(this.ServiceRequest_tp);
            this.CallEmployee_tc.Controls.Add(this.Client_tp);
            this.CallEmployee_tc.Controls.Add(this.History_tbp);
            this.CallEmployee_tc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallEmployee_tc.Location = new System.Drawing.Point(16, 123);
            this.CallEmployee_tc.Name = "CallEmployee_tc";
            this.CallEmployee_tc.SelectedIndex = 0;
            this.CallEmployee_tc.Size = new System.Drawing.Size(1164, 561);
            this.CallEmployee_tc.TabIndex = 1;
            // 
            // Dashboard_tp
            // 
            this.Dashboard_tp.Controls.Add(this.Dashboard_dgv);
            this.Dashboard_tp.Controls.Add(this.PastJobRequest_lbl);
            this.Dashboard_tp.Controls.Add(this.MaintananceOverview_lbl);
            this.Dashboard_tp.Location = new System.Drawing.Point(4, 34);
            this.Dashboard_tp.Name = "Dashboard_tp";
            this.Dashboard_tp.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard_tp.Size = new System.Drawing.Size(1156, 523);
            this.Dashboard_tp.TabIndex = 0;
            this.Dashboard_tp.Text = "Dashboard";
            this.Dashboard_tp.UseVisualStyleBackColor = true;
            // 
            // Dashboard_dgv
            // 
            this.Dashboard_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dashboard_dgv.Location = new System.Drawing.Point(29, 92);
            this.Dashboard_dgv.Name = "Dashboard_dgv";
            this.Dashboard_dgv.RowHeadersWidth = 51;
            this.Dashboard_dgv.RowTemplate.Height = 24;
            this.Dashboard_dgv.Size = new System.Drawing.Size(1107, 413);
            this.Dashboard_dgv.TabIndex = 2;
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
            // ServiceRequest_tp
            // 
            this.ServiceRequest_tp.Controls.Add(this.NewServiceClientName_lbl);
            this.ServiceRequest_tp.Controls.Add(this.NewServiceClientName_txt);
            this.ServiceRequest_tp.Controls.Add(this.PastRequests_dgv);
            this.ServiceRequest_tp.Controls.Add(this.PastRequests_lbl);
            this.ServiceRequest_tp.Controls.Add(this.NewServiceRequest_btn);
            this.ServiceRequest_tp.Controls.Add(this.ServiceRequest_lbl);
            this.ServiceRequest_tp.Location = new System.Drawing.Point(4, 34);
            this.ServiceRequest_tp.Name = "ServiceRequest_tp";
            this.ServiceRequest_tp.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceRequest_tp.Size = new System.Drawing.Size(1156, 523);
            this.ServiceRequest_tp.TabIndex = 1;
            this.ServiceRequest_tp.Text = "Service Request";
            this.ServiceRequest_tp.UseVisualStyleBackColor = true;
            // 
            // NewServiceClientName_lbl
            // 
            this.NewServiceClientName_lbl.AutoSize = true;
            this.NewServiceClientName_lbl.ForeColor = System.Drawing.Color.Blue;
            this.NewServiceClientName_lbl.Location = new System.Drawing.Point(43, 41);
            this.NewServiceClientName_lbl.Name = "NewServiceClientName_lbl";
            this.NewServiceClientName_lbl.Size = new System.Drawing.Size(112, 25);
            this.NewServiceClientName_lbl.TabIndex = 5;
            this.NewServiceClientName_lbl.Text = "Client Name";
            // 
            // NewServiceClientName_txt
            // 
            this.NewServiceClientName_txt.Location = new System.Drawing.Point(48, 78);
            this.NewServiceClientName_txt.Name = "NewServiceClientName_txt";
            this.NewServiceClientName_txt.Size = new System.Drawing.Size(187, 32);
            this.NewServiceClientName_txt.TabIndex = 4;
            this.NewServiceClientName_txt.TextChanged += new System.EventHandler(this.NewServiceClientName_txt_TextChanged);
            // 
            // PastRequests_dgv
            // 
            this.PastRequests_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastRequests_dgv.Location = new System.Drawing.Point(27, 151);
            this.PastRequests_dgv.Name = "PastRequests_dgv";
            this.PastRequests_dgv.RowHeadersWidth = 51;
            this.PastRequests_dgv.RowTemplate.Height = 24;
            this.PastRequests_dgv.Size = new System.Drawing.Size(1109, 347);
            this.PastRequests_dgv.TabIndex = 3;
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
            // NewServiceRequest_btn
            // 
            this.NewServiceRequest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NewServiceRequest_btn.Location = new System.Drawing.Point(391, 67);
            this.NewServiceRequest_btn.Name = "NewServiceRequest_btn";
            this.NewServiceRequest_btn.Size = new System.Drawing.Size(211, 43);
            this.NewServiceRequest_btn.TabIndex = 1;
            this.NewServiceRequest_btn.Text = "New Service Request";
            this.NewServiceRequest_btn.UseVisualStyleBackColor = false;
            this.NewServiceRequest_btn.Click += new System.EventHandler(this.NewServiceRequest_btn_Click);
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
            // Client_tp
            // 
            this.Client_tp.Controls.Add(this.ContractDetailsOverview_gbx);
            this.Client_tp.Controls.Add(this.SearchClient_btn);
            this.Client_tp.Controls.Add(this.ClientName_txt);
            this.Client_tp.Controls.Add(this.ClientName_lbl);
            this.Client_tp.Controls.Add(this.SearchClient_lbl);
            this.Client_tp.Location = new System.Drawing.Point(4, 34);
            this.Client_tp.Name = "Client_tp";
            this.Client_tp.Size = new System.Drawing.Size(1156, 523);
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
            this.ContractDetailsOverview_gbx.Location = new System.Drawing.Point(20, 144);
            this.ContractDetailsOverview_gbx.Name = "ContractDetailsOverview_gbx";
            this.ContractDetailsOverview_gbx.Size = new System.Drawing.Size(1116, 376);
            this.ContractDetailsOverview_gbx.TabIndex = 6;
            this.ContractDetailsOverview_gbx.TabStop = false;
            this.ContractDetailsOverview_gbx.Text = "Contract Details Overview";
            // 
            // ContractOverview_dgv
            // 
            this.ContractOverview_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractOverview_dgv.Location = new System.Drawing.Point(41, 32);
            this.ContractOverview_dgv.Name = "ContractOverview_dgv";
            this.ContractOverview_dgv.RowHeadersWidth = 51;
            this.ContractOverview_dgv.RowTemplate.Height = 24;
            this.ContractOverview_dgv.Size = new System.Drawing.Size(1039, 241);
            this.ContractOverview_dgv.TabIndex = 6;
            // 
            // ExperationDate_txt
            // 
            this.ExperationDate_txt.Location = new System.Drawing.Point(826, 318);
            this.ExperationDate_txt.Name = "ExperationDate_txt";
            this.ExperationDate_txt.Size = new System.Drawing.Size(209, 32);
            this.ExperationDate_txt.TabIndex = 5;
            // 
            // ExperationDate_lbl
            // 
            this.ExperationDate_lbl.AutoSize = true;
            this.ExperationDate_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ExperationDate_lbl.Location = new System.Drawing.Point(821, 276);
            this.ExperationDate_lbl.Name = "ExperationDate_lbl";
            this.ExperationDate_lbl.Size = new System.Drawing.Size(140, 25);
            this.ExperationDate_lbl.TabIndex = 4;
            this.ExperationDate_lbl.Text = "Experation Date";
            this.ExperationDate_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Priority_txt
            // 
            this.Priority_txt.Location = new System.Drawing.Point(57, 321);
            this.Priority_txt.Name = "Priority_txt";
            this.Priority_txt.Size = new System.Drawing.Size(209, 32);
            this.Priority_txt.TabIndex = 3;
            this.Priority_txt.TextChanged += new System.EventHandler(this.Title_txt_TextChanged);
            // 
            // ContractDuration_txt
            // 
            this.ContractDuration_txt.Location = new System.Drawing.Point(414, 316);
            this.ContractDuration_txt.Name = "ContractDuration_txt";
            this.ContractDuration_txt.Size = new System.Drawing.Size(209, 32);
            this.ContractDuration_txt.TabIndex = 1;
            // 
            // ContractDuration_lbl
            // 
            this.ContractDuration_lbl.AutoSize = true;
            this.ContractDuration_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ContractDuration_lbl.Location = new System.Drawing.Point(409, 276);
            this.ContractDuration_lbl.Name = "ContractDuration_lbl";
            this.ContractDuration_lbl.Size = new System.Drawing.Size(156, 25);
            this.ContractDuration_lbl.TabIndex = 0;
            this.ContractDuration_lbl.Text = "Contract Duration";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Priority_lbl.Location = new System.Drawing.Point(52, 276);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(72, 25);
            this.Priority_lbl.TabIndex = 2;
            this.Priority_lbl.Text = "Priority";
            // 
            // SearchClient_btn
            // 
            this.SearchClient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SearchClient_btn.ForeColor = System.Drawing.Color.Black;
            this.SearchClient_btn.Location = new System.Drawing.Point(434, 84);
            this.SearchClient_btn.Name = "SearchClient_btn";
            this.SearchClient_btn.Size = new System.Drawing.Size(211, 43);
            this.SearchClient_btn.TabIndex = 5;
            this.SearchClient_btn.Text = "Search";
            this.SearchClient_btn.UseVisualStyleBackColor = false;
            this.SearchClient_btn.Click += new System.EventHandler(this.SearchClient_btn_Click);
            // 
            // ClientName_txt
            // 
            this.ClientName_txt.Location = new System.Drawing.Point(43, 95);
            this.ClientName_txt.Name = "ClientName_txt";
            this.ClientName_txt.Size = new System.Drawing.Size(209, 32);
            this.ClientName_txt.TabIndex = 2;
            // 
            // ClientName_lbl
            // 
            this.ClientName_lbl.AutoSize = true;
            this.ClientName_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ClientName_lbl.Location = new System.Drawing.Point(47, 58);
            this.ClientName_lbl.Name = "ClientName_lbl";
            this.ClientName_lbl.Size = new System.Drawing.Size(112, 25);
            this.ClientName_lbl.TabIndex = 1;
            this.ClientName_lbl.Text = "Client Name";
            // 
            // SearchClient_lbl
            // 
            this.SearchClient_lbl.AutoSize = true;
            this.SearchClient_lbl.Location = new System.Drawing.Point(29, 19);
            this.SearchClient_lbl.Name = "SearchClient_lbl";
            this.SearchClient_lbl.Size = new System.Drawing.Size(116, 25);
            this.SearchClient_lbl.TabIndex = 0;
            this.SearchClient_lbl.Text = "Search Client";
            // 
            // History_tbp
            // 
            this.History_tbp.Controls.Add(this.Search_btn);
            this.History_tbp.Controls.Add(this.SearchClientName_txt);
            this.History_tbp.Controls.Add(this.SearchClientName_lbl);
            this.History_tbp.Controls.Add(this.PastServiceRequest_dgv);
            this.History_tbp.Controls.Add(this.PastServiceRequest_lbl);
            this.History_tbp.Location = new System.Drawing.Point(4, 34);
            this.History_tbp.Name = "History_tbp";
            this.History_tbp.Size = new System.Drawing.Size(1156, 523);
            this.History_tbp.TabIndex = 3;
            this.History_tbp.Text = "History";
            this.History_tbp.UseVisualStyleBackColor = true;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Search_btn.Location = new System.Drawing.Point(563, 26);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(211, 43);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // SearchClientName_txt
            // 
            this.SearchClientName_txt.Location = new System.Drawing.Point(262, 32);
            this.SearchClientName_txt.Name = "SearchClientName_txt";
            this.SearchClientName_txt.Size = new System.Drawing.Size(209, 32);
            this.SearchClientName_txt.TabIndex = 3;
            // 
            // SearchClientName_lbl
            // 
            this.SearchClientName_lbl.AutoSize = true;
            this.SearchClientName_lbl.Location = new System.Drawing.Point(28, 35);
            this.SearchClientName_lbl.Name = "SearchClientName_lbl";
            this.SearchClientName_lbl.Size = new System.Drawing.Size(112, 25);
            this.SearchClientName_lbl.TabIndex = 2;
            this.SearchClientName_lbl.Text = "Client Name";
            // 
            // PastServiceRequest_dgv
            // 
            this.PastServiceRequest_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastServiceRequest_dgv.Location = new System.Drawing.Point(17, 121);
            this.PastServiceRequest_dgv.Name = "PastServiceRequest_dgv";
            this.PastServiceRequest_dgv.RowHeadersWidth = 51;
            this.PastServiceRequest_dgv.RowTemplate.Height = 24;
            this.PastServiceRequest_dgv.Size = new System.Drawing.Size(1119, 386);
            this.PastServiceRequest_dgv.TabIndex = 1;
            // 
            // PastServiceRequest_lbl
            // 
            this.PastServiceRequest_lbl.AutoSize = true;
            this.PastServiceRequest_lbl.Location = new System.Drawing.Point(12, 93);
            this.PastServiceRequest_lbl.Name = "PastServiceRequest_lbl";
            this.PastServiceRequest_lbl.Size = new System.Drawing.Size(468, 25);
            this.PastServiceRequest_lbl.TabIndex = 0;
            this.PastServiceRequest_lbl.Text = "Past Service Request, Maintanance activities and invoices";
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 689);
            this.Controls.Add(this.CallEmployee_tc);
            this.Controls.Add(this.Header_pnl);
            this.Name = "CallForm";
            this.Text = "CallForm";
            this.Load += new System.EventHandler(this.CallForm_Load);
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
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
    }
}