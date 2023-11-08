namespace PSS_ITWORKS.Presentation_Layer
{
    partial class ServiceManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagerForm));
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.ServiceManager_tc = new System.Windows.Forms.TabControl();
            this.Assignment_tp = new System.Windows.Forms.TabPage();
            this.assign_btn = new System.Windows.Forms.Button();
            this.Assignement_dtp = new System.Windows.Forms.DateTimePicker();
            this.AssignmentSchedule_dgv = new System.Windows.Forms.DataGridView();
            this.Request_dgv = new System.Windows.Forms.DataGridView();
            this.AssignementSchedule_lbl = new System.Windows.Forms.Label();
            this.AssignementRequest_lbl = new System.Windows.Forms.Label();
            this.Schedule_tp = new System.Windows.Forms.TabPage();
            this.Schedule_dgv = new System.Windows.Forms.DataGridView();
            this.AssignmentFilter_btn = new System.Windows.Forms.Button();
            this.Filter_txt = new System.Windows.Forms.TextBox();
            this.AssignmentFilter_lbl = new System.Windows.Forms.Label();
            this.Schedule_lbl = new System.Windows.Forms.Label();
            this.Technicians_tp = new System.Windows.Forms.TabPage();
            this.Technician_dgv = new System.Windows.Forms.DataGridView();
            this.TechFilter_btn = new System.Windows.Forms.Button();
            this.TechFilter_txt = new System.Windows.Forms.TextBox();
            this.TechFilter_lbl = new System.Windows.Forms.Label();
            this.Technician_lcl = new System.Windows.Forms.Label();
            this.Jobs_tp = new System.Windows.Forms.TabPage();
            this.ModifyJobs_pnl = new System.Windows.Forms.Panel();
            this.SubmitChanges_btn = new System.Windows.Forms.Button();
            this.ChangeTech_lbx = new System.Windows.Forms.ListBox();
            this.Notes_rtb = new System.Windows.Forms.RichTextBox();
            this.status_cbx = new System.Windows.Forms.ComboBox();
            this.TimeEnd_dtp = new System.Windows.Forms.DateTimePicker();
            this.TimeBegin_dtp = new System.Windows.Forms.DateTimePicker();
            this.ChangeTech_lbl = new System.Windows.Forms.Label();
            this.ChangeNotes_lbl = new System.Windows.Forms.Label();
            this.ChangeStatus_lbl = new System.Windows.Forms.Label();
            this.ChangeTimeEnd_lbl = new System.Windows.Forms.Label();
            this.ChangeTimeBegin_lbl = new System.Windows.Forms.Label();
            this.ChangeService_lbl = new System.Windows.Forms.Label();
            this.Service_cbx = new System.Windows.Forms.ComboBox();
            this.ModifyJobs_btn = new System.Windows.Forms.Button();
            this.JobsByTech_dgv = new System.Windows.Forms.DataGridView();
            this.JobsFilter_btn = new System.Windows.Forms.Button();
            this.JobsFilter_txt = new System.Windows.Forms.TextBox();
            this.JobsFilter_lbl = new System.Windows.Forms.Label();
            this.Jobs_lbl = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.ServiceManager_tc.SuspendLayout();
            this.Assignment_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentSchedule_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Request_dgv)).BeginInit();
            this.Schedule_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_dgv)).BeginInit();
            this.Technicians_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Technician_dgv)).BeginInit();
            this.Jobs_tp.SuspendLayout();
            this.ModifyJobs_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsByTech_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PSS_img
            // 
            this.PSS_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PSS_img.BackgroundImage")));
            this.PSS_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PSS_img.Location = new System.Drawing.Point(12, 9);
            this.PSS_img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSS_img.Name = "PSS_img";
            this.PSS_img.Size = new System.Drawing.Size(76, 61);
            this.PSS_img.TabIndex = 0;
            this.PSS_img.TabStop = false;
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(94, 26);
            this.welcome_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(605, 32);
            this.welcome_lbl.TabIndex = 1;
            this.welcome_lbl.Text = "Welcome back <Name> <Surname> (Service Manager)";
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
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(118, 36);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // ServiceManager_tc
            // 
            this.ServiceManager_tc.Controls.Add(this.Assignment_tp);
            this.ServiceManager_tc.Controls.Add(this.Schedule_tp);
            this.ServiceManager_tc.Controls.Add(this.Technicians_tp);
            this.ServiceManager_tc.Controls.Add(this.Jobs_tp);
            this.ServiceManager_tc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceManager_tc.Location = new System.Drawing.Point(12, 94);
            this.ServiceManager_tc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceManager_tc.Name = "ServiceManager_tc";
            this.ServiceManager_tc.SelectedIndex = 0;
            this.ServiceManager_tc.Size = new System.Drawing.Size(873, 456);
            this.ServiceManager_tc.TabIndex = 3;
            // 
            // Assignment_tp
            // 
            this.Assignment_tp.Controls.Add(this.assign_btn);
            this.Assignment_tp.Controls.Add(this.Assignement_dtp);
            this.Assignment_tp.Controls.Add(this.AssignmentSchedule_dgv);
            this.Assignment_tp.Controls.Add(this.Request_dgv);
            this.Assignment_tp.Controls.Add(this.AssignementSchedule_lbl);
            this.Assignment_tp.Controls.Add(this.AssignementRequest_lbl);
            this.Assignment_tp.Location = new System.Drawing.Point(4, 39);
            this.Assignment_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assignment_tp.Name = "Assignment_tp";
            this.Assignment_tp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assignment_tp.Size = new System.Drawing.Size(865, 413);
            this.Assignment_tp.TabIndex = 0;
            this.Assignment_tp.Text = "Assignment";
            this.Assignment_tp.UseVisualStyleBackColor = true;
            // 
            // assign_btn
            // 
            this.assign_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.assign_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.assign_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assign_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assign_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign_btn.ForeColor = System.Drawing.Color.White;
            this.assign_btn.Location = new System.Drawing.Point(448, 358);
            this.assign_btn.Name = "assign_btn";
            this.assign_btn.Size = new System.Drawing.Size(117, 34);
            this.assign_btn.TabIndex = 5;
            this.assign_btn.Text = "Assign Job";
            this.assign_btn.UseVisualStyleBackColor = false;
            this.assign_btn.Click += new System.EventHandler(this.assign_btn_Click);
            // 
            // Assignement_dtp
            // 
            this.Assignement_dtp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignement_dtp.Location = new System.Drawing.Point(570, 360);
            this.Assignement_dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assignement_dtp.Name = "Assignement_dtp";
            this.Assignement_dtp.Size = new System.Drawing.Size(270, 29);
            this.Assignement_dtp.TabIndex = 4;
            // 
            // AssignmentSchedule_dgv
            // 
            this.AssignmentSchedule_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentSchedule_dgv.Location = new System.Drawing.Point(448, 47);
            this.AssignmentSchedule_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AssignmentSchedule_dgv.Name = "AssignmentSchedule_dgv";
            this.AssignmentSchedule_dgv.RowHeadersWidth = 51;
            this.AssignmentSchedule_dgv.RowTemplate.Height = 24;
            this.AssignmentSchedule_dgv.Size = new System.Drawing.Size(392, 281);
            this.AssignmentSchedule_dgv.TabIndex = 3;
            // 
            // Request_dgv
            // 
            this.Request_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Request_dgv.Location = new System.Drawing.Point(25, 47);
            this.Request_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Request_dgv.Name = "Request_dgv";
            this.Request_dgv.RowHeadersWidth = 51;
            this.Request_dgv.RowTemplate.Height = 24;
            this.Request_dgv.Size = new System.Drawing.Size(400, 345);
            this.Request_dgv.TabIndex = 2;
            // 
            // AssignementSchedule_lbl
            // 
            this.AssignementSchedule_lbl.AutoSize = true;
            this.AssignementSchedule_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignementSchedule_lbl.Location = new System.Drawing.Point(443, 20);
            this.AssignementSchedule_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignementSchedule_lbl.Name = "AssignementSchedule_lbl";
            this.AssignementSchedule_lbl.Size = new System.Drawing.Size(89, 25);
            this.AssignementSchedule_lbl.TabIndex = 1;
            this.AssignementSchedule_lbl.Text = "Schedule";
            // 
            // AssignementRequest_lbl
            // 
            this.AssignementRequest_lbl.AutoSize = true;
            this.AssignementRequest_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignementRequest_lbl.Location = new System.Drawing.Point(20, 20);
            this.AssignementRequest_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignementRequest_lbl.Name = "AssignementRequest_lbl";
            this.AssignementRequest_lbl.Size = new System.Drawing.Size(86, 25);
            this.AssignementRequest_lbl.TabIndex = 0;
            this.AssignementRequest_lbl.Text = "Requests";
            // 
            // Schedule_tp
            // 
            this.Schedule_tp.Controls.Add(this.Schedule_dgv);
            this.Schedule_tp.Controls.Add(this.AssignmentFilter_btn);
            this.Schedule_tp.Controls.Add(this.Filter_txt);
            this.Schedule_tp.Controls.Add(this.AssignmentFilter_lbl);
            this.Schedule_tp.Controls.Add(this.Schedule_lbl);
            this.Schedule_tp.Location = new System.Drawing.Point(4, 39);
            this.Schedule_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule_tp.Name = "Schedule_tp";
            this.Schedule_tp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule_tp.Size = new System.Drawing.Size(865, 413);
            this.Schedule_tp.TabIndex = 1;
            this.Schedule_tp.Text = "Schedule";
            this.Schedule_tp.UseVisualStyleBackColor = true;
            // 
            // Schedule_dgv
            // 
            this.Schedule_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schedule_dgv.Location = new System.Drawing.Point(211, 26);
            this.Schedule_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule_dgv.Name = "Schedule_dgv";
            this.Schedule_dgv.RowHeadersWidth = 51;
            this.Schedule_dgv.RowTemplate.Height = 24;
            this.Schedule_dgv.Size = new System.Drawing.Size(641, 379);
            this.Schedule_dgv.TabIndex = 4;
            // 
            // AssignmentFilter_btn
            // 
            this.AssignmentFilter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.AssignmentFilter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AssignmentFilter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignmentFilter_btn.FlatAppearance.BorderSize = 0;
            this.AssignmentFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignmentFilter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentFilter_btn.ForeColor = System.Drawing.Color.Black;
            this.AssignmentFilter_btn.Location = new System.Drawing.Point(27, 115);
            this.AssignmentFilter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AssignmentFilter_btn.Name = "AssignmentFilter_btn";
            this.AssignmentFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.AssignmentFilter_btn.TabIndex = 3;
            this.AssignmentFilter_btn.Text = "Filter";
            this.AssignmentFilter_btn.UseVisualStyleBackColor = false;
            this.AssignmentFilter_btn.Click += new System.EventHandler(this.AssignmentFilter_btn_Click);
            // 
            // Filter_txt
            // 
            this.Filter_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_txt.Location = new System.Drawing.Point(27, 75);
            this.Filter_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Filter_txt.Name = "Filter_txt";
            this.Filter_txt.Size = new System.Drawing.Size(160, 29);
            this.Filter_txt.TabIndex = 2;
            this.Filter_txt.Text = "Filter by technician";
            // 
            // AssignmentFilter_lbl
            // 
            this.AssignmentFilter_lbl.AutoSize = true;
            this.AssignmentFilter_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentFilter_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.AssignmentFilter_lbl.Location = new System.Drawing.Point(22, 53);
            this.AssignmentFilter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentFilter_lbl.Name = "AssignmentFilter_lbl";
            this.AssignmentFilter_lbl.Size = new System.Drawing.Size(45, 21);
            this.AssignmentFilter_lbl.TabIndex = 1;
            this.AssignmentFilter_lbl.Text = "Filter";
            // 
            // Schedule_lbl
            // 
            this.Schedule_lbl.AutoSize = true;
            this.Schedule_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_lbl.Location = new System.Drawing.Point(23, 15);
            this.Schedule_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Schedule_lbl.Name = "Schedule_lbl";
            this.Schedule_lbl.Size = new System.Drawing.Size(89, 25);
            this.Schedule_lbl.TabIndex = 0;
            this.Schedule_lbl.Text = "Schedule";
            // 
            // Technicians_tp
            // 
            this.Technicians_tp.Controls.Add(this.Technician_dgv);
            this.Technicians_tp.Controls.Add(this.TechFilter_btn);
            this.Technicians_tp.Controls.Add(this.TechFilter_txt);
            this.Technicians_tp.Controls.Add(this.TechFilter_lbl);
            this.Technicians_tp.Controls.Add(this.Technician_lcl);
            this.Technicians_tp.Location = new System.Drawing.Point(4, 39);
            this.Technicians_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Technicians_tp.Name = "Technicians_tp";
            this.Technicians_tp.Size = new System.Drawing.Size(865, 413);
            this.Technicians_tp.TabIndex = 2;
            this.Technicians_tp.Text = "Technicians";
            this.Technicians_tp.UseVisualStyleBackColor = true;
            // 
            // Technician_dgv
            // 
            this.Technician_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Technician_dgv.Location = new System.Drawing.Point(207, 26);
            this.Technician_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Technician_dgv.Name = "Technician_dgv";
            this.Technician_dgv.RowHeadersWidth = 51;
            this.Technician_dgv.RowTemplate.Height = 24;
            this.Technician_dgv.Size = new System.Drawing.Size(641, 379);
            this.Technician_dgv.TabIndex = 9;
            // 
            // TechFilter_btn
            // 
            this.TechFilter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.TechFilter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TechFilter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TechFilter_btn.FlatAppearance.BorderSize = 0;
            this.TechFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechFilter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechFilter_btn.ForeColor = System.Drawing.Color.Black;
            this.TechFilter_btn.Location = new System.Drawing.Point(23, 115);
            this.TechFilter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TechFilter_btn.Name = "TechFilter_btn";
            this.TechFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.TechFilter_btn.TabIndex = 8;
            this.TechFilter_btn.Text = "Filter";
            this.TechFilter_btn.UseVisualStyleBackColor = false;
            this.TechFilter_btn.Click += new System.EventHandler(this.TechFilter_btn_Click);
            // 
            // TechFilter_txt
            // 
            this.TechFilter_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechFilter_txt.Location = new System.Drawing.Point(23, 75);
            this.TechFilter_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TechFilter_txt.Name = "TechFilter_txt";
            this.TechFilter_txt.Size = new System.Drawing.Size(160, 29);
            this.TechFilter_txt.TabIndex = 7;
            this.TechFilter_txt.Text = "Filter by service";
            // 
            // TechFilter_lbl
            // 
            this.TechFilter_lbl.AutoSize = true;
            this.TechFilter_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechFilter_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.TechFilter_lbl.Location = new System.Drawing.Point(19, 53);
            this.TechFilter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TechFilter_lbl.Name = "TechFilter_lbl";
            this.TechFilter_lbl.Size = new System.Drawing.Size(45, 21);
            this.TechFilter_lbl.TabIndex = 6;
            this.TechFilter_lbl.Text = "Filter";
            // 
            // Technician_lcl
            // 
            this.Technician_lcl.AutoSize = true;
            this.Technician_lcl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician_lcl.Location = new System.Drawing.Point(20, 15);
            this.Technician_lcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Technician_lcl.Name = "Technician_lcl";
            this.Technician_lcl.Size = new System.Drawing.Size(109, 25);
            this.Technician_lcl.TabIndex = 5;
            this.Technician_lcl.Text = "Technicians";
            // 
            // Jobs_tp
            // 
            this.Jobs_tp.Controls.Add(this.ModifyJobs_pnl);
            this.Jobs_tp.Controls.Add(this.ModifyJobs_btn);
            this.Jobs_tp.Controls.Add(this.JobsByTech_dgv);
            this.Jobs_tp.Controls.Add(this.JobsFilter_btn);
            this.Jobs_tp.Controls.Add(this.JobsFilter_txt);
            this.Jobs_tp.Controls.Add(this.JobsFilter_lbl);
            this.Jobs_tp.Controls.Add(this.Jobs_lbl);
            this.Jobs_tp.Location = new System.Drawing.Point(4, 39);
            this.Jobs_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Jobs_tp.Name = "Jobs_tp";
            this.Jobs_tp.Size = new System.Drawing.Size(865, 413);
            this.Jobs_tp.TabIndex = 3;
            this.Jobs_tp.Text = "Jobs";
            this.Jobs_tp.UseVisualStyleBackColor = true;
            // 
            // ModifyJobs_pnl
            // 
            this.ModifyJobs_pnl.Controls.Add(this.SubmitChanges_btn);
            this.ModifyJobs_pnl.Controls.Add(this.ChangeTech_lbx);
            this.ModifyJobs_pnl.Controls.Add(this.Notes_rtb);
            this.ModifyJobs_pnl.Controls.Add(this.status_cbx);
            this.ModifyJobs_pnl.Controls.Add(this.TimeEnd_dtp);
            this.ModifyJobs_pnl.Controls.Add(this.TimeBegin_dtp);
            this.ModifyJobs_pnl.Controls.Add(this.ChangeTech_lbl);
            this.ModifyJobs_pnl.Controls.Add(this.ChangeNotes_lbl);
            this.ModifyJobs_pnl.Controls.Add(this.ChangeStatus_lbl);
            this.ModifyJobs_pnl.Controls.Add(this.ChangeTimeEnd_lbl);
            this.ModifyJobs_pnl.Controls.Add(this.ChangeTimeBegin_lbl);
            this.ModifyJobs_pnl.Controls.Add(this.ChangeService_lbl);
            this.ModifyJobs_pnl.Controls.Add(this.Service_cbx);
            this.ModifyJobs_pnl.Location = new System.Drawing.Point(207, 26);
            this.ModifyJobs_pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyJobs_pnl.Name = "ModifyJobs_pnl";
            this.ModifyJobs_pnl.Size = new System.Drawing.Size(641, 379);
            this.ModifyJobs_pnl.TabIndex = 11;
            // 
            // SubmitChanges_btn
            // 
            this.SubmitChanges_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.SubmitChanges_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitChanges_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitChanges_btn.FlatAppearance.BorderSize = 0;
            this.SubmitChanges_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitChanges_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitChanges_btn.ForeColor = System.Drawing.Color.White;
            this.SubmitChanges_btn.Location = new System.Drawing.Point(42, 329);
            this.SubmitChanges_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitChanges_btn.Name = "SubmitChanges_btn";
            this.SubmitChanges_btn.Size = new System.Drawing.Size(158, 35);
            this.SubmitChanges_btn.TabIndex = 12;
            this.SubmitChanges_btn.Text = "Submit Changes";
            this.SubmitChanges_btn.UseVisualStyleBackColor = false;
            this.SubmitChanges_btn.Click += new System.EventHandler(this.SubmitChanges_btn_Click);
            // 
            // ChangeTech_lbx
            // 
            this.ChangeTech_lbx.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTech_lbx.FormattingEnabled = true;
            this.ChangeTech_lbx.ItemHeight = 19;
            this.ChangeTech_lbx.Location = new System.Drawing.Point(479, 45);
            this.ChangeTech_lbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeTech_lbx.Name = "ChangeTech_lbx";
            this.ChangeTech_lbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ChangeTech_lbx.Size = new System.Drawing.Size(148, 232);
            this.ChangeTech_lbx.TabIndex = 18;
            // 
            // Notes_rtb
            // 
            this.Notes_rtb.Location = new System.Drawing.Point(254, 45);
            this.Notes_rtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Notes_rtb.Name = "Notes_rtb";
            this.Notes_rtb.Size = new System.Drawing.Size(178, 267);
            this.Notes_rtb.TabIndex = 17;
            this.Notes_rtb.Text = "";
            // 
            // status_cbx
            // 
            this.status_cbx.FormattingEnabled = true;
            this.status_cbx.Location = new System.Drawing.Point(42, 261);
            this.status_cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.status_cbx.Name = "status_cbx";
            this.status_cbx.Size = new System.Drawing.Size(160, 38);
            this.status_cbx.TabIndex = 16;
            // 
            // TimeEnd_dtp
            // 
            this.TimeEnd_dtp.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeEnd_dtp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeEnd_dtp.Location = new System.Drawing.Point(42, 191);
            this.TimeEnd_dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeEnd_dtp.Name = "TimeEnd_dtp";
            this.TimeEnd_dtp.Size = new System.Drawing.Size(160, 27);
            this.TimeEnd_dtp.TabIndex = 15;
            // 
            // TimeBegin_dtp
            // 
            this.TimeBegin_dtp.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBegin_dtp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBegin_dtp.Location = new System.Drawing.Point(42, 120);
            this.TimeBegin_dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeBegin_dtp.Name = "TimeBegin_dtp";
            this.TimeBegin_dtp.Size = new System.Drawing.Size(160, 27);
            this.TimeBegin_dtp.TabIndex = 14;
            // 
            // ChangeTech_lbl
            // 
            this.ChangeTech_lbl.AutoSize = true;
            this.ChangeTech_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTech_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ChangeTech_lbl.Location = new System.Drawing.Point(482, 20);
            this.ChangeTech_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeTech_lbl.Name = "ChangeTech_lbl";
            this.ChangeTech_lbl.Size = new System.Drawing.Size(88, 21);
            this.ChangeTech_lbl.TabIndex = 13;
            this.ChangeTech_lbl.Text = "Technicians";
            // 
            // ChangeNotes_lbl
            // 
            this.ChangeNotes_lbl.AutoSize = true;
            this.ChangeNotes_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeNotes_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ChangeNotes_lbl.Location = new System.Drawing.Point(250, 20);
            this.ChangeNotes_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeNotes_lbl.Name = "ChangeNotes_lbl";
            this.ChangeNotes_lbl.Size = new System.Drawing.Size(51, 21);
            this.ChangeNotes_lbl.TabIndex = 12;
            this.ChangeNotes_lbl.Text = "Notes";
            // 
            // ChangeStatus_lbl
            // 
            this.ChangeStatus_lbl.AutoSize = true;
            this.ChangeStatus_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeStatus_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ChangeStatus_lbl.Location = new System.Drawing.Point(38, 236);
            this.ChangeStatus_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeStatus_lbl.Name = "ChangeStatus_lbl";
            this.ChangeStatus_lbl.Size = new System.Drawing.Size(52, 21);
            this.ChangeStatus_lbl.TabIndex = 9;
            this.ChangeStatus_lbl.Text = "Status";
            // 
            // ChangeTimeEnd_lbl
            // 
            this.ChangeTimeEnd_lbl.AutoSize = true;
            this.ChangeTimeEnd_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTimeEnd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ChangeTimeEnd_lbl.Location = new System.Drawing.Point(38, 166);
            this.ChangeTimeEnd_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeTimeEnd_lbl.Name = "ChangeTimeEnd_lbl";
            this.ChangeTimeEnd_lbl.Size = new System.Drawing.Size(74, 21);
            this.ChangeTimeEnd_lbl.TabIndex = 11;
            this.ChangeTimeEnd_lbl.Text = "Time End";
            // 
            // ChangeTimeBegin_lbl
            // 
            this.ChangeTimeBegin_lbl.AutoSize = true;
            this.ChangeTimeBegin_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTimeBegin_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ChangeTimeBegin_lbl.Location = new System.Drawing.Point(38, 95);
            this.ChangeTimeBegin_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeTimeBegin_lbl.Name = "ChangeTimeBegin_lbl";
            this.ChangeTimeBegin_lbl.Size = new System.Drawing.Size(87, 21);
            this.ChangeTimeBegin_lbl.TabIndex = 10;
            this.ChangeTimeBegin_lbl.Text = "Time Begin";
            // 
            // ChangeService_lbl
            // 
            this.ChangeService_lbl.AutoSize = true;
            this.ChangeService_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeService_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ChangeService_lbl.Location = new System.Drawing.Point(38, 20);
            this.ChangeService_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeService_lbl.Name = "ChangeService_lbl";
            this.ChangeService_lbl.Size = new System.Drawing.Size(60, 21);
            this.ChangeService_lbl.TabIndex = 8;
            this.ChangeService_lbl.Text = "Service";
            // 
            // Service_cbx
            // 
            this.Service_cbx.FormattingEnabled = true;
            this.Service_cbx.Location = new System.Drawing.Point(42, 45);
            this.Service_cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Service_cbx.Name = "Service_cbx";
            this.Service_cbx.Size = new System.Drawing.Size(160, 38);
            this.Service_cbx.TabIndex = 0;
            // 
            // ModifyJobs_btn
            // 
            this.ModifyJobs_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.ModifyJobs_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ModifyJobs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifyJobs_btn.FlatAppearance.BorderSize = 0;
            this.ModifyJobs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyJobs_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyJobs_btn.ForeColor = System.Drawing.Color.Black;
            this.ModifyJobs_btn.Location = new System.Drawing.Point(24, 167);
            this.ModifyJobs_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyJobs_btn.Name = "ModifyJobs_btn";
            this.ModifyJobs_btn.Size = new System.Drawing.Size(158, 35);
            this.ModifyJobs_btn.TabIndex = 10;
            this.ModifyJobs_btn.Text = "Modify Job";
            this.ModifyJobs_btn.UseVisualStyleBackColor = false;
            this.ModifyJobs_btn.Click += new System.EventHandler(this.ModifyJobs_btn_Click);
            // 
            // JobsByTech_dgv
            // 
            this.JobsByTech_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobsByTech_dgv.Location = new System.Drawing.Point(207, 26);
            this.JobsByTech_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JobsByTech_dgv.Name = "JobsByTech_dgv";
            this.JobsByTech_dgv.RowHeadersWidth = 51;
            this.JobsByTech_dgv.RowTemplate.Height = 24;
            this.JobsByTech_dgv.Size = new System.Drawing.Size(641, 379);
            this.JobsByTech_dgv.TabIndex = 9;
            // 
            // JobsFilter_btn
            // 
            this.JobsFilter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.JobsFilter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.JobsFilter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobsFilter_btn.FlatAppearance.BorderSize = 0;
            this.JobsFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JobsFilter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsFilter_btn.ForeColor = System.Drawing.Color.Black;
            this.JobsFilter_btn.Location = new System.Drawing.Point(23, 115);
            this.JobsFilter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JobsFilter_btn.Name = "JobsFilter_btn";
            this.JobsFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.JobsFilter_btn.TabIndex = 8;
            this.JobsFilter_btn.Text = "Filter";
            this.JobsFilter_btn.UseVisualStyleBackColor = false;
            this.JobsFilter_btn.Click += new System.EventHandler(this.JobsFilter_btn_Click);
            // 
            // JobsFilter_txt
            // 
            this.JobsFilter_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsFilter_txt.Location = new System.Drawing.Point(23, 75);
            this.JobsFilter_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JobsFilter_txt.Name = "JobsFilter_txt";
            this.JobsFilter_txt.Size = new System.Drawing.Size(160, 29);
            this.JobsFilter_txt.TabIndex = 7;
            this.JobsFilter_txt.Text = "Filter by technician";
            // 
            // JobsFilter_lbl
            // 
            this.JobsFilter_lbl.AutoSize = true;
            this.JobsFilter_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsFilter_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.JobsFilter_lbl.Location = new System.Drawing.Point(19, 53);
            this.JobsFilter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JobsFilter_lbl.Name = "JobsFilter_lbl";
            this.JobsFilter_lbl.Size = new System.Drawing.Size(45, 21);
            this.JobsFilter_lbl.TabIndex = 6;
            this.JobsFilter_lbl.Text = "Filter";
            // 
            // Jobs_lbl
            // 
            this.Jobs_lbl.AutoSize = true;
            this.Jobs_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jobs_lbl.Location = new System.Drawing.Point(20, 15);
            this.Jobs_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Jobs_lbl.Name = "Jobs_lbl";
            this.Jobs_lbl.Size = new System.Drawing.Size(49, 25);
            this.Jobs_lbl.TabIndex = 5;
            this.Jobs_lbl.Text = "Jobs";
            // 
            // ServiceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.ServiceManager_tc);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.PSS_img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceManagerForm";
            this.Text = "Service Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.ServiceManager_tc.ResumeLayout(false);
            this.Assignment_tp.ResumeLayout(false);
            this.Assignment_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentSchedule_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Request_dgv)).EndInit();
            this.Schedule_tp.ResumeLayout(false);
            this.Schedule_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_dgv)).EndInit();
            this.Technicians_tp.ResumeLayout(false);
            this.Technicians_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Technician_dgv)).EndInit();
            this.Jobs_tp.ResumeLayout(false);
            this.Jobs_tp.PerformLayout();
            this.ModifyJobs_pnl.ResumeLayout(false);
            this.ModifyJobs_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsByTech_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.TabControl ServiceManager_tc;
        private System.Windows.Forms.TabPage Assignment_tp;
        private System.Windows.Forms.DateTimePicker Assignement_dtp;
        private System.Windows.Forms.DataGridView AssignmentSchedule_dgv;
        private System.Windows.Forms.DataGridView Request_dgv;
        private System.Windows.Forms.Label AssignementSchedule_lbl;
        private System.Windows.Forms.Label AssignementRequest_lbl;
        private System.Windows.Forms.TabPage Schedule_tp;
        private System.Windows.Forms.TabPage Technicians_tp;
        private System.Windows.Forms.TabPage Jobs_tp;
        private System.Windows.Forms.Label Schedule_lbl;
        private System.Windows.Forms.TextBox Filter_txt;
        private System.Windows.Forms.Label AssignmentFilter_lbl;
        private System.Windows.Forms.DataGridView Schedule_dgv;
        private System.Windows.Forms.Button AssignmentFilter_btn;
        private System.Windows.Forms.DataGridView Technician_dgv;
        private System.Windows.Forms.Button TechFilter_btn;
        private System.Windows.Forms.TextBox TechFilter_txt;
        private System.Windows.Forms.Label TechFilter_lbl;
        private System.Windows.Forms.Label Technician_lcl;
        private System.Windows.Forms.Button ModifyJobs_btn;
        private System.Windows.Forms.DataGridView JobsByTech_dgv;
        private System.Windows.Forms.Button JobsFilter_btn;
        private System.Windows.Forms.TextBox JobsFilter_txt;
        private System.Windows.Forms.Label JobsFilter_lbl;
        private System.Windows.Forms.Label Jobs_lbl;
        private System.Windows.Forms.Button assign_btn;
        private System.Windows.Forms.Panel ModifyJobs_pnl;
        private System.Windows.Forms.ListBox ChangeTech_lbx;
        private System.Windows.Forms.RichTextBox Notes_rtb;
        private System.Windows.Forms.ComboBox status_cbx;
        private System.Windows.Forms.DateTimePicker TimeEnd_dtp;
        private System.Windows.Forms.DateTimePicker TimeBegin_dtp;
        private System.Windows.Forms.Label ChangeTech_lbl;
        private System.Windows.Forms.Label ChangeNotes_lbl;
        private System.Windows.Forms.Label ChangeStatus_lbl;
        private System.Windows.Forms.Label ChangeTimeEnd_lbl;
        private System.Windows.Forms.Label ChangeTimeBegin_lbl;
        private System.Windows.Forms.Label ChangeService_lbl;
        private System.Windows.Forms.ComboBox Service_cbx;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button SubmitChanges_btn;
    }
}