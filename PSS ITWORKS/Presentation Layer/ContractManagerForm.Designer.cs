﻿namespace PSS_ITWORKS.Presentation_Layer
{
    partial class ContractManagerForm
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
            this.ContractManagement_tc = new System.Windows.Forms.TabControl();
            this.ContractPerformance_tp = new System.Windows.Forms.TabPage();
            this.ContractPerformancePastYear_gbx = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.JobCanceledPastYear_lbl = new System.Windows.Forms.Label();
            this.JobDonePastYear_lbl = new System.Windows.Forms.Label();
            this.ClientCountPastYear_txt = new System.Windows.Forms.TextBox();
            this.ClientCountPastYear_lbl = new System.Windows.Forms.Label();
            this.ContractTypePastMonth_cbx = new System.Windows.Forms.ComboBox();
            this.ContractTypePastYear_lbl = new System.Windows.Forms.Label();
            this.ContractPerformancePastMonth_gbx = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.JobsCanceledPastMonth_lbl = new System.Windows.Forms.Label();
            this.JobsDonePastMonth_lbl = new System.Windows.Forms.Label();
            this.ClientCount_txt = new System.Windows.Forms.TextBox();
            this.ClientCount_lbl = new System.Windows.Forms.Label();
            this.ContractType_cbx = new System.Windows.Forms.ComboBox();
            this.ContractTypePastMonth_lbl = new System.Windows.Forms.Label();
            this.ServiceConfiguration_tp = new System.Windows.Forms.TabPage();
            this.Unvailable_btn = new System.Windows.Forms.Button();
            this.Available_btn = new System.Windows.Forms.Button();
            this.CreateService_btn = new System.Windows.Forms.Button();
            this.UpdateService_btn = new System.Windows.Forms.Button();
            this.Details_gbx = new System.Windows.Forms.GroupBox();
            this.Priority_txt = new System.Windows.Forms.TextBox();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.Duration_txt = new System.Windows.Forms.TextBox();
            this.Duration_lbl = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Category_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Category_cbx = new System.Windows.Forms.ComboBox();
            this.Services_dgv = new System.Windows.Forms.DataGridView();
            this.Services_lbl = new System.Windows.Forms.Label();
            this.ContractCount_txt = new System.Windows.Forms.TextBox();
            this.ContractCount_lbl = new System.Windows.Forms.Label();
            this.ServiceType_cbx = new System.Windows.Forms.ComboBox();
            this.ServiceType_lbl = new System.Windows.Forms.Label();
            this.ServiceAvailability_lbl = new System.Windows.Forms.Label();
            this.ContractConfiguration_tp = new System.Windows.Forms.TabPage();
            this.Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.ContractManagement_tc.SuspendLayout();
            this.ContractPerformance_tp.SuspendLayout();
            this.ContractPerformancePastYear_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.ContractPerformancePastMonth_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ServiceConfiguration_tp.SuspendLayout();
            this.Details_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_pnl
            // 
            this.Header_pnl.AutoSize = true;
            this.Header_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Header_pnl.Controls.Add(this.Logout_btn);
            this.Header_pnl.Controls.Add(this.PSS_lbl);
            this.Header_pnl.Controls.Add(this.PSS_img);
            this.Header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(923, 72);
            this.Header_pnl.TabIndex = 0;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(749, 26);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(118, 36);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // PSS_lbl
            // 
            this.PSS_lbl.AutoSize = true;
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.ForeColor = System.Drawing.Color.Black;
            this.PSS_lbl.Location = new System.Drawing.Point(94, 26);
            this.PSS_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(170, 32);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back";
            // 
            // PSS_img
            // 
            this.PSS_img.Location = new System.Drawing.Point(12, 9);
            this.PSS_img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSS_img.Name = "PSS_img";
            this.PSS_img.Size = new System.Drawing.Size(76, 61);
            this.PSS_img.TabIndex = 0;
            this.PSS_img.TabStop = false;
            // 
            // ContractManagement_tc
            // 
            this.ContractManagement_tc.Controls.Add(this.ContractPerformance_tp);
            this.ContractManagement_tc.Controls.Add(this.ServiceConfiguration_tp);
            this.ContractManagement_tc.Controls.Add(this.ContractConfiguration_tp);
            this.ContractManagement_tc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractManagement_tc.Location = new System.Drawing.Point(12, 100);
            this.ContractManagement_tc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractManagement_tc.Name = "ContractManagement_tc";
            this.ContractManagement_tc.SelectedIndex = 0;
            this.ContractManagement_tc.Size = new System.Drawing.Size(873, 456);
            this.ContractManagement_tc.TabIndex = 1;
            // 
            // ContractPerformance_tp
            // 
            this.ContractPerformance_tp.Controls.Add(this.ContractPerformancePastYear_gbx);
            this.ContractPerformance_tp.Controls.Add(this.ContractPerformancePastMonth_gbx);
            this.ContractPerformance_tp.Location = new System.Drawing.Point(4, 28);
            this.ContractPerformance_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractPerformance_tp.Name = "ContractPerformance_tp";
            this.ContractPerformance_tp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractPerformance_tp.Size = new System.Drawing.Size(865, 424);
            this.ContractPerformance_tp.TabIndex = 0;
            this.ContractPerformance_tp.Text = "Contract Performance";
            this.ContractPerformance_tp.UseVisualStyleBackColor = true;
            // 
            // ContractPerformancePastYear_gbx
            // 
            this.ContractPerformancePastYear_gbx.Controls.Add(this.dataGridView3);
            this.ContractPerformancePastYear_gbx.Controls.Add(this.dataGridView4);
            this.ContractPerformancePastYear_gbx.Controls.Add(this.JobCanceledPastYear_lbl);
            this.ContractPerformancePastYear_gbx.Controls.Add(this.JobDonePastYear_lbl);
            this.ContractPerformancePastYear_gbx.Controls.Add(this.ClientCountPastYear_txt);
            this.ContractPerformancePastYear_gbx.Controls.Add(this.ClientCountPastYear_lbl);
            this.ContractPerformancePastYear_gbx.Controls.Add(this.ContractTypePastMonth_cbx);
            this.ContractPerformancePastYear_gbx.Controls.Add(this.ContractTypePastYear_lbl);
            this.ContractPerformancePastYear_gbx.Location = new System.Drawing.Point(15, 213);
            this.ContractPerformancePastYear_gbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractPerformancePastYear_gbx.Name = "ContractPerformancePastYear_gbx";
            this.ContractPerformancePastYear_gbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractPerformancePastYear_gbx.Size = new System.Drawing.Size(837, 195);
            this.ContractPerformancePastYear_gbx.TabIndex = 8;
            this.ContractPerformancePastYear_gbx.TabStop = false;
            this.ContractPerformancePastYear_gbx.Text = "Contract Performance Past Year";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(537, 42);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(268, 134);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(236, 42);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(266, 134);
            this.dataGridView4.TabIndex = 6;
            // 
            // JobCanceledPastYear_lbl
            // 
            this.JobCanceledPastYear_lbl.AutoSize = true;
            this.JobCanceledPastYear_lbl.Location = new System.Drawing.Point(533, 19);
            this.JobCanceledPastYear_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JobCanceledPastYear_lbl.Name = "JobCanceledPastYear_lbl";
            this.JobCanceledPastYear_lbl.Size = new System.Drawing.Size(105, 20);
            this.JobCanceledPastYear_lbl.TabIndex = 5;
            this.JobCanceledPastYear_lbl.Text = "Jobs Canceled";
            // 
            // JobDonePastYear_lbl
            // 
            this.JobDonePastYear_lbl.AutoSize = true;
            this.JobDonePastYear_lbl.Location = new System.Drawing.Point(232, 20);
            this.JobDonePastYear_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JobDonePastYear_lbl.Name = "JobDonePastYear_lbl";
            this.JobDonePastYear_lbl.Size = new System.Drawing.Size(80, 20);
            this.JobDonePastYear_lbl.TabIndex = 4;
            this.JobDonePastYear_lbl.Text = "Jobs Done";
            // 
            // ClientCountPastYear_txt
            // 
            this.ClientCountPastYear_txt.Location = new System.Drawing.Point(14, 151);
            this.ClientCountPastYear_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientCountPastYear_txt.Name = "ClientCountPastYear_txt";
            this.ClientCountPastYear_txt.Size = new System.Drawing.Size(158, 27);
            this.ClientCountPastYear_txt.TabIndex = 3;
            // 
            // ClientCountPastYear_lbl
            // 
            this.ClientCountPastYear_lbl.AutoSize = true;
            this.ClientCountPastYear_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ClientCountPastYear_lbl.Location = new System.Drawing.Point(10, 119);
            this.ClientCountPastYear_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientCountPastYear_lbl.Name = "ClientCountPastYear_lbl";
            this.ClientCountPastYear_lbl.Size = new System.Drawing.Size(93, 20);
            this.ClientCountPastYear_lbl.TabIndex = 2;
            this.ClientCountPastYear_lbl.Text = "Client Count";
            // 
            // ContractTypePastMonth_cbx
            // 
            this.ContractTypePastMonth_cbx.FormattingEnabled = true;
            this.ContractTypePastMonth_cbx.Location = new System.Drawing.Point(14, 76);
            this.ContractTypePastMonth_cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractTypePastMonth_cbx.Name = "ContractTypePastMonth_cbx";
            this.ContractTypePastMonth_cbx.Size = new System.Drawing.Size(158, 27);
            this.ContractTypePastMonth_cbx.TabIndex = 1;
            // 
            // ContractTypePastYear_lbl
            // 
            this.ContractTypePastYear_lbl.AutoSize = true;
            this.ContractTypePastYear_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ContractTypePastYear_lbl.Location = new System.Drawing.Point(10, 42);
            this.ContractTypePastYear_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractTypePastYear_lbl.Name = "ContractTypePastYear_lbl";
            this.ContractTypePastYear_lbl.Size = new System.Drawing.Size(103, 20);
            this.ContractTypePastYear_lbl.TabIndex = 0;
            this.ContractTypePastYear_lbl.Text = "Contract Type";
            // 
            // ContractPerformancePastMonth_gbx
            // 
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.dataGridView2);
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.dataGridView1);
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.JobsCanceledPastMonth_lbl);
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.JobsDonePastMonth_lbl);
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.ClientCount_txt);
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.ClientCount_lbl);
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.ContractType_cbx);
            this.ContractPerformancePastMonth_gbx.Controls.Add(this.ContractTypePastMonth_lbl);
            this.ContractPerformancePastMonth_gbx.Location = new System.Drawing.Point(15, 16);
            this.ContractPerformancePastMonth_gbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractPerformancePastMonth_gbx.Name = "ContractPerformancePastMonth_gbx";
            this.ContractPerformancePastMonth_gbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractPerformancePastMonth_gbx.Size = new System.Drawing.Size(837, 192);
            this.ContractPerformancePastMonth_gbx.TabIndex = 0;
            this.ContractPerformancePastMonth_gbx.TabStop = false;
            this.ContractPerformancePastMonth_gbx.Text = "Contract Performance Past Month";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(537, 42);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(268, 128);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(266, 128);
            this.dataGridView1.TabIndex = 6;
            // 
            // JobsCanceledPastMonth_lbl
            // 
            this.JobsCanceledPastMonth_lbl.AutoSize = true;
            this.JobsCanceledPastMonth_lbl.Location = new System.Drawing.Point(533, 19);
            this.JobsCanceledPastMonth_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JobsCanceledPastMonth_lbl.Name = "JobsCanceledPastMonth_lbl";
            this.JobsCanceledPastMonth_lbl.Size = new System.Drawing.Size(105, 20);
            this.JobsCanceledPastMonth_lbl.TabIndex = 5;
            this.JobsCanceledPastMonth_lbl.Text = "Jobs Canceled";
            // 
            // JobsDonePastMonth_lbl
            // 
            this.JobsDonePastMonth_lbl.AutoSize = true;
            this.JobsDonePastMonth_lbl.Location = new System.Drawing.Point(232, 20);
            this.JobsDonePastMonth_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JobsDonePastMonth_lbl.Name = "JobsDonePastMonth_lbl";
            this.JobsDonePastMonth_lbl.Size = new System.Drawing.Size(80, 20);
            this.JobsDonePastMonth_lbl.TabIndex = 4;
            this.JobsDonePastMonth_lbl.Text = "Jobs Done";
            // 
            // ClientCount_txt
            // 
            this.ClientCount_txt.Location = new System.Drawing.Point(14, 145);
            this.ClientCount_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientCount_txt.Name = "ClientCount_txt";
            this.ClientCount_txt.Size = new System.Drawing.Size(158, 27);
            this.ClientCount_txt.TabIndex = 3;
            // 
            // ClientCount_lbl
            // 
            this.ClientCount_lbl.AutoSize = true;
            this.ClientCount_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ClientCount_lbl.Location = new System.Drawing.Point(10, 112);
            this.ClientCount_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientCount_lbl.Name = "ClientCount_lbl";
            this.ClientCount_lbl.Size = new System.Drawing.Size(93, 20);
            this.ClientCount_lbl.TabIndex = 2;
            this.ClientCount_lbl.Text = "Client Count";
            // 
            // ContractType_cbx
            // 
            this.ContractType_cbx.FormattingEnabled = true;
            this.ContractType_cbx.Location = new System.Drawing.Point(14, 75);
            this.ContractType_cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractType_cbx.Name = "ContractType_cbx";
            this.ContractType_cbx.Size = new System.Drawing.Size(158, 27);
            this.ContractType_cbx.TabIndex = 1;
            // 
            // ContractTypePastMonth_lbl
            // 
            this.ContractTypePastMonth_lbl.AutoSize = true;
            this.ContractTypePastMonth_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ContractTypePastMonth_lbl.Location = new System.Drawing.Point(10, 42);
            this.ContractTypePastMonth_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractTypePastMonth_lbl.Name = "ContractTypePastMonth_lbl";
            this.ContractTypePastMonth_lbl.Size = new System.Drawing.Size(103, 20);
            this.ContractTypePastMonth_lbl.TabIndex = 0;
            this.ContractTypePastMonth_lbl.Text = "Contract Type";
            // 
            // ServiceConfiguration_tp
            // 
            this.ServiceConfiguration_tp.Controls.Add(this.Unvailable_btn);
            this.ServiceConfiguration_tp.Controls.Add(this.Available_btn);
            this.ServiceConfiguration_tp.Controls.Add(this.CreateService_btn);
            this.ServiceConfiguration_tp.Controls.Add(this.UpdateService_btn);
            this.ServiceConfiguration_tp.Controls.Add(this.Details_gbx);
            this.ServiceConfiguration_tp.Controls.Add(this.Services_dgv);
            this.ServiceConfiguration_tp.Controls.Add(this.Services_lbl);
            this.ServiceConfiguration_tp.Controls.Add(this.ContractCount_txt);
            this.ServiceConfiguration_tp.Controls.Add(this.ContractCount_lbl);
            this.ServiceConfiguration_tp.Controls.Add(this.ServiceType_cbx);
            this.ServiceConfiguration_tp.Controls.Add(this.ServiceType_lbl);
            this.ServiceConfiguration_tp.Controls.Add(this.ServiceAvailability_lbl);
            this.ServiceConfiguration_tp.Location = new System.Drawing.Point(4, 28);
            this.ServiceConfiguration_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceConfiguration_tp.Name = "ServiceConfiguration_tp";
            this.ServiceConfiguration_tp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceConfiguration_tp.Size = new System.Drawing.Size(865, 424);
            this.ServiceConfiguration_tp.TabIndex = 1;
            this.ServiceConfiguration_tp.Text = "Service Configuration";
            this.ServiceConfiguration_tp.UseVisualStyleBackColor = true;
            // 
            // Unvailable_btn
            // 
            this.Unvailable_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Unvailable_btn.ForeColor = System.Drawing.Color.White;
            this.Unvailable_btn.Location = new System.Drawing.Point(20, 284);
            this.Unvailable_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Unvailable_btn.Name = "Unvailable_btn";
            this.Unvailable_btn.Size = new System.Drawing.Size(158, 35);
            this.Unvailable_btn.TabIndex = 11;
            this.Unvailable_btn.Text = "Unvailable";
            this.Unvailable_btn.UseVisualStyleBackColor = false;
            // 
            // Available_btn
            // 
            this.Available_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Available_btn.ForeColor = System.Drawing.Color.White;
            this.Available_btn.Location = new System.Drawing.Point(20, 231);
            this.Available_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Available_btn.Name = "Available_btn";
            this.Available_btn.Size = new System.Drawing.Size(158, 35);
            this.Available_btn.TabIndex = 10;
            this.Available_btn.Text = "Available";
            this.Available_btn.UseVisualStyleBackColor = false;
            // 
            // CreateService_btn
            // 
            this.CreateService_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CreateService_btn.ForeColor = System.Drawing.Color.White;
            this.CreateService_btn.Location = new System.Drawing.Point(229, 371);
            this.CreateService_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateService_btn.Name = "CreateService_btn";
            this.CreateService_btn.Size = new System.Drawing.Size(158, 35);
            this.CreateService_btn.TabIndex = 9;
            this.CreateService_btn.Text = "Create Service";
            this.CreateService_btn.UseVisualStyleBackColor = false;
            // 
            // UpdateService_btn
            // 
            this.UpdateService_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UpdateService_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateService_btn.Location = new System.Drawing.Point(20, 371);
            this.UpdateService_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateService_btn.Name = "UpdateService_btn";
            this.UpdateService_btn.Size = new System.Drawing.Size(158, 35);
            this.UpdateService_btn.TabIndex = 8;
            this.UpdateService_btn.Text = "Update Service";
            this.UpdateService_btn.UseVisualStyleBackColor = false;
            // 
            // Details_gbx
            // 
            this.Details_gbx.Controls.Add(this.Priority_txt);
            this.Details_gbx.Controls.Add(this.Priority_lbl);
            this.Details_gbx.Controls.Add(this.Duration_txt);
            this.Details_gbx.Controls.Add(this.Duration_lbl);
            this.Details_gbx.Controls.Add(this.Price_txt);
            this.Details_gbx.Controls.Add(this.Category_lbl);
            this.Details_gbx.Controls.Add(this.Price_lbl);
            this.Details_gbx.Controls.Add(this.Category_cbx);
            this.Details_gbx.Location = new System.Drawing.Point(650, 21);
            this.Details_gbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Details_gbx.Name = "Details_gbx";
            this.Details_gbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Details_gbx.Size = new System.Drawing.Size(202, 385);
            this.Details_gbx.TabIndex = 7;
            this.Details_gbx.TabStop = false;
            this.Details_gbx.Text = "Details";
            // 
            // Priority_txt
            // 
            this.Priority_txt.Location = new System.Drawing.Point(20, 311);
            this.Priority_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Priority_txt.Name = "Priority_txt";
            this.Priority_txt.Size = new System.Drawing.Size(158, 27);
            this.Priority_txt.TabIndex = 15;
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Priority_lbl.Location = new System.Drawing.Point(16, 278);
            this.Priority_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(60, 20);
            this.Priority_lbl.TabIndex = 14;
            this.Priority_lbl.Text = "Priority";
            // 
            // Duration_txt
            // 
            this.Duration_txt.Location = new System.Drawing.Point(20, 219);
            this.Duration_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Duration_txt.Name = "Duration_txt";
            this.Duration_txt.Size = new System.Drawing.Size(158, 27);
            this.Duration_txt.TabIndex = 13;
            // 
            // Duration_lbl
            // 
            this.Duration_lbl.AutoSize = true;
            this.Duration_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Duration_lbl.Location = new System.Drawing.Point(16, 186);
            this.Duration_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Duration_lbl.Name = "Duration_lbl";
            this.Duration_lbl.Size = new System.Drawing.Size(70, 20);
            this.Duration_lbl.TabIndex = 12;
            this.Duration_lbl.Text = "Duration";
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(20, 141);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(158, 27);
            this.Price_txt.TabIndex = 11;
            // 
            // Category_lbl
            // 
            this.Category_lbl.AutoSize = true;
            this.Category_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Category_lbl.Location = new System.Drawing.Point(16, 26);
            this.Category_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Category_lbl.Name = "Category_lbl";
            this.Category_lbl.Size = new System.Drawing.Size(72, 20);
            this.Category_lbl.TabIndex = 8;
            this.Category_lbl.Text = "Category";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Price_lbl.Location = new System.Drawing.Point(16, 106);
            this.Price_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(43, 20);
            this.Price_lbl.TabIndex = 10;
            this.Price_lbl.Text = "Price";
            // 
            // Category_cbx
            // 
            this.Category_cbx.FormattingEnabled = true;
            this.Category_cbx.Location = new System.Drawing.Point(20, 59);
            this.Category_cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Category_cbx.Name = "Category_cbx";
            this.Category_cbx.Size = new System.Drawing.Size(158, 27);
            this.Category_cbx.TabIndex = 9;
            // 
            // Services_dgv
            // 
            this.Services_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services_dgv.Location = new System.Drawing.Point(229, 47);
            this.Services_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Services_dgv.Name = "Services_dgv";
            this.Services_dgv.RowHeadersWidth = 51;
            this.Services_dgv.RowTemplate.Height = 24;
            this.Services_dgv.Size = new System.Drawing.Size(406, 297);
            this.Services_dgv.TabIndex = 6;
            // 
            // Services_lbl
            // 
            this.Services_lbl.AutoSize = true;
            this.Services_lbl.Location = new System.Drawing.Point(225, 12);
            this.Services_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Services_lbl.Name = "Services_lbl";
            this.Services_lbl.Size = new System.Drawing.Size(65, 20);
            this.Services_lbl.TabIndex = 5;
            this.Services_lbl.Text = "Services";
            // 
            // ContractCount_txt
            // 
            this.ContractCount_txt.Location = new System.Drawing.Point(20, 162);
            this.ContractCount_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractCount_txt.Name = "ContractCount_txt";
            this.ContractCount_txt.Size = new System.Drawing.Size(159, 27);
            this.ContractCount_txt.TabIndex = 4;
            // 
            // ContractCount_lbl
            // 
            this.ContractCount_lbl.AutoSize = true;
            this.ContractCount_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ContractCount_lbl.Location = new System.Drawing.Point(16, 128);
            this.ContractCount_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractCount_lbl.Name = "ContractCount_lbl";
            this.ContractCount_lbl.Size = new System.Drawing.Size(112, 20);
            this.ContractCount_lbl.TabIndex = 3;
            this.ContractCount_lbl.Text = "Contract Count";
            // 
            // ServiceType_cbx
            // 
            this.ServiceType_cbx.FormattingEnabled = true;
            this.ServiceType_cbx.Location = new System.Drawing.Point(20, 80);
            this.ServiceType_cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceType_cbx.Name = "ServiceType_cbx";
            this.ServiceType_cbx.Size = new System.Drawing.Size(159, 27);
            this.ServiceType_cbx.TabIndex = 2;
            // 
            // ServiceType_lbl
            // 
            this.ServiceType_lbl.AutoSize = true;
            this.ServiceType_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ServiceType_lbl.Location = new System.Drawing.Point(16, 47);
            this.ServiceType_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceType_lbl.Name = "ServiceType_lbl";
            this.ServiceType_lbl.Size = new System.Drawing.Size(95, 20);
            this.ServiceType_lbl.TabIndex = 1;
            this.ServiceType_lbl.Text = "Service Type";
            this.ServiceType_lbl.Click += new System.EventHandler(this.ServiceType_lbl_Click);
            // 
            // ServiceAvailability_lbl
            // 
            this.ServiceAvailability_lbl.AutoSize = true;
            this.ServiceAvailability_lbl.Location = new System.Drawing.Point(6, 12);
            this.ServiceAvailability_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceAvailability_lbl.Name = "ServiceAvailability_lbl";
            this.ServiceAvailability_lbl.Size = new System.Drawing.Size(139, 20);
            this.ServiceAvailability_lbl.TabIndex = 0;
            this.ServiceAvailability_lbl.Text = "Service Availability";
            // 
            // ContractConfiguration_tp
            // 
            this.ContractConfiguration_tp.Location = new System.Drawing.Point(4, 28);
            this.ContractConfiguration_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractConfiguration_tp.Name = "ContractConfiguration_tp";
            this.ContractConfiguration_tp.Size = new System.Drawing.Size(865, 424);
            this.ContractConfiguration_tp.TabIndex = 2;
            this.ContractConfiguration_tp.Text = "Contract Configuration";
            this.ContractConfiguration_tp.UseVisualStyleBackColor = true;
            // 
            // ContractManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.ContractManagement_tc);
            this.Controls.Add(this.Header_pnl);
            this.Name = "ContractManagerForm";
            this.Text = "ContractManagerForm";
            this.Load += new System.EventHandler(this.ContractManagerForm_Load);
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.ContractManagement_tc.ResumeLayout(false);
            this.ContractPerformance_tp.ResumeLayout(false);
            this.ContractPerformancePastYear_gbx.ResumeLayout(false);
            this.ContractPerformancePastYear_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ContractPerformancePastMonth_gbx.ResumeLayout(false);
            this.ContractPerformancePastMonth_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ServiceConfiguration_tp.ResumeLayout(false);
            this.ServiceConfiguration_tp.PerformLayout();
            this.Details_gbx.ResumeLayout(false);
            this.Details_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.TabControl ContractManagement_tc;
        private System.Windows.Forms.TabPage ContractPerformance_tp;
        private System.Windows.Forms.TabPage ServiceConfiguration_tp;
        private System.Windows.Forms.TabPage ContractConfiguration_tp;
        private System.Windows.Forms.GroupBox ContractPerformancePastYear_gbx;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label JobCanceledPastYear_lbl;
        private System.Windows.Forms.Label JobDonePastYear_lbl;
        private System.Windows.Forms.TextBox ClientCountPastYear_txt;
        private System.Windows.Forms.Label ClientCountPastYear_lbl;
        private System.Windows.Forms.ComboBox ContractTypePastMonth_cbx;
        private System.Windows.Forms.Label ContractTypePastYear_lbl;
        private System.Windows.Forms.GroupBox ContractPerformancePastMonth_gbx;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label JobsCanceledPastMonth_lbl;
        private System.Windows.Forms.Label JobsDonePastMonth_lbl;
        private System.Windows.Forms.TextBox ClientCount_txt;
        private System.Windows.Forms.Label ClientCount_lbl;
        private System.Windows.Forms.ComboBox ContractType_cbx;
        private System.Windows.Forms.Label ContractTypePastMonth_lbl;
        private System.Windows.Forms.Label ContractCount_lbl;
        private System.Windows.Forms.ComboBox ServiceType_cbx;
        private System.Windows.Forms.Label ServiceType_lbl;
        private System.Windows.Forms.Label ServiceAvailability_lbl;
        private System.Windows.Forms.Button Unvailable_btn;
        private System.Windows.Forms.Button Available_btn;
        private System.Windows.Forms.Button CreateService_btn;
        private System.Windows.Forms.Button UpdateService_btn;
        private System.Windows.Forms.GroupBox Details_gbx;
        private System.Windows.Forms.TextBox Priority_txt;
        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.TextBox Duration_txt;
        private System.Windows.Forms.Label Duration_lbl;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.Label Category_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.ComboBox Category_cbx;
        private System.Windows.Forms.DataGridView Services_dgv;
        private System.Windows.Forms.Label Services_lbl;
        private System.Windows.Forms.TextBox ContractCount_txt;
    }
}