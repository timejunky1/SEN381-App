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
            this.CallEmployee_tc = new System.Windows.Forms.TabControl();
            this.Dashboard_tp = new System.Windows.Forms.TabPage();
            this.Dashboard_dgv = new System.Windows.Forms.DataGridView();
            this.PastJobRequest_lbl = new System.Windows.Forms.Label();
            this.MaintananceOverview_lbl = new System.Windows.Forms.Label();
            this.ServiceRequest_tp = new System.Windows.Forms.TabPage();
            this.PastRequests_dgv = new System.Windows.Forms.DataGridView();
            this.PastRequests_lbl = new System.Windows.Forms.Label();
            this.NewServiceRequest_btn = new System.Windows.Forms.Button();
            this.ServiceRequest_lbl = new System.Windows.Forms.Label();
            this.Client_tp = new System.Windows.Forms.TabPage();
            this.ContractDetailsOverview_gbx = new System.Windows.Forms.GroupBox();
            this.ProcedureDownload_btn = new System.Windows.Forms.Button();
            this.ProcedureView_btn = new System.Windows.Forms.Button();
            this.Procedure_lbl = new System.Windows.Forms.Label();
            this.CostDownload_btn = new System.Windows.Forms.Button();
            this.CostView_btn = new System.Windows.Forms.Button();
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.RenewalOptionsDownload_btn = new System.Windows.Forms.Button();
            this.RenewalOptionView_btn = new System.Windows.Forms.Button();
            this.RenewalOptions_lbl = new System.Windows.Forms.Label();
            this.ExperationDate_txt = new System.Windows.Forms.TextBox();
            this.ExperationDate_lbl = new System.Windows.Forms.Label();
            this.Coverage_txt = new System.Windows.Forms.TextBox();
            this.Coverage_lbl = new System.Windows.Forms.Label();
            this.ContractType_txt = new System.Windows.Forms.TextBox();
            this.ContractType_lbl = new System.Windows.Forms.Label();
            this.SearchClient_btn = new System.Windows.Forms.Button();
            this.ClientNumber_txt = new System.Windows.Forms.TextBox();
            this.ClientNumber_lbl = new System.Windows.Forms.Label();
            this.ClientName_txt = new System.Windows.Forms.TextBox();
            this.ClientName_lbl = new System.Windows.Forms.Label();
            this.SearchClient_lbl = new System.Windows.Forms.Label();
            this.History_tbp = new System.Windows.Forms.TabPage();
            this.Search_btn = new System.Windows.Forms.Button();
            this.ClientNameOrNumber_txt = new System.Windows.Forms.TextBox();
            this.ClientNameOrNumber_lbl = new System.Windows.Forms.Label();
            this.PastServiceRequest_dgv = new System.Windows.Forms.DataGridView();
            this.PastServiceRequest_lbl = new System.Windows.Forms.Label();
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Header_pnl = new System.Windows.Forms.Panel();
            this.CallEmployee_tc.SuspendLayout();
            this.Dashboard_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboard_dgv)).BeginInit();
            this.ServiceRequest_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastRequests_dgv)).BeginInit();
            this.Client_tp.SuspendLayout();
            this.ContractDetailsOverview_gbx.SuspendLayout();
            this.History_tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastServiceRequest_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.SuspendLayout();
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
            this.Dashboard_dgv.Size = new System.Drawing.Size(830, 336);
            this.Dashboard_dgv.TabIndex = 2;
            // 
            // PastJobRequest_lbl
            // 
            this.PastJobRequest_lbl.AutoSize = true;
            this.PastJobRequest_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastJobRequest_lbl.Location = new System.Drawing.Point(22, 41);
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
            // PastRequests_dgv
            // 
            this.PastRequests_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastRequests_dgv.Location = new System.Drawing.Point(20, 123);
            this.PastRequests_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.PastRequests_dgv.Name = "PastRequests_dgv";
            this.PastRequests_dgv.RowHeadersWidth = 51;
            this.PastRequests_dgv.RowTemplate.Height = 24;
            this.PastRequests_dgv.Size = new System.Drawing.Size(832, 282);
            this.PastRequests_dgv.TabIndex = 3;
            // 
            // PastRequests_lbl
            // 
            this.PastRequests_lbl.AutoSize = true;
            this.PastRequests_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastRequests_lbl.Location = new System.Drawing.Point(16, 88);
            this.PastRequests_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PastRequests_lbl.Name = "PastRequests_lbl";
            this.PastRequests_lbl.Size = new System.Drawing.Size(305, 25);
            this.PastRequests_lbl.TabIndex = 2;
            this.PastRequests_lbl.Text = "Past Requests, Status and Feedback";
            // 
            // NewServiceRequest_btn
            // 
            this.NewServiceRequest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.NewServiceRequest_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewServiceRequest_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewServiceRequest_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.NewServiceRequest_btn.FlatAppearance.BorderSize = 0;
            this.NewServiceRequest_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.NewServiceRequest_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.NewServiceRequest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewServiceRequest_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewServiceRequest_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewServiceRequest_btn.Location = new System.Drawing.Point(20, 44);
            this.NewServiceRequest_btn.Margin = new System.Windows.Forms.Padding(2);
            this.NewServiceRequest_btn.Name = "NewServiceRequest_btn";
            this.NewServiceRequest_btn.Size = new System.Drawing.Size(158, 35);
            this.NewServiceRequest_btn.TabIndex = 1;
            this.NewServiceRequest_btn.Text = "New Service Request";
            this.NewServiceRequest_btn.UseVisualStyleBackColor = false;
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
            this.Client_tp.Controls.Add(this.ClientNumber_txt);
            this.Client_tp.Controls.Add(this.ClientNumber_lbl);
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
            this.ContractDetailsOverview_gbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractDetailsOverview_gbx.Location = new System.Drawing.Point(15, 138);
            this.ContractDetailsOverview_gbx.Margin = new System.Windows.Forms.Padding(2);
            this.ContractDetailsOverview_gbx.Name = "ContractDetailsOverview_gbx";
            this.ContractDetailsOverview_gbx.Padding = new System.Windows.Forms.Padding(2);
            this.ContractDetailsOverview_gbx.Size = new System.Drawing.Size(837, 254);
            this.ContractDetailsOverview_gbx.TabIndex = 6;
            this.ContractDetailsOverview_gbx.TabStop = false;
            this.ContractDetailsOverview_gbx.Text = "Contract Details Overview";
            // 
            // ProcedureDownload_btn
            // 
            this.ProcedureDownload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.ProcedureDownload_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcedureDownload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcedureDownload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcedureDownload_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcedureDownload_btn.ForeColor = System.Drawing.Color.White;
            this.ProcedureDownload_btn.Location = new System.Drawing.Point(562, 205);
            this.ProcedureDownload_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ProcedureDownload_btn.Name = "ProcedureDownload_btn";
            this.ProcedureDownload_btn.Size = new System.Drawing.Size(158, 35);
            this.ProcedureDownload_btn.TabIndex = 14;
            this.ProcedureDownload_btn.Text = "Download";
            this.ProcedureDownload_btn.UseVisualStyleBackColor = false;
            // 
            // ProcedureView_btn
            // 
            this.ProcedureView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.ProcedureView_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcedureView_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcedureView_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.ProcedureView_btn.FlatAppearance.BorderSize = 0;
            this.ProcedureView_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.ProcedureView_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.ProcedureView_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcedureView_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcedureView_btn.Location = new System.Drawing.Point(362, 201);
            this.ProcedureView_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ProcedureView_btn.Name = "ProcedureView_btn";
            this.ProcedureView_btn.Size = new System.Drawing.Size(158, 35);
            this.ProcedureView_btn.TabIndex = 13;
            this.ProcedureView_btn.Text = "View";
            this.ProcedureView_btn.UseVisualStyleBackColor = false;
            // 
            // Procedure_lbl
            // 
            this.Procedure_lbl.AutoSize = true;
            this.Procedure_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procedure_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Procedure_lbl.Location = new System.Drawing.Point(357, 174);
            this.Procedure_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Procedure_lbl.Name = "Procedure_lbl";
            this.Procedure_lbl.Size = new System.Drawing.Size(99, 25);
            this.Procedure_lbl.TabIndex = 12;
            this.Procedure_lbl.Text = "Procedure";
            // 
            // CostDownload_btn
            // 
            this.CostDownload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.CostDownload_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CostDownload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CostDownload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CostDownload_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostDownload_btn.ForeColor = System.Drawing.Color.White;
            this.CostDownload_btn.Location = new System.Drawing.Point(562, 124);
            this.CostDownload_btn.Margin = new System.Windows.Forms.Padding(2);
            this.CostDownload_btn.Name = "CostDownload_btn";
            this.CostDownload_btn.Size = new System.Drawing.Size(158, 35);
            this.CostDownload_btn.TabIndex = 11;
            this.CostDownload_btn.Text = "Download";
            this.CostDownload_btn.UseVisualStyleBackColor = false;
            // 
            // CostView_btn
            // 
            this.CostView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.CostView_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CostView_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CostView_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.CostView_btn.FlatAppearance.BorderSize = 0;
            this.CostView_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.CostView_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.CostView_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CostView_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostView_btn.Location = new System.Drawing.Point(362, 124);
            this.CostView_btn.Margin = new System.Windows.Forms.Padding(2);
            this.CostView_btn.Name = "CostView_btn";
            this.CostView_btn.Size = new System.Drawing.Size(158, 35);
            this.CostView_btn.TabIndex = 10;
            this.CostView_btn.Text = "View";
            this.CostView_btn.UseVisualStyleBackColor = false;
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Cost_lbl.Location = new System.Drawing.Point(358, 97);
            this.Cost_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(50, 25);
            this.Cost_lbl.TabIndex = 9;
            this.Cost_lbl.Text = "Cost";
            // 
            // RenewalOptionsDownload_btn
            // 
            this.RenewalOptionsDownload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.RenewalOptionsDownload_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RenewalOptionsDownload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenewalOptionsDownload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenewalOptionsDownload_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewalOptionsDownload_btn.ForeColor = System.Drawing.Color.White;
            this.RenewalOptionsDownload_btn.Location = new System.Drawing.Point(562, 50);
            this.RenewalOptionsDownload_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RenewalOptionsDownload_btn.Name = "RenewalOptionsDownload_btn";
            this.RenewalOptionsDownload_btn.Size = new System.Drawing.Size(158, 35);
            this.RenewalOptionsDownload_btn.TabIndex = 8;
            this.RenewalOptionsDownload_btn.Text = "Download";
            this.RenewalOptionsDownload_btn.UseVisualStyleBackColor = false;
            // 
            // RenewalOptionView_btn
            // 
            this.RenewalOptionView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.RenewalOptionView_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RenewalOptionView_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenewalOptionView_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.RenewalOptionView_btn.FlatAppearance.BorderSize = 0;
            this.RenewalOptionView_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.RenewalOptionView_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.RenewalOptionView_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenewalOptionView_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewalOptionView_btn.Location = new System.Drawing.Point(362, 50);
            this.RenewalOptionView_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RenewalOptionView_btn.Name = "RenewalOptionView_btn";
            this.RenewalOptionView_btn.Size = new System.Drawing.Size(158, 35);
            this.RenewalOptionView_btn.TabIndex = 7;
            this.RenewalOptionView_btn.Text = "View";
            this.RenewalOptionView_btn.UseVisualStyleBackColor = false;
            // 
            // RenewalOptions_lbl
            // 
            this.RenewalOptions_lbl.AutoSize = true;
            this.RenewalOptions_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewalOptions_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.RenewalOptions_lbl.Location = new System.Drawing.Point(358, 23);
            this.RenewalOptions_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RenewalOptions_lbl.Name = "RenewalOptions_lbl";
            this.RenewalOptions_lbl.Size = new System.Drawing.Size(155, 25);
            this.RenewalOptions_lbl.TabIndex = 6;
            this.RenewalOptions_lbl.Text = "Renewal Options";
            // 
            // ExperationDate_txt
            // 
            this.ExperationDate_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExperationDate_txt.Location = new System.Drawing.Point(24, 197);
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
            this.ExperationDate_lbl.Location = new System.Drawing.Point(20, 174);
            this.ExperationDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExperationDate_lbl.Name = "ExperationDate_lbl";
            this.ExperationDate_lbl.Size = new System.Drawing.Size(119, 21);
            this.ExperationDate_lbl.TabIndex = 4;
            this.ExperationDate_lbl.Text = "Experation Date";
            this.ExperationDate_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Coverage_txt
            // 
            this.Coverage_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coverage_txt.Location = new System.Drawing.Point(24, 120);
            this.Coverage_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Coverage_txt.Name = "Coverage_txt";
            this.Coverage_txt.Size = new System.Drawing.Size(158, 29);
            this.Coverage_txt.TabIndex = 3;
            // 
            // Coverage_lbl
            // 
            this.Coverage_lbl.AutoSize = true;
            this.Coverage_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coverage_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Coverage_lbl.Location = new System.Drawing.Point(20, 97);
            this.Coverage_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Coverage_lbl.Name = "Coverage_lbl";
            this.Coverage_lbl.Size = new System.Drawing.Size(76, 21);
            this.Coverage_lbl.TabIndex = 2;
            this.Coverage_lbl.Text = "Coverage";
            // 
            // ContractType_txt
            // 
            this.ContractType_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractType_txt.Location = new System.Drawing.Point(24, 55);
            this.ContractType_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ContractType_txt.Name = "ContractType_txt";
            this.ContractType_txt.Size = new System.Drawing.Size(158, 29);
            this.ContractType_txt.TabIndex = 1;
            // 
            // ContractType_lbl
            // 
            this.ContractType_lbl.AutoSize = true;
            this.ContractType_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractType_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ContractType_lbl.Location = new System.Drawing.Point(21, 32);
            this.ContractType_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContractType_lbl.Name = "ContractType_lbl";
            this.ContractType_lbl.Size = new System.Drawing.Size(105, 21);
            this.ContractType_lbl.TabIndex = 0;
            this.ContractType_lbl.Text = "Contract Type";
            // 
            // SearchClient_btn
            // 
            this.SearchClient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.SearchClient_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchClient_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchClient_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.SearchClient_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.SearchClient_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.SearchClient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchClient_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClient_btn.ForeColor = System.Drawing.Color.Black;
            this.SearchClient_btn.Location = new System.Drawing.Point(492, 79);
            this.SearchClient_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchClient_btn.Name = "SearchClient_btn";
            this.SearchClient_btn.Size = new System.Drawing.Size(158, 35);
            this.SearchClient_btn.TabIndex = 5;
            this.SearchClient_btn.Text = "Search";
            this.SearchClient_btn.UseVisualStyleBackColor = false;
            // 
            // ClientNumber_txt
            // 
            this.ClientNumber_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNumber_txt.Location = new System.Drawing.Point(258, 83);
            this.ClientNumber_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNumber_txt.Name = "ClientNumber_txt";
            this.ClientNumber_txt.Size = new System.Drawing.Size(158, 29);
            this.ClientNumber_txt.TabIndex = 4;
            // 
            // ClientNumber_lbl
            // 
            this.ClientNumber_lbl.AutoSize = true;
            this.ClientNumber_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNumber_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ClientNumber_lbl.Location = new System.Drawing.Point(254, 60);
            this.ClientNumber_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientNumber_lbl.Name = "ClientNumber_lbl";
            this.ClientNumber_lbl.Size = new System.Drawing.Size(68, 21);
            this.ClientNumber_lbl.TabIndex = 3;
            this.ClientNumber_lbl.Text = "Number";
            // 
            // ClientName_txt
            // 
            this.ClientName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName_txt.Location = new System.Drawing.Point(27, 83);
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
            this.ClientName_lbl.Location = new System.Drawing.Point(23, 60);
            this.ClientName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientName_lbl.Name = "ClientName_lbl";
            this.ClientName_lbl.Size = new System.Drawing.Size(96, 21);
            this.ClientName_lbl.TabIndex = 1;
            this.ClientName_lbl.Text = "Client Name";
            // 
            // SearchClient_lbl
            // 
            this.SearchClient_lbl.AutoSize = true;
            this.SearchClient_lbl.Location = new System.Drawing.Point(22, 15);
            this.SearchClient_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchClient_lbl.Name = "SearchClient_lbl";
            this.SearchClient_lbl.Size = new System.Drawing.Size(134, 30);
            this.SearchClient_lbl.TabIndex = 0;
            this.SearchClient_lbl.Text = "Search Client";
            // 
            // History_tbp
            // 
            this.History_tbp.Controls.Add(this.Search_btn);
            this.History_tbp.Controls.Add(this.ClientNameOrNumber_txt);
            this.History_tbp.Controls.Add(this.ClientNameOrNumber_lbl);
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
            this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(261, 364);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(158, 35);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            // 
            // ClientNameOrNumber_txt
            // 
            this.ClientNameOrNumber_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameOrNumber_txt.Location = new System.Drawing.Point(34, 370);
            this.ClientNameOrNumber_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNameOrNumber_txt.Name = "ClientNameOrNumber_txt";
            this.ClientNameOrNumber_txt.Size = new System.Drawing.Size(158, 29);
            this.ClientNameOrNumber_txt.TabIndex = 3;
            // 
            // ClientNameOrNumber_lbl
            // 
            this.ClientNameOrNumber_lbl.AutoSize = true;
            this.ClientNameOrNumber_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameOrNumber_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ClientNameOrNumber_lbl.Location = new System.Drawing.Point(30, 347);
            this.ClientNameOrNumber_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientNameOrNumber_lbl.Name = "ClientNameOrNumber_lbl";
            this.ClientNameOrNumber_lbl.Size = new System.Drawing.Size(177, 21);
            this.ClientNameOrNumber_lbl.TabIndex = 2;
            this.ClientNameOrNumber_lbl.Text = "Client Name or Number";
            // 
            // PastServiceRequest_dgv
            // 
            this.PastServiceRequest_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastServiceRequest_dgv.Location = new System.Drawing.Point(13, 46);
            this.PastServiceRequest_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.PastServiceRequest_dgv.Name = "PastServiceRequest_dgv";
            this.PastServiceRequest_dgv.RowHeadersWidth = 51;
            this.PastServiceRequest_dgv.RowTemplate.Height = 24;
            this.PastServiceRequest_dgv.Size = new System.Drawing.Size(839, 285);
            this.PastServiceRequest_dgv.TabIndex = 1;
            // 
            // PastServiceRequest_lbl
            // 
            this.PastServiceRequest_lbl.AutoSize = true;
            this.PastServiceRequest_lbl.Location = new System.Drawing.Point(9, 12);
            this.PastServiceRequest_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PastServiceRequest_lbl.Name = "PastServiceRequest_lbl";
            this.PastServiceRequest_lbl.Size = new System.Drawing.Size(541, 30);
            this.PastServiceRequest_lbl.TabIndex = 0;
            this.PastServiceRequest_lbl.Text = "Past Service Request, Maintanance activities and invoices";
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
            this.PSS_img.Click += new System.EventHandler(this.PSS_img_Click);
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
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(749, 26);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(118, 36);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
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
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.PSS_img);
            this.Controls.Add(this.CallEmployee_tc);
            this.Controls.Add(this.Header_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Form";
            this.Load += new System.EventHandler(this.CallForm_Load);
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
            this.History_tbp.ResumeLayout(false);
            this.History_tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastServiceRequest_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Panel Header_pnl;
    }
}