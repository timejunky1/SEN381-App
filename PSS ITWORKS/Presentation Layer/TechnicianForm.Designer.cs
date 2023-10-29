namespace PSS_ITWORKS.Presentation_Layer
{
    partial class Technician
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
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.Technical_tc = new System.Windows.Forms.TabControl();
            this.taskList_tp = new System.Windows.Forms.TabPage();
            this.taskList_dgv = new System.Windows.Forms.DataGridView();
            this.TLMInfo_lbl = new System.Windows.Forms.Label();
            this.TLM_lbl = new System.Windows.Forms.Label();
            this.taskUpdates_tp = new System.Windows.Forms.TabPage();
            this.jobStatus_lbl = new System.Windows.Forms.Label();
            this.jobNotes_lbl = new System.Windows.Forms.Label();
            this.jobNotes_rtb = new System.Windows.Forms.RichTextBox();
            this.submitUpdate_btn = new System.Windows.Forms.Button();
            this.searchJob_btn = new System.Windows.Forms.Button();
            this.jobID_txt = new System.Windows.Forms.TextBox();
            this.JobID_lbl = new System.Windows.Forms.Label();
            this.taskUpdateInfo_lbl = new System.Windows.Forms.Label();
            this.taskUpdate_lbl = new System.Windows.Forms.Label();
            this.clientDetails_tp = new System.Windows.Forms.TabPage();
            this.filterDetails_btn = new System.Windows.Forms.Button();
            this.serviceOverview_dgv = new System.Windows.Forms.DataGridView();
            this.serviceOverview_lbl = new System.Windows.Forms.Label();
            this.clientDetails_dgv = new System.Windows.Forms.DataGridView();
            this.clientDetails_lbl = new System.Windows.Forms.Label();
            this.Schedule_tp = new System.Windows.Forms.TabPage();
            this.Schedule_dgv = new System.Windows.Forms.DataGridView();
            this.Schedule_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.status_cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.Technical_tc.SuspendLayout();
            this.taskList_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskList_dgv)).BeginInit();
            this.taskUpdates_tp.SuspendLayout();
            this.clientDetails_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOverview_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetails_dgv)).BeginInit();
            this.Schedule_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(12, 9);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(76, 61);
            this.Logo_img.TabIndex = 10;
            this.Logo_img.TabStop = false;
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.ForeColor = System.Drawing.Color.Black;
            this.Welcome_lbl.Location = new System.Drawing.Point(94, 26);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(546, 32);
            this.Welcome_lbl.TabIndex = 11;
            this.Welcome_lbl.Text = "Welcome back <Name> <Surname> (Technician )";
            // 
            // Technical_tc
            // 
            this.Technical_tc.Controls.Add(this.taskList_tp);
            this.Technical_tc.Controls.Add(this.taskUpdates_tp);
            this.Technical_tc.Controls.Add(this.clientDetails_tp);
            this.Technical_tc.Controls.Add(this.Schedule_tp);
            this.Technical_tc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technical_tc.Location = new System.Drawing.Point(12, 100);
            this.Technical_tc.Multiline = true;
            this.Technical_tc.Name = "Technical_tc";
            this.Technical_tc.SelectedIndex = 0;
            this.Technical_tc.Size = new System.Drawing.Size(873, 456);
            this.Technical_tc.TabIndex = 12;
            // 
            // taskList_tp
            // 
            this.taskList_tp.Controls.Add(this.taskList_dgv);
            this.taskList_tp.Controls.Add(this.TLMInfo_lbl);
            this.taskList_tp.Controls.Add(this.TLM_lbl);
            this.taskList_tp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskList_tp.Location = new System.Drawing.Point(4, 39);
            this.taskList_tp.Name = "taskList_tp";
            this.taskList_tp.Padding = new System.Windows.Forms.Padding(3);
            this.taskList_tp.Size = new System.Drawing.Size(865, 413);
            this.taskList_tp.TabIndex = 0;
            this.taskList_tp.Text = "Task List";
            this.taskList_tp.UseVisualStyleBackColor = true;
            // 
            // taskList_dgv
            // 
            this.taskList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskList_dgv.Location = new System.Drawing.Point(8, 82);
            this.taskList_dgv.Name = "taskList_dgv";
            this.taskList_dgv.Size = new System.Drawing.Size(843, 270);
            this.taskList_dgv.TabIndex = 16;
            // 
            // TLMInfo_lbl
            // 
            this.TLMInfo_lbl.AutoSize = true;
            this.TLMInfo_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLMInfo_lbl.ForeColor = System.Drawing.Color.Black;
            this.TLMInfo_lbl.Location = new System.Drawing.Point(3, 44);
            this.TLMInfo_lbl.Name = "TLMInfo_lbl";
            this.TLMInfo_lbl.Size = new System.Drawing.Size(361, 25);
            this.TLMInfo_lbl.TabIndex = 15;
            this.TLMInfo_lbl.Text = "Efficiently Monitor Assigned Service Tasks";
            // 
            // TLM_lbl
            // 
            this.TLM_lbl.AutoSize = true;
            this.TLM_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLM_lbl.ForeColor = System.Drawing.Color.Black;
            this.TLM_lbl.Location = new System.Drawing.Point(3, 14);
            this.TLM_lbl.Name = "TLM_lbl";
            this.TLM_lbl.Size = new System.Drawing.Size(219, 30);
            this.TLM_lbl.TabIndex = 14;
            this.TLM_lbl.Text = "Task List Management";
            // 
            // taskUpdates_tp
            // 
            this.taskUpdates_tp.Controls.Add(this.status_cbx);
            this.taskUpdates_tp.Controls.Add(this.jobStatus_lbl);
            this.taskUpdates_tp.Controls.Add(this.jobNotes_lbl);
            this.taskUpdates_tp.Controls.Add(this.jobNotes_rtb);
            this.taskUpdates_tp.Controls.Add(this.submitUpdate_btn);
            this.taskUpdates_tp.Controls.Add(this.searchJob_btn);
            this.taskUpdates_tp.Controls.Add(this.jobID_txt);
            this.taskUpdates_tp.Controls.Add(this.JobID_lbl);
            this.taskUpdates_tp.Controls.Add(this.taskUpdateInfo_lbl);
            this.taskUpdates_tp.Controls.Add(this.taskUpdate_lbl);
            this.taskUpdates_tp.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.taskUpdates_tp.Location = new System.Drawing.Point(4, 39);
            this.taskUpdates_tp.Name = "taskUpdates_tp";
            this.taskUpdates_tp.Padding = new System.Windows.Forms.Padding(3);
            this.taskUpdates_tp.Size = new System.Drawing.Size(865, 413);
            this.taskUpdates_tp.TabIndex = 1;
            this.taskUpdates_tp.Text = "Task Updates";
            this.taskUpdates_tp.UseVisualStyleBackColor = true;
            // 
            // jobStatus_lbl
            // 
            this.jobStatus_lbl.AutoSize = true;
            this.jobStatus_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobStatus_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.jobStatus_lbl.Location = new System.Drawing.Point(295, 243);
            this.jobStatus_lbl.Name = "jobStatus_lbl";
            this.jobStatus_lbl.Size = new System.Drawing.Size(80, 21);
            this.jobStatus_lbl.TabIndex = 24;
            this.jobStatus_lbl.Text = "Job Status";
            // 
            // jobNotes_lbl
            // 
            this.jobNotes_lbl.AutoSize = true;
            this.jobNotes_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNotes_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.jobNotes_lbl.Location = new System.Drawing.Point(295, 84);
            this.jobNotes_lbl.Name = "jobNotes_lbl";
            this.jobNotes_lbl.Size = new System.Drawing.Size(79, 21);
            this.jobNotes_lbl.TabIndex = 23;
            this.jobNotes_lbl.Text = "Job Notes";
            // 
            // jobNotes_rtb
            // 
            this.jobNotes_rtb.Location = new System.Drawing.Point(297, 108);
            this.jobNotes_rtb.Name = "jobNotes_rtb";
            this.jobNotes_rtb.Size = new System.Drawing.Size(531, 119);
            this.jobNotes_rtb.TabIndex = 22;
            this.jobNotes_rtb.Text = "";
            // 
            // submitUpdate_btn
            // 
            this.submitUpdate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.submitUpdate_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitUpdate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitUpdate_btn.FlatAppearance.BorderSize = 0;
            this.submitUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitUpdate_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdate_btn.ForeColor = System.Drawing.Color.White;
            this.submitUpdate_btn.Location = new System.Drawing.Point(297, 329);
            this.submitUpdate_btn.Name = "submitUpdate_btn";
            this.submitUpdate_btn.Size = new System.Drawing.Size(158, 35);
            this.submitUpdate_btn.TabIndex = 21;
            this.submitUpdate_btn.Text = "Submit";
            this.submitUpdate_btn.UseVisualStyleBackColor = false;
            this.submitUpdate_btn.Click += new System.EventHandler(this.submitUpdate_btn_Click);
            // 
            // searchJob_btn
            // 
            this.searchJob_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.searchJob_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchJob_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchJob_btn.FlatAppearance.BorderSize = 0;
            this.searchJob_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchJob_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJob_btn.Location = new System.Drawing.Point(11, 156);
            this.searchJob_btn.Name = "searchJob_btn";
            this.searchJob_btn.Size = new System.Drawing.Size(158, 35);
            this.searchJob_btn.TabIndex = 20;
            this.searchJob_btn.Text = "Search";
            this.searchJob_btn.UseVisualStyleBackColor = false;
            // 
            // jobID_txt
            // 
            this.jobID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jobID_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobID_txt.Location = new System.Drawing.Point(11, 108);
            this.jobID_txt.Name = "jobID_txt";
            this.jobID_txt.Size = new System.Drawing.Size(158, 29);
            this.jobID_txt.TabIndex = 19;
            this.jobID_txt.Tag = "";
            // 
            // JobID_lbl
            // 
            this.JobID_lbl.AutoSize = true;
            this.JobID_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.JobID_lbl.Location = new System.Drawing.Point(7, 84);
            this.JobID_lbl.Name = "JobID_lbl";
            this.JobID_lbl.Size = new System.Drawing.Size(53, 21);
            this.JobID_lbl.TabIndex = 18;
            this.JobID_lbl.Text = "Job ID";
            // 
            // taskUpdateInfo_lbl
            // 
            this.taskUpdateInfo_lbl.AutoSize = true;
            this.taskUpdateInfo_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskUpdateInfo_lbl.ForeColor = System.Drawing.Color.Black;
            this.taskUpdateInfo_lbl.Location = new System.Drawing.Point(6, 44);
            this.taskUpdateInfo_lbl.Name = "taskUpdateInfo_lbl";
            this.taskUpdateInfo_lbl.Size = new System.Drawing.Size(558, 25);
            this.taskUpdateInfo_lbl.TabIndex = 17;
            this.taskUpdateInfo_lbl.Text = "Real-time Status Monitoring and Collaborative Task Management";
            // 
            // taskUpdate_lbl
            // 
            this.taskUpdate_lbl.AutoSize = true;
            this.taskUpdate_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskUpdate_lbl.ForeColor = System.Drawing.Color.Black;
            this.taskUpdate_lbl.Location = new System.Drawing.Point(6, 14);
            this.taskUpdate_lbl.Name = "taskUpdate_lbl";
            this.taskUpdate_lbl.Size = new System.Drawing.Size(342, 30);
            this.taskUpdate_lbl.TabIndex = 16;
            this.taskUpdate_lbl.Text = "Task Updates and Progress Tracking";
            // 
            // clientDetails_tp
            // 
            this.clientDetails_tp.Controls.Add(this.filterDetails_btn);
            this.clientDetails_tp.Controls.Add(this.serviceOverview_dgv);
            this.clientDetails_tp.Controls.Add(this.serviceOverview_lbl);
            this.clientDetails_tp.Controls.Add(this.clientDetails_dgv);
            this.clientDetails_tp.Controls.Add(this.clientDetails_lbl);
            this.clientDetails_tp.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.clientDetails_tp.Location = new System.Drawing.Point(4, 39);
            this.clientDetails_tp.Name = "clientDetails_tp";
            this.clientDetails_tp.Size = new System.Drawing.Size(865, 413);
            this.clientDetails_tp.TabIndex = 2;
            this.clientDetails_tp.Text = "Client Details";
            this.clientDetails_tp.UseVisualStyleBackColor = true;
            // 
            // filterDetails_btn
            // 
            this.filterDetails_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.filterDetails_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filterDetails_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterDetails_btn.FlatAppearance.BorderSize = 0;
            this.filterDetails_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterDetails_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDetails_btn.Location = new System.Drawing.Point(693, 20);
            this.filterDetails_btn.Name = "filterDetails_btn";
            this.filterDetails_btn.Size = new System.Drawing.Size(158, 35);
            this.filterDetails_btn.TabIndex = 23;
            this.filterDetails_btn.Text = "Filter";
            this.filterDetails_btn.UseVisualStyleBackColor = false;
            // 
            // serviceOverview_dgv
            // 
            this.serviceOverview_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceOverview_dgv.Location = new System.Drawing.Point(8, 264);
            this.serviceOverview_dgv.Name = "serviceOverview_dgv";
            this.serviceOverview_dgv.Size = new System.Drawing.Size(843, 134);
            this.serviceOverview_dgv.TabIndex = 22;
            // 
            // serviceOverview_lbl
            // 
            this.serviceOverview_lbl.AutoSize = true;
            this.serviceOverview_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceOverview_lbl.ForeColor = System.Drawing.Color.Black;
            this.serviceOverview_lbl.Location = new System.Drawing.Point(3, 231);
            this.serviceOverview_lbl.Name = "serviceOverview_lbl";
            this.serviceOverview_lbl.Size = new System.Drawing.Size(169, 30);
            this.serviceOverview_lbl.TabIndex = 21;
            this.serviceOverview_lbl.Text = "Service Overview";
            // 
            // clientDetails_dgv
            // 
            this.clientDetails_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDetails_dgv.Location = new System.Drawing.Point(8, 71);
            this.clientDetails_dgv.Name = "clientDetails_dgv";
            this.clientDetails_dgv.Size = new System.Drawing.Size(838, 134);
            this.clientDetails_dgv.TabIndex = 20;
            // 
            // clientDetails_lbl
            // 
            this.clientDetails_lbl.AutoSize = true;
            this.clientDetails_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetails_lbl.ForeColor = System.Drawing.Color.Black;
            this.clientDetails_lbl.Location = new System.Drawing.Point(3, 34);
            this.clientDetails_lbl.Name = "clientDetails_lbl";
            this.clientDetails_lbl.Size = new System.Drawing.Size(135, 30);
            this.clientDetails_lbl.TabIndex = 18;
            this.clientDetails_lbl.Text = "Client Details";
            // 
            // Schedule_tp
            // 
            this.Schedule_tp.Controls.Add(this.Schedule_dgv);
            this.Schedule_tp.Controls.Add(this.Schedule_lbl);
            this.Schedule_tp.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Schedule_tp.Location = new System.Drawing.Point(4, 39);
            this.Schedule_tp.Name = "Schedule_tp";
            this.Schedule_tp.Size = new System.Drawing.Size(865, 413);
            this.Schedule_tp.TabIndex = 3;
            this.Schedule_tp.Text = "Schedule";
            this.Schedule_tp.UseVisualStyleBackColor = true;
            // 
            // Schedule_dgv
            // 
            this.Schedule_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schedule_dgv.Location = new System.Drawing.Point(8, 61);
            this.Schedule_dgv.Name = "Schedule_dgv";
            this.Schedule_dgv.Size = new System.Drawing.Size(843, 307);
            this.Schedule_dgv.TabIndex = 21;
            this.Schedule_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schedule_dgv_CellDoubleClick);
            // 
            // Schedule_lbl
            // 
            this.Schedule_lbl.AutoSize = true;
            this.Schedule_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_lbl.ForeColor = System.Drawing.Color.Black;
            this.Schedule_lbl.Location = new System.Drawing.Point(3, 17);
            this.Schedule_lbl.Name = "Schedule_lbl";
            this.Schedule_lbl.Size = new System.Drawing.Size(97, 30);
            this.Schedule_lbl.TabIndex = 20;
            this.Schedule_lbl.Text = "Schedule";
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
            this.Logout_btn.TabIndex = 13;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // status_cbx
            // 
            this.status_cbx.FormattingEnabled = true;
            this.status_cbx.Location = new System.Drawing.Point(299, 267);
            this.status_cbx.Name = "status_cbx";
            this.status_cbx.Size = new System.Drawing.Size(156, 40);
            this.status_cbx.TabIndex = 25;
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Technical_tc);
            this.Controls.Add(this.Welcome_lbl);
            this.Controls.Add(this.Logo_img);
            this.Name = "Technician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechnicianForm";
            this.Load += new System.EventHandler(this.Technician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.Technical_tc.ResumeLayout(false);
            this.taskList_tp.ResumeLayout(false);
            this.taskList_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskList_dgv)).EndInit();
            this.taskUpdates_tp.ResumeLayout(false);
            this.taskUpdates_tp.PerformLayout();
            this.clientDetails_tp.ResumeLayout(false);
            this.clientDetails_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOverview_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetails_dgv)).EndInit();
            this.Schedule_tp.ResumeLayout(false);
            this.Schedule_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.TabControl Technical_tc;
        private System.Windows.Forms.TabPage taskList_tp;
        private System.Windows.Forms.TabPage taskUpdates_tp;
        private System.Windows.Forms.TabPage clientDetails_tp;
        private System.Windows.Forms.TabPage Schedule_tp;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label TLM_lbl;
        private System.Windows.Forms.DataGridView taskList_dgv;
        private System.Windows.Forms.Label TLMInfo_lbl;
        private System.Windows.Forms.Label taskUpdateInfo_lbl;
        private System.Windows.Forms.Label taskUpdate_lbl;
        private System.Windows.Forms.TextBox jobID_txt;
        private System.Windows.Forms.Label JobID_lbl;
        private System.Windows.Forms.Label jobStatus_lbl;
        private System.Windows.Forms.Label jobNotes_lbl;
        private System.Windows.Forms.RichTextBox jobNotes_rtb;
        private System.Windows.Forms.Button submitUpdate_btn;
        private System.Windows.Forms.Button searchJob_btn;
        private System.Windows.Forms.Label clientDetails_lbl;
        private System.Windows.Forms.DataGridView serviceOverview_dgv;
        private System.Windows.Forms.Label serviceOverview_lbl;
        private System.Windows.Forms.DataGridView clientDetails_dgv;
        private System.Windows.Forms.Button filterDetails_btn;
        private System.Windows.Forms.DataGridView Schedule_dgv;
        private System.Windows.Forms.Label Schedule_lbl;
        private System.Windows.Forms.ComboBox status_cbx;
    }
}