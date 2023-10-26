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
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.ServiceManager_tc = new System.Windows.Forms.TabControl();
            this.Assignment_tp = new System.Windows.Forms.TabPage();
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
            this.ModifyJobs_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.JobsFilter_btn = new System.Windows.Forms.Button();
            this.JobsFilter_txt = new System.Windows.Forms.TextBox();
            this.JobsFilter_lbl = new System.Windows.Forms.Label();
            this.Jobs_lbl = new System.Windows.Forms.Label();
            this.assign_btn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            // PSS_lbl
            // 
            this.PSS_lbl.AutoSize = true;
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.Location = new System.Drawing.Point(94, 26);
            this.PSS_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(598, 32);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back <name> <surname> (Service Manager)";
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(749, 26);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(118, 36);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // ServiceManager_tc
            // 
            this.ServiceManager_tc.Controls.Add(this.Assignment_tp);
            this.ServiceManager_tc.Controls.Add(this.Schedule_tp);
            this.ServiceManager_tc.Controls.Add(this.Technicians_tp);
            this.ServiceManager_tc.Controls.Add(this.Jobs_tp);
            this.ServiceManager_tc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Assignment_tp.Location = new System.Drawing.Point(4, 34);
            this.Assignment_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assignment_tp.Name = "Assignment_tp";
            this.Assignment_tp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assignment_tp.Size = new System.Drawing.Size(865, 418);
            this.Assignment_tp.TabIndex = 0;
            this.Assignment_tp.Text = "Assignment";
            this.Assignment_tp.UseVisualStyleBackColor = true;
            // 
            // Assignement_dtp
            // 
            this.Assignement_dtp.Location = new System.Drawing.Point(671, 360);
            this.Assignement_dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assignement_dtp.Name = "Assignement_dtp";
            this.Assignement_dtp.Size = new System.Drawing.Size(160, 32);
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
            this.AssignementSchedule_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignementSchedule_lbl.Location = new System.Drawing.Point(445, 12);
            this.AssignementSchedule_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignementSchedule_lbl.Name = "AssignementSchedule_lbl";
            this.AssignementSchedule_lbl.Size = new System.Drawing.Size(71, 20);
            this.AssignementSchedule_lbl.TabIndex = 1;
            this.AssignementSchedule_lbl.Text = "Schedule";
            // 
            // AssignementRequest_lbl
            // 
            this.AssignementRequest_lbl.AutoSize = true;
            this.AssignementRequest_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignementRequest_lbl.Location = new System.Drawing.Point(21, 12);
            this.AssignementRequest_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignementRequest_lbl.Name = "AssignementRequest_lbl";
            this.AssignementRequest_lbl.Size = new System.Drawing.Size(69, 20);
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
            this.Schedule_tp.Location = new System.Drawing.Point(4, 34);
            this.Schedule_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule_tp.Name = "Schedule_tp";
            this.Schedule_tp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule_tp.Size = new System.Drawing.Size(865, 418);
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
            this.AssignmentFilter_btn.ForeColor = System.Drawing.Color.White;
            this.AssignmentFilter_btn.Location = new System.Drawing.Point(27, 115);
            this.AssignmentFilter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AssignmentFilter_btn.Name = "AssignmentFilter_btn";
            this.AssignmentFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.AssignmentFilter_btn.TabIndex = 3;
            this.AssignmentFilter_btn.Text = "Filter";
            this.AssignmentFilter_btn.UseVisualStyleBackColor = false;
            // 
            // Filter_txt
            // 
            this.Filter_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_txt.Location = new System.Drawing.Point(27, 75);
            this.Filter_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Filter_txt.Name = "Filter_txt";
            this.Filter_txt.Size = new System.Drawing.Size(160, 26);
            this.Filter_txt.TabIndex = 2;
            this.Filter_txt.Text = "Filter by technician/service";
            this.Filter_txt.TextChanged += new System.EventHandler(this.Filter_txt_TextChanged);
            // 
            // AssignmentFilter_lbl
            // 
            this.AssignmentFilter_lbl.AutoSize = true;
            this.AssignmentFilter_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentFilter_lbl.ForeColor = System.Drawing.Color.Blue;
            this.AssignmentFilter_lbl.Location = new System.Drawing.Point(22, 53);
            this.AssignmentFilter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentFilter_lbl.Name = "AssignmentFilter_lbl";
            this.AssignmentFilter_lbl.Size = new System.Drawing.Size(39, 19);
            this.AssignmentFilter_lbl.TabIndex = 1;
            this.AssignmentFilter_lbl.Text = "Filter";
            // 
            // Schedule_lbl
            // 
            this.Schedule_lbl.AutoSize = true;
            this.Schedule_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_lbl.Location = new System.Drawing.Point(23, 15);
            this.Schedule_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Schedule_lbl.Name = "Schedule_lbl";
            this.Schedule_lbl.Size = new System.Drawing.Size(71, 20);
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
            this.Technicians_tp.Location = new System.Drawing.Point(4, 34);
            this.Technicians_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Technicians_tp.Name = "Technicians_tp";
            this.Technicians_tp.Size = new System.Drawing.Size(865, 418);
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
            this.TechFilter_btn.ForeColor = System.Drawing.Color.White;
            this.TechFilter_btn.Location = new System.Drawing.Point(23, 115);
            this.TechFilter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TechFilter_btn.Name = "TechFilter_btn";
            this.TechFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.TechFilter_btn.TabIndex = 8;
            this.TechFilter_btn.Text = "Filter";
            this.TechFilter_btn.UseVisualStyleBackColor = false;
            // 
            // TechFilter_txt
            // 
            this.TechFilter_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechFilter_txt.Location = new System.Drawing.Point(23, 75);
            this.TechFilter_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TechFilter_txt.Name = "TechFilter_txt";
            this.TechFilter_txt.Size = new System.Drawing.Size(160, 26);
            this.TechFilter_txt.TabIndex = 7;
            this.TechFilter_txt.Text = "Filter by technician";
            // 
            // TechFilter_lbl
            // 
            this.TechFilter_lbl.AutoSize = true;
            this.TechFilter_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechFilter_lbl.ForeColor = System.Drawing.Color.Blue;
            this.TechFilter_lbl.Location = new System.Drawing.Point(19, 53);
            this.TechFilter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TechFilter_lbl.Name = "TechFilter_lbl";
            this.TechFilter_lbl.Size = new System.Drawing.Size(39, 19);
            this.TechFilter_lbl.TabIndex = 6;
            this.TechFilter_lbl.Text = "Filter";
            // 
            // Technician_lcl
            // 
            this.Technician_lcl.AutoSize = true;
            this.Technician_lcl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician_lcl.Location = new System.Drawing.Point(20, 15);
            this.Technician_lcl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Technician_lcl.Name = "Technician_lcl";
            this.Technician_lcl.Size = new System.Drawing.Size(87, 20);
            this.Technician_lcl.TabIndex = 5;
            this.Technician_lcl.Text = "Technicians";
            // 
            // Jobs_tp
            // 
            this.Jobs_tp.Controls.Add(this.ModifyJobs_btn);
            this.Jobs_tp.Controls.Add(this.dataGridView2);
            this.Jobs_tp.Controls.Add(this.JobsFilter_btn);
            this.Jobs_tp.Controls.Add(this.JobsFilter_txt);
            this.Jobs_tp.Controls.Add(this.JobsFilter_lbl);
            this.Jobs_tp.Controls.Add(this.Jobs_lbl);
            this.Jobs_tp.Location = new System.Drawing.Point(4, 34);
            this.Jobs_tp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Jobs_tp.Name = "Jobs_tp";
            this.Jobs_tp.Size = new System.Drawing.Size(865, 418);
            this.Jobs_tp.TabIndex = 3;
            this.Jobs_tp.Text = "Jobs";
            this.Jobs_tp.UseVisualStyleBackColor = true;
            // 
            // ModifyJobs_btn
            // 
            this.ModifyJobs_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.ModifyJobs_btn.ForeColor = System.Drawing.Color.White;
            this.ModifyJobs_btn.Location = new System.Drawing.Point(24, 167);
            this.ModifyJobs_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyJobs_btn.Name = "ModifyJobs_btn";
            this.ModifyJobs_btn.Size = new System.Drawing.Size(158, 35);
            this.ModifyJobs_btn.TabIndex = 10;
            this.ModifyJobs_btn.Text = "Modify Job";
            this.ModifyJobs_btn.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(207, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(641, 379);
            this.dataGridView2.TabIndex = 9;
            // 
            // JobsFilter_btn
            // 
            this.JobsFilter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.JobsFilter_btn.ForeColor = System.Drawing.Color.White;
            this.JobsFilter_btn.Location = new System.Drawing.Point(23, 115);
            this.JobsFilter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JobsFilter_btn.Name = "JobsFilter_btn";
            this.JobsFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.JobsFilter_btn.TabIndex = 8;
            this.JobsFilter_btn.Text = "Filter";
            this.JobsFilter_btn.UseVisualStyleBackColor = false;
            // 
            // JobsFilter_txt
            // 
            this.JobsFilter_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsFilter_txt.Location = new System.Drawing.Point(23, 75);
            this.JobsFilter_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JobsFilter_txt.Name = "JobsFilter_txt";
            this.JobsFilter_txt.Size = new System.Drawing.Size(160, 26);
            this.JobsFilter_txt.TabIndex = 7;
            this.JobsFilter_txt.Text = "Filter by technician";
            // 
            // JobsFilter_lbl
            // 
            this.JobsFilter_lbl.AutoSize = true;
            this.JobsFilter_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsFilter_lbl.ForeColor = System.Drawing.Color.Blue;
            this.JobsFilter_lbl.Location = new System.Drawing.Point(19, 53);
            this.JobsFilter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JobsFilter_lbl.Name = "JobsFilter_lbl";
            this.JobsFilter_lbl.Size = new System.Drawing.Size(39, 19);
            this.JobsFilter_lbl.TabIndex = 6;
            this.JobsFilter_lbl.Text = "Filter";
            // 
            // Jobs_lbl
            // 
            this.Jobs_lbl.AutoSize = true;
            this.Jobs_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jobs_lbl.Location = new System.Drawing.Point(20, 15);
            this.Jobs_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Jobs_lbl.Name = "Jobs_lbl";
            this.Jobs_lbl.Size = new System.Drawing.Size(39, 20);
            this.Jobs_lbl.TabIndex = 5;
            this.Jobs_lbl.Text = "Jobs";
            // 
            // assign_btn
            // 
            this.assign_btn.Location = new System.Drawing.Point(486, 358);
            this.assign_btn.Name = "assign_btn";
            this.assign_btn.Size = new System.Drawing.Size(117, 34);
            this.assign_btn.TabIndex = 5;
            this.assign_btn.Text = "Assign Job";
            this.assign_btn.UseVisualStyleBackColor = true;
            this.assign_btn.Click += new System.EventHandler(this.assign_btn_Click);
            // 
            // ServiceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.ServiceManager_tc);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.PSS_img);
            this.Name = "ServiceManagerForm";
            this.Text = "ServiceManagerForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.Label PSS_lbl;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button JobsFilter_btn;
        private System.Windows.Forms.TextBox JobsFilter_txt;
        private System.Windows.Forms.Label JobsFilter_lbl;
        private System.Windows.Forms.Label Jobs_lbl;
        private System.Windows.Forms.Button assign_btn;
    }
}