namespace PSS_ITWORKS.Presentation_Layer
{
    partial class ModifyJobs
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
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Search_gbx = new System.Windows.Forms.GroupBox();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Technician_gbx = new System.Windows.Forms.GroupBox();
            this.JobInfo_gbx = new System.Windows.Forms.GroupBox();
            this.EquipmentSerialNr_lbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EquepmentSerialNr_txt = new System.Windows.Forms.TextBox();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.ServiceType_lbl = new System.Windows.Forms.Label();
            this.ScheduleDate_lbl = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.Priority_cbx = new System.Windows.Forms.ComboBox();
            this.ServiceType_cbx = new System.Windows.Forms.ComboBox();
            this.ScheduleDateFrom_txt = new System.Windows.Forms.TextBox();
            this.ScheduleDateTo_txt = new System.Windows.Forms.TextBox();
            this.Description_rtb = new System.Windows.Forms.RichTextBox();
            this.Technician1_cbx = new System.Windows.Forms.ComboBox();
            this.Technician2_cbx = new System.Windows.Forms.ComboBox();
            this.Technician3_cbx = new System.Windows.Forms.ComboBox();
            this.Technician4_cbx = new System.Windows.Forms.ComboBox();
            this.Technician5_cbx = new System.Windows.Forms.ComboBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.Search_gbx.SuspendLayout();
            this.Technician_gbx.SuspendLayout();
            this.JobInfo_gbx.SuspendLayout();
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
            this.PSS_lbl.Size = new System.Drawing.Size(746, 41);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back <name> <surname> (Service Maneger)";
            // 
            // Search_gbx
            // 
            this.Search_gbx.Controls.Add(this.Search_btn);
            this.Search_gbx.Controls.Add(this.textBox1);
            this.Search_gbx.Controls.Add(this.Search_lbl);
            this.Search_gbx.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_gbx.Location = new System.Drawing.Point(16, 122);
            this.Search_gbx.Name = "Search_gbx";
            this.Search_gbx.Size = new System.Drawing.Size(1203, 98);
            this.Search_gbx.TabIndex = 2;
            this.Search_gbx.TabStop = false;
            this.Search_gbx.Text = "Search";
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_lbl.Location = new System.Drawing.Point(42, 48);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(124, 25);
            this.Search_lbl.TabIndex = 0;
            this.Search_lbl.Text = "Search Job ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 38);
            this.textBox1.TabIndex = 1;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.Search_btn.Location = new System.Drawing.Point(485, 37);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(211, 43);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            // 
            // Technician_gbx
            // 
            this.Technician_gbx.Controls.Add(this.Technician5_cbx);
            this.Technician_gbx.Controls.Add(this.Technician4_cbx);
            this.Technician_gbx.Controls.Add(this.Technician3_cbx);
            this.Technician_gbx.Controls.Add(this.Technician2_cbx);
            this.Technician_gbx.Controls.Add(this.Technician1_cbx);
            this.Technician_gbx.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician_gbx.Location = new System.Drawing.Point(63, 245);
            this.Technician_gbx.Name = "Technician_gbx";
            this.Technician_gbx.Size = new System.Drawing.Size(248, 432);
            this.Technician_gbx.TabIndex = 3;
            this.Technician_gbx.TabStop = false;
            this.Technician_gbx.Text = "Technician";
            // 
            // JobInfo_gbx
            // 
            this.JobInfo_gbx.Controls.Add(this.Description_rtb);
            this.JobInfo_gbx.Controls.Add(this.ScheduleDateTo_txt);
            this.JobInfo_gbx.Controls.Add(this.ScheduleDateFrom_txt);
            this.JobInfo_gbx.Controls.Add(this.ServiceType_cbx);
            this.JobInfo_gbx.Controls.Add(this.Priority_cbx);
            this.JobInfo_gbx.Controls.Add(this.Description_lbl);
            this.JobInfo_gbx.Controls.Add(this.ScheduleDate_lbl);
            this.JobInfo_gbx.Controls.Add(this.ServiceType_lbl);
            this.JobInfo_gbx.Controls.Add(this.Priority_lbl);
            this.JobInfo_gbx.Controls.Add(this.EquepmentSerialNr_txt);
            this.JobInfo_gbx.Controls.Add(this.EquipmentSerialNr_lbl);
            this.JobInfo_gbx.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobInfo_gbx.Location = new System.Drawing.Point(377, 245);
            this.JobInfo_gbx.Name = "JobInfo_gbx";
            this.JobInfo_gbx.Size = new System.Drawing.Size(811, 341);
            this.JobInfo_gbx.TabIndex = 4;
            this.JobInfo_gbx.TabStop = false;
            this.JobInfo_gbx.Text = "Job Information";
            // 
            // EquipmentSerialNr_lbl
            // 
            this.EquipmentSerialNr_lbl.AutoSize = true;
            this.EquipmentSerialNr_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentSerialNr_lbl.ForeColor = System.Drawing.Color.Blue;
            this.EquipmentSerialNr_lbl.Location = new System.Drawing.Point(44, 38);
            this.EquipmentSerialNr_lbl.Name = "EquipmentSerialNr_lbl";
            this.EquipmentSerialNr_lbl.Size = new System.Drawing.Size(163, 23);
            this.EquipmentSerialNr_lbl.TabIndex = 0;
            this.EquipmentSerialNr_lbl.Text = "Equipment Serial Nr";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EquepmentSerialNr_txt
            // 
            this.EquepmentSerialNr_txt.Location = new System.Drawing.Point(48, 64);
            this.EquepmentSerialNr_txt.Name = "EquepmentSerialNr_txt";
            this.EquepmentSerialNr_txt.Size = new System.Drawing.Size(212, 38);
            this.EquepmentSerialNr_txt.TabIndex = 2;
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Priority_lbl.Location = new System.Drawing.Point(44, 115);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(64, 23);
            this.Priority_lbl.TabIndex = 3;
            this.Priority_lbl.Text = "Priority";
            // 
            // ServiceType_lbl
            // 
            this.ServiceType_lbl.AutoSize = true;
            this.ServiceType_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceType_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ServiceType_lbl.Location = new System.Drawing.Point(44, 191);
            this.ServiceType_lbl.Name = "ServiceType_lbl";
            this.ServiceType_lbl.Size = new System.Drawing.Size(103, 23);
            this.ServiceType_lbl.TabIndex = 4;
            this.ServiceType_lbl.Text = "Service Type";
            // 
            // ScheduleDate_lbl
            // 
            this.ScheduleDate_lbl.AutoSize = true;
            this.ScheduleDate_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleDate_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ScheduleDate_lbl.Location = new System.Drawing.Point(44, 258);
            this.ScheduleDate_lbl.Name = "ScheduleDate_lbl";
            this.ScheduleDate_lbl.Size = new System.Drawing.Size(220, 23);
            this.ScheduleDate_lbl.TabIndex = 5;
            this.ScheduleDate_lbl.Text = "Schedule Date: Time - Time";
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Description_lbl.Location = new System.Drawing.Point(331, 34);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(174, 23);
            this.Description_lbl.TabIndex = 6;
            this.Description_lbl.Text = "Description of Service";
            // 
            // Priority_cbx
            // 
            this.Priority_cbx.FormattingEnabled = true;
            this.Priority_cbx.Location = new System.Drawing.Point(48, 141);
            this.Priority_cbx.Name = "Priority_cbx";
            this.Priority_cbx.Size = new System.Drawing.Size(212, 39);
            this.Priority_cbx.TabIndex = 7;
            // 
            // ServiceType_cbx
            // 
            this.ServiceType_cbx.FormattingEnabled = true;
            this.ServiceType_cbx.Location = new System.Drawing.Point(48, 217);
            this.ServiceType_cbx.Name = "ServiceType_cbx";
            this.ServiceType_cbx.Size = new System.Drawing.Size(212, 39);
            this.ServiceType_cbx.TabIndex = 8;
            // 
            // ScheduleDateFrom_txt
            // 
            this.ScheduleDateFrom_txt.Location = new System.Drawing.Point(48, 284);
            this.ScheduleDateFrom_txt.Name = "ScheduleDateFrom_txt";
            this.ScheduleDateFrom_txt.Size = new System.Drawing.Size(212, 38);
            this.ScheduleDateFrom_txt.TabIndex = 9;
            // 
            // ScheduleDateTo_txt
            // 
            this.ScheduleDateTo_txt.Location = new System.Drawing.Point(335, 284);
            this.ScheduleDateTo_txt.Name = "ScheduleDateTo_txt";
            this.ScheduleDateTo_txt.Size = new System.Drawing.Size(212, 38);
            this.ScheduleDateTo_txt.TabIndex = 10;
            // 
            // Description_rtb
            // 
            this.Description_rtb.Location = new System.Drawing.Point(335, 64);
            this.Description_rtb.Name = "Description_rtb";
            this.Description_rtb.Size = new System.Drawing.Size(440, 192);
            this.Description_rtb.TabIndex = 11;
            this.Description_rtb.Text = "";
            // 
            // Technician1_cbx
            // 
            this.Technician1_cbx.FormattingEnabled = true;
            this.Technician1_cbx.Location = new System.Drawing.Point(18, 36);
            this.Technician1_cbx.Name = "Technician1_cbx";
            this.Technician1_cbx.Size = new System.Drawing.Size(212, 39);
            this.Technician1_cbx.TabIndex = 0;
            // 
            // Technician2_cbx
            // 
            this.Technician2_cbx.FormattingEnabled = true;
            this.Technician2_cbx.Location = new System.Drawing.Point(18, 99);
            this.Technician2_cbx.Name = "Technician2_cbx";
            this.Technician2_cbx.Size = new System.Drawing.Size(212, 39);
            this.Technician2_cbx.TabIndex = 1;
            // 
            // Technician3_cbx
            // 
            this.Technician3_cbx.FormattingEnabled = true;
            this.Technician3_cbx.Location = new System.Drawing.Point(18, 158);
            this.Technician3_cbx.Name = "Technician3_cbx";
            this.Technician3_cbx.Size = new System.Drawing.Size(212, 39);
            this.Technician3_cbx.TabIndex = 2;
            // 
            // Technician4_cbx
            // 
            this.Technician4_cbx.FormattingEnabled = true;
            this.Technician4_cbx.Location = new System.Drawing.Point(18, 217);
            this.Technician4_cbx.Name = "Technician4_cbx";
            this.Technician4_cbx.Size = new System.Drawing.Size(212, 39);
            this.Technician4_cbx.TabIndex = 3;
            // 
            // Technician5_cbx
            // 
            this.Technician5_cbx.FormattingEnabled = true;
            this.Technician5_cbx.Location = new System.Drawing.Point(18, 283);
            this.Technician5_cbx.Name = "Technician5_cbx";
            this.Technician5_cbx.Size = new System.Drawing.Size(212, 39);
            this.Technician5_cbx.TabIndex = 4;
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.Submit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(377, 615);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(211, 43);
            this.Submit_btn.TabIndex = 6;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(660, 615);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(211, 43);
            this.Delete_btn.TabIndex = 7;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(941, 615);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(211, 43);
            this.Close_btn.TabIndex = 8;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            // 
            // ModifyJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 689);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.JobInfo_gbx);
            this.Controls.Add(this.Technician_gbx);
            this.Controls.Add(this.Search_gbx);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.PSS_img);
            this.Name = "ModifyJobs";
            this.Text = "ModifyJobs";
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.Search_gbx.ResumeLayout(false);
            this.Search_gbx.PerformLayout();
            this.Technician_gbx.ResumeLayout(false);
            this.JobInfo_gbx.ResumeLayout(false);
            this.JobInfo_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.GroupBox Search_gbx;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search_lbl;
        private System.Windows.Forms.GroupBox Technician_gbx;
        private System.Windows.Forms.ComboBox Technician5_cbx;
        private System.Windows.Forms.ComboBox Technician4_cbx;
        private System.Windows.Forms.ComboBox Technician3_cbx;
        private System.Windows.Forms.ComboBox Technician2_cbx;
        private System.Windows.Forms.ComboBox Technician1_cbx;
        private System.Windows.Forms.GroupBox JobInfo_gbx;
        private System.Windows.Forms.RichTextBox Description_rtb;
        private System.Windows.Forms.TextBox ScheduleDateTo_txt;
        private System.Windows.Forms.TextBox ScheduleDateFrom_txt;
        private System.Windows.Forms.ComboBox ServiceType_cbx;
        private System.Windows.Forms.ComboBox Priority_cbx;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.Label ScheduleDate_lbl;
        private System.Windows.Forms.Label ServiceType_lbl;
        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.TextBox EquepmentSerialNr_txt;
        private System.Windows.Forms.Label EquipmentSerialNr_lbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Close_btn;
    }
}