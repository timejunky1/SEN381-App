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
            this.Schedule_tp = new System.Windows.Forms.TabPage();
            this.Technicians_tp = new System.Windows.Forms.TabPage();
            this.Jobs_tp = new System.Windows.Forms.TabPage();
            this.AssignementRequest_lbl = new System.Windows.Forms.Label();
            this.Schedule_lbl = new System.Windows.Forms.Label();
            this.Request_dgv = new System.Windows.Forms.DataGridView();
            this.Schedule_dgv = new System.Windows.Forms.DataGridView();
            this.Assignement_dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.ServiceManager_tc.SuspendLayout();
            this.Assignment_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PSS_img
            // 
            this.PSS_img.Location = new System.Drawing.Point(16, 11);
            this.PSS_img.Name = "PSS_img";
            this.PSS_img.Size = new System.Drawing.Size(101, 75);
            this.PSS_img.TabIndex = 0;
            this.PSS_img.TabStop = false;
            // 
            // PSS_lbl
            // 
            this.PSS_lbl.AutoSize = true;
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.Location = new System.Drawing.Point(125, 32);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(745, 41);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back <name> <surname> (Service Manager)";
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(999, 32);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(157, 44);
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
            this.ServiceManager_tc.Location = new System.Drawing.Point(16, 116);
            this.ServiceManager_tc.Name = "ServiceManager_tc";
            this.ServiceManager_tc.SelectedIndex = 0;
            this.ServiceManager_tc.Size = new System.Drawing.Size(1164, 561);
            this.ServiceManager_tc.TabIndex = 3;
            // 
            // Assignment_tp
            // 
            this.Assignment_tp.Controls.Add(this.Assignement_dtp);
            this.Assignment_tp.Controls.Add(this.Schedule_dgv);
            this.Assignment_tp.Controls.Add(this.Request_dgv);
            this.Assignment_tp.Controls.Add(this.Schedule_lbl);
            this.Assignment_tp.Controls.Add(this.AssignementRequest_lbl);
            this.Assignment_tp.Location = new System.Drawing.Point(4, 40);
            this.Assignment_tp.Name = "Assignment_tp";
            this.Assignment_tp.Padding = new System.Windows.Forms.Padding(3);
            this.Assignment_tp.Size = new System.Drawing.Size(1156, 517);
            this.Assignment_tp.TabIndex = 0;
            this.Assignment_tp.Text = "Assignment";
            this.Assignment_tp.UseVisualStyleBackColor = true;
            // 
            // Schedule_tp
            // 
            this.Schedule_tp.Location = new System.Drawing.Point(4, 40);
            this.Schedule_tp.Name = "Schedule_tp";
            this.Schedule_tp.Padding = new System.Windows.Forms.Padding(3);
            this.Schedule_tp.Size = new System.Drawing.Size(1156, 517);
            this.Schedule_tp.TabIndex = 1;
            this.Schedule_tp.Text = "Schedule";
            this.Schedule_tp.UseVisualStyleBackColor = true;
            // 
            // Technicians_tp
            // 
            this.Technicians_tp.Location = new System.Drawing.Point(4, 40);
            this.Technicians_tp.Name = "Technicians_tp";
            this.Technicians_tp.Size = new System.Drawing.Size(1156, 517);
            this.Technicians_tp.TabIndex = 2;
            this.Technicians_tp.Text = "Technicians";
            this.Technicians_tp.UseVisualStyleBackColor = true;
            // 
            // Jobs_tp
            // 
            this.Jobs_tp.Location = new System.Drawing.Point(4, 40);
            this.Jobs_tp.Name = "Jobs_tp";
            this.Jobs_tp.Size = new System.Drawing.Size(1156, 517);
            this.Jobs_tp.TabIndex = 3;
            this.Jobs_tp.Text = "Jobs";
            this.Jobs_tp.UseVisualStyleBackColor = true;
            // 
            // AssignementRequest_lbl
            // 
            this.AssignementRequest_lbl.AutoSize = true;
            this.AssignementRequest_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignementRequest_lbl.Location = new System.Drawing.Point(28, 15);
            this.AssignementRequest_lbl.Name = "AssignementRequest_lbl";
            this.AssignementRequest_lbl.Size = new System.Drawing.Size(88, 25);
            this.AssignementRequest_lbl.TabIndex = 0;
            this.AssignementRequest_lbl.Text = "Requests";
            // 
            // Schedule_lbl
            // 
            this.Schedule_lbl.AutoSize = true;
            this.Schedule_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_lbl.Location = new System.Drawing.Point(593, 15);
            this.Schedule_lbl.Name = "Schedule_lbl";
            this.Schedule_lbl.Size = new System.Drawing.Size(87, 25);
            this.Schedule_lbl.TabIndex = 1;
            this.Schedule_lbl.Text = "Schedule";
            // 
            // Request_dgv
            // 
            this.Request_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Request_dgv.Location = new System.Drawing.Point(33, 58);
            this.Request_dgv.Name = "Request_dgv";
            this.Request_dgv.RowHeadersWidth = 51;
            this.Request_dgv.RowTemplate.Height = 24;
            this.Request_dgv.Size = new System.Drawing.Size(534, 425);
            this.Request_dgv.TabIndex = 2;
            // 
            // Schedule_dgv
            // 
            this.Schedule_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schedule_dgv.Location = new System.Drawing.Point(598, 58);
            this.Schedule_dgv.Name = "Schedule_dgv";
            this.Schedule_dgv.RowHeadersWidth = 51;
            this.Schedule_dgv.RowTemplate.Height = 24;
            this.Schedule_dgv.Size = new System.Drawing.Size(523, 346);
            this.Schedule_dgv.TabIndex = 3;
            // 
            // Assignement_dtp
            // 
            this.Assignement_dtp.Location = new System.Drawing.Point(748, 434);
            this.Assignement_dtp.Name = "Assignement_dtp";
            this.Assignement_dtp.Size = new System.Drawing.Size(212, 38);
            this.Assignement_dtp.TabIndex = 4;
            // 
            // ServiceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 689);
            this.Controls.Add(this.ServiceManager_tc);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.PSS_img);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServiceManagerForm";
            this.Text = "ServiceManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.ServiceManager_tc.ResumeLayout(false);
            this.Assignment_tp.ResumeLayout(false);
            this.Assignment_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_dgv)).EndInit();
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
        private System.Windows.Forms.DataGridView Schedule_dgv;
        private System.Windows.Forms.DataGridView Request_dgv;
        private System.Windows.Forms.Label Schedule_lbl;
        private System.Windows.Forms.Label AssignementRequest_lbl;
        private System.Windows.Forms.TabPage Schedule_tp;
        private System.Windows.Forms.TabPage Technicians_tp;
        private System.Windows.Forms.TabPage Jobs_tp;
    }
}