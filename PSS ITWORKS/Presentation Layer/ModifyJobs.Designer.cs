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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyJobs));
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Search_gbx = new System.Windows.Forms.GroupBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.Technician_gbx = new System.Windows.Forms.GroupBox();
            this.Technician5_cbx = new System.Windows.Forms.ComboBox();
            this.Technician4_cbx = new System.Windows.Forms.ComboBox();
            this.Technician3_cbx = new System.Windows.Forms.ComboBox();
            this.Technician2_cbx = new System.Windows.Forms.ComboBox();
            this.Technician1_cbx = new System.Windows.Forms.ComboBox();
            this.JobInfo_gbx = new System.Windows.Forms.GroupBox();
            this.endDate_lbl = new System.Windows.Forms.Label();
            this.startDate_lbl = new System.Windows.Forms.Label();
            this.Description_rtb = new System.Windows.Forms.RichTextBox();
            this.ScheduleDateTo_txt = new System.Windows.Forms.TextBox();
            this.ScheduleDateFrom_txt = new System.Windows.Forms.TextBox();
            this.ServiceType_cbx = new System.Windows.Forms.ComboBox();
            this.Priority_cbx = new System.Windows.Forms.ComboBox();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.ScheduleDate_lbl = new System.Windows.Forms.Label();
            this.ServiceType_lbl = new System.Windows.Forms.Label();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.EquepmentSerialNr_txt = new System.Windows.Forms.TextBox();
            this.EquipmentSerialNr_lbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.PSS_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PSS_img.BackgroundImage")));
            this.PSS_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PSS_img.Location = new System.Drawing.Point(12, 9);
            this.PSS_img.Margin = new System.Windows.Forms.Padding(2);
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
            this.PSS_lbl.Size = new System.Drawing.Size(606, 32);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back <Name> <Surname> (Service Maneger)";
            // 
            // Search_gbx
            // 
            this.Search_gbx.Controls.Add(this.Search_btn);
            this.Search_gbx.Controls.Add(this.textBox1);
            this.Search_gbx.Controls.Add(this.Search_lbl);
            this.Search_gbx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_gbx.Location = new System.Drawing.Point(12, 99);
            this.Search_gbx.Margin = new System.Windows.Forms.Padding(2);
            this.Search_gbx.Name = "Search_gbx";
            this.Search_gbx.Padding = new System.Windows.Forms.Padding(2);
            this.Search_gbx.Size = new System.Drawing.Size(902, 80);
            this.Search_gbx.TabIndex = 2;
            this.Search_gbx.TabStop = false;
            this.Search_gbx.Text = "Search Job";
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(721, 32);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(158, 35);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 29);
            this.textBox1.TabIndex = 1;
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Search_lbl.Location = new System.Drawing.Point(32, 39);
            this.Search_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(53, 21);
            this.Search_lbl.TabIndex = 0;
            this.Search_lbl.Text = "Job ID";
            // 
            // Technician_gbx
            // 
            this.Technician_gbx.Controls.Add(this.Technician5_cbx);
            this.Technician_gbx.Controls.Add(this.Technician4_cbx);
            this.Technician_gbx.Controls.Add(this.Technician3_cbx);
            this.Technician_gbx.Controls.Add(this.Technician2_cbx);
            this.Technician_gbx.Controls.Add(this.Technician1_cbx);
            this.Technician_gbx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician_gbx.Location = new System.Drawing.Point(12, 183);
            this.Technician_gbx.Margin = new System.Windows.Forms.Padding(2);
            this.Technician_gbx.Name = "Technician_gbx";
            this.Technician_gbx.Padding = new System.Windows.Forms.Padding(2);
            this.Technician_gbx.Size = new System.Drawing.Size(186, 277);
            this.Technician_gbx.TabIndex = 3;
            this.Technician_gbx.TabStop = false;
            this.Technician_gbx.Text = "Technician";
            // 
            // Technician5_cbx
            // 
            this.Technician5_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician5_cbx.FormattingEnabled = true;
            this.Technician5_cbx.Location = new System.Drawing.Point(13, 219);
            this.Technician5_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Technician5_cbx.Name = "Technician5_cbx";
            this.Technician5_cbx.Size = new System.Drawing.Size(160, 29);
            this.Technician5_cbx.TabIndex = 4;
            // 
            // Technician4_cbx
            // 
            this.Technician4_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician4_cbx.FormattingEnabled = true;
            this.Technician4_cbx.Location = new System.Drawing.Point(13, 175);
            this.Technician4_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Technician4_cbx.Name = "Technician4_cbx";
            this.Technician4_cbx.Size = new System.Drawing.Size(160, 29);
            this.Technician4_cbx.TabIndex = 3;
            // 
            // Technician3_cbx
            // 
            this.Technician3_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician3_cbx.FormattingEnabled = true;
            this.Technician3_cbx.Location = new System.Drawing.Point(13, 128);
            this.Technician3_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Technician3_cbx.Name = "Technician3_cbx";
            this.Technician3_cbx.Size = new System.Drawing.Size(160, 29);
            this.Technician3_cbx.TabIndex = 2;
            // 
            // Technician2_cbx
            // 
            this.Technician2_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician2_cbx.FormattingEnabled = true;
            this.Technician2_cbx.Location = new System.Drawing.Point(13, 83);
            this.Technician2_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Technician2_cbx.Name = "Technician2_cbx";
            this.Technician2_cbx.Size = new System.Drawing.Size(160, 29);
            this.Technician2_cbx.TabIndex = 1;
            // 
            // Technician1_cbx
            // 
            this.Technician1_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technician1_cbx.FormattingEnabled = true;
            this.Technician1_cbx.Location = new System.Drawing.Point(13, 41);
            this.Technician1_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Technician1_cbx.Name = "Technician1_cbx";
            this.Technician1_cbx.Size = new System.Drawing.Size(160, 29);
            this.Technician1_cbx.TabIndex = 0;
            // 
            // JobInfo_gbx
            // 
            this.JobInfo_gbx.Controls.Add(this.endDate_lbl);
            this.JobInfo_gbx.Controls.Add(this.startDate_lbl);
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
            this.JobInfo_gbx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobInfo_gbx.Location = new System.Drawing.Point(227, 183);
            this.JobInfo_gbx.Margin = new System.Windows.Forms.Padding(2);
            this.JobInfo_gbx.Name = "JobInfo_gbx";
            this.JobInfo_gbx.Padding = new System.Windows.Forms.Padding(2);
            this.JobInfo_gbx.Size = new System.Drawing.Size(685, 314);
            this.JobInfo_gbx.TabIndex = 4;
            this.JobInfo_gbx.TabStop = false;
            this.JobInfo_gbx.Text = "Job Information";
            // 
            // endDate_lbl
            // 
            this.endDate_lbl.AutoSize = true;
            this.endDate_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.endDate_lbl.Location = new System.Drawing.Point(208, 241);
            this.endDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDate_lbl.Name = "endDate_lbl";
            this.endDate_lbl.Size = new System.Drawing.Size(72, 21);
            this.endDate_lbl.TabIndex = 13;
            this.endDate_lbl.Text = "End Date";
            // 
            // startDate_lbl
            // 
            this.startDate_lbl.AutoSize = true;
            this.startDate_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.startDate_lbl.Location = new System.Drawing.Point(8, 241);
            this.startDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDate_lbl.Name = "startDate_lbl";
            this.startDate_lbl.Size = new System.Drawing.Size(78, 21);
            this.startDate_lbl.TabIndex = 12;
            this.startDate_lbl.Text = "Start Date";
            // 
            // Description_rtb
            // 
            this.Description_rtb.Location = new System.Drawing.Point(252, 52);
            this.Description_rtb.Margin = new System.Windows.Forms.Padding(2);
            this.Description_rtb.Name = "Description_rtb";
            this.Description_rtb.Size = new System.Drawing.Size(412, 163);
            this.Description_rtb.TabIndex = 11;
            this.Description_rtb.Text = "";
            // 
            // ScheduleDateTo_txt
            // 
            this.ScheduleDateTo_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleDateTo_txt.Location = new System.Drawing.Point(210, 270);
            this.ScheduleDateTo_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ScheduleDateTo_txt.Name = "ScheduleDateTo_txt";
            this.ScheduleDateTo_txt.Size = new System.Drawing.Size(160, 29);
            this.ScheduleDateTo_txt.TabIndex = 10;
            // 
            // ScheduleDateFrom_txt
            // 
            this.ScheduleDateFrom_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleDateFrom_txt.Location = new System.Drawing.Point(12, 270);
            this.ScheduleDateFrom_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ScheduleDateFrom_txt.Name = "ScheduleDateFrom_txt";
            this.ScheduleDateFrom_txt.Size = new System.Drawing.Size(160, 29);
            this.ScheduleDateFrom_txt.TabIndex = 9;
            // 
            // ServiceType_cbx
            // 
            this.ServiceType_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceType_cbx.FormattingEnabled = true;
            this.ServiceType_cbx.Location = new System.Drawing.Point(12, 176);
            this.ServiceType_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceType_cbx.Name = "ServiceType_cbx";
            this.ServiceType_cbx.Size = new System.Drawing.Size(160, 29);
            this.ServiceType_cbx.TabIndex = 8;
            // 
            // Priority_cbx
            // 
            this.Priority_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_cbx.FormattingEnabled = true;
            this.Priority_cbx.Location = new System.Drawing.Point(12, 115);
            this.Priority_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.Priority_cbx.Name = "Priority_cbx";
            this.Priority_cbx.Size = new System.Drawing.Size(160, 29);
            this.Priority_cbx.TabIndex = 7;
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Description_lbl.Location = new System.Drawing.Point(248, 28);
            this.Description_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(161, 21);
            this.Description_lbl.TabIndex = 6;
            this.Description_lbl.Text = "Description of Service";
            // 
            // ScheduleDate_lbl
            // 
            this.ScheduleDate_lbl.AutoSize = true;
            this.ScheduleDate_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleDate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ScheduleDate_lbl.Location = new System.Drawing.Point(8, 219);
            this.ScheduleDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScheduleDate_lbl.Name = "ScheduleDate_lbl";
            this.ScheduleDate_lbl.Size = new System.Drawing.Size(109, 21);
            this.ScheduleDate_lbl.TabIndex = 5;
            this.ScheduleDate_lbl.Text = "Schedule Date";
            // 
            // ServiceType_lbl
            // 
            this.ServiceType_lbl.AutoSize = true;
            this.ServiceType_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceType_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ServiceType_lbl.Location = new System.Drawing.Point(8, 153);
            this.ServiceType_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceType_lbl.Name = "ServiceType_lbl";
            this.ServiceType_lbl.Size = new System.Drawing.Size(96, 21);
            this.ServiceType_lbl.TabIndex = 4;
            this.ServiceType_lbl.Text = "Service Type";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Priority_lbl.Location = new System.Drawing.Point(8, 92);
            this.Priority_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(61, 21);
            this.Priority_lbl.TabIndex = 3;
            this.Priority_lbl.Text = "Priority";
            // 
            // EquepmentSerialNr_txt
            // 
            this.EquepmentSerialNr_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquepmentSerialNr_txt.Location = new System.Drawing.Point(12, 52);
            this.EquepmentSerialNr_txt.Margin = new System.Windows.Forms.Padding(2);
            this.EquepmentSerialNr_txt.Name = "EquepmentSerialNr_txt";
            this.EquepmentSerialNr_txt.Size = new System.Drawing.Size(160, 29);
            this.EquepmentSerialNr_txt.TabIndex = 2;
            // 
            // EquipmentSerialNr_lbl
            // 
            this.EquipmentSerialNr_lbl.AutoSize = true;
            this.EquipmentSerialNr_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentSerialNr_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.EquipmentSerialNr_lbl.Location = new System.Drawing.Point(8, 30);
            this.EquipmentSerialNr_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EquipmentSerialNr_lbl.Name = "EquipmentSerialNr_lbl";
            this.EquipmentSerialNr_lbl.Size = new System.Drawing.Size(150, 21);
            this.EquipmentSerialNr_lbl.TabIndex = 0;
            this.EquipmentSerialNr_lbl.Text = "Equipment Serial Nr";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.Submit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_btn.FlatAppearance.BorderSize = 0;
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.ForeColor = System.Drawing.Color.White;
            this.Submit_btn.Location = new System.Drawing.Point(12, 514);
            this.Submit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(158, 35);
            this.Submit_btn.TabIndex = 6;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Delete_btn.Location = new System.Drawing.Point(581, 514);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(158, 35);
            this.Delete_btn.TabIndex = 7;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(756, 514);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(158, 35);
            this.Close_btn.TabIndex = 8;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            // 
            // ModifyJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.JobInfo_gbx);
            this.Controls.Add(this.Technician_gbx);
            this.Controls.Add(this.Search_gbx);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.PSS_img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyJobs";
            this.Text = "Modify Jobs";
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
        private System.Windows.Forms.Label endDate_lbl;
        private System.Windows.Forms.Label startDate_lbl;
    }
}