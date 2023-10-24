namespace PSS_ITWORKS.Presentation_Layer
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
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.ContractManagement_tbc = new System.Windows.Forms.TabControl();
            this.ContractPerformance_tbp = new System.Windows.Forms.TabPage();
            this.ServiceConfiguration_tbp = new System.Windows.Forms.TabPage();
            this.ContractConfiguration_tbp = new System.Windows.Forms.TabPage();
            this.ContractPerformancePastMonth_gbx = new System.Windows.Forms.GroupBox();
            this.ContractTypePastMonth_lbl = new System.Windows.Forms.Label();
            this.ContractType_cbx = new System.Windows.Forms.ComboBox();
            this.ClientCount_lbl = new System.Windows.Forms.Label();
            this.ClientCount_txt = new System.Windows.Forms.TextBox();
            this.JobsDonePastMonth_lbl = new System.Windows.Forms.Label();
            this.JobsCanceledPastMonth_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ContractPerformancePastYear_gbx = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.JobCanceledPastYear_lbl = new System.Windows.Forms.Label();
            this.JobDonePastYear_lbl = new System.Windows.Forms.Label();
            this.ClientCountPastYear_txt = new System.Windows.Forms.TextBox();
            this.ClientCountPastYear_lbl = new System.Windows.Forms.Label();
            this.ContractTypePastMonth_cbx = new System.Windows.Forms.ComboBox();
            this.ContractTypePastYear_lbl = new System.Windows.Forms.Label();
            this.Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.ContractManagement_tbc.SuspendLayout();
            this.ContractPerformance_tbp.SuspendLayout();
            this.ContractPerformancePastMonth_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ContractPerformancePastYear_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(1067, 89);
            this.Header_pnl.TabIndex = 0;
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
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.PSS_lbl.Location = new System.Drawing.Point(125, 23);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(276, 50);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Welcome back";
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(943, 39);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(111, 44);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // ContractManagement_tbc
            // 
            this.ContractManagement_tbc.Controls.Add(this.ContractPerformance_tbp);
            this.ContractManagement_tbc.Controls.Add(this.ServiceConfiguration_tbp);
            this.ContractManagement_tbc.Controls.Add(this.ContractConfiguration_tbp);
            this.ContractManagement_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractManagement_tbc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractManagement_tbc.Location = new System.Drawing.Point(0, 89);
            this.ContractManagement_tbc.Name = "ContractManagement_tbc";
            this.ContractManagement_tbc.SelectedIndex = 0;
            this.ContractManagement_tbc.Size = new System.Drawing.Size(1067, 465);
            this.ContractManagement_tbc.TabIndex = 1;
            // 
            // ContractPerformance_tbp
            // 
            this.ContractPerformance_tbp.Controls.Add(this.ContractPerformancePastYear_gbx);
            this.ContractPerformance_tbp.Controls.Add(this.ContractPerformancePastMonth_gbx);
            this.ContractPerformance_tbp.Location = new System.Drawing.Point(4, 34);
            this.ContractPerformance_tbp.Name = "ContractPerformance_tbp";
            this.ContractPerformance_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.ContractPerformance_tbp.Size = new System.Drawing.Size(1059, 427);
            this.ContractPerformance_tbp.TabIndex = 0;
            this.ContractPerformance_tbp.Text = "Contract Performance";
            this.ContractPerformance_tbp.UseVisualStyleBackColor = true;
            // 
            // ServiceConfiguration_tbp
            // 
            this.ServiceConfiguration_tbp.Location = new System.Drawing.Point(4, 34);
            this.ServiceConfiguration_tbp.Name = "ServiceConfiguration_tbp";
            this.ServiceConfiguration_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceConfiguration_tbp.Size = new System.Drawing.Size(1059, 427);
            this.ServiceConfiguration_tbp.TabIndex = 1;
            this.ServiceConfiguration_tbp.Text = "Service Configuration";
            this.ServiceConfiguration_tbp.UseVisualStyleBackColor = true;
            // 
            // ContractConfiguration_tbp
            // 
            this.ContractConfiguration_tbp.Location = new System.Drawing.Point(4, 34);
            this.ContractConfiguration_tbp.Name = "ContractConfiguration_tbp";
            this.ContractConfiguration_tbp.Size = new System.Drawing.Size(1059, 427);
            this.ContractConfiguration_tbp.TabIndex = 2;
            this.ContractConfiguration_tbp.Text = "Contract Configuration";
            this.ContractConfiguration_tbp.UseVisualStyleBackColor = true;
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
            this.ContractPerformancePastMonth_gbx.Location = new System.Drawing.Point(6, 6);
            this.ContractPerformancePastMonth_gbx.Name = "ContractPerformancePastMonth_gbx";
            this.ContractPerformancePastMonth_gbx.Size = new System.Drawing.Size(1044, 200);
            this.ContractPerformancePastMonth_gbx.TabIndex = 0;
            this.ContractPerformancePastMonth_gbx.TabStop = false;
            this.ContractPerformancePastMonth_gbx.Text = "Contract Performance Past Month";
            // 
            // ContractTypePastMonth_lbl
            // 
            this.ContractTypePastMonth_lbl.AutoSize = true;
            this.ContractTypePastMonth_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ContractTypePastMonth_lbl.Location = new System.Drawing.Point(13, 23);
            this.ContractTypePastMonth_lbl.Name = "ContractTypePastMonth_lbl";
            this.ContractTypePastMonth_lbl.Size = new System.Drawing.Size(127, 25);
            this.ContractTypePastMonth_lbl.TabIndex = 0;
            this.ContractTypePastMonth_lbl.Text = "Contract Type";
            // 
            // ContractType_cbx
            // 
            this.ContractType_cbx.FormattingEnabled = true;
            this.ContractType_cbx.Location = new System.Drawing.Point(18, 51);
            this.ContractType_cbx.Name = "ContractType_cbx";
            this.ContractType_cbx.Size = new System.Drawing.Size(121, 33);
            this.ContractType_cbx.TabIndex = 1;
            // 
            // ClientCount_lbl
            // 
            this.ClientCount_lbl.AutoSize = true;
            this.ClientCount_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ClientCount_lbl.Location = new System.Drawing.Point(13, 98);
            this.ClientCount_lbl.Name = "ClientCount_lbl";
            this.ClientCount_lbl.Size = new System.Drawing.Size(117, 25);
            this.ClientCount_lbl.TabIndex = 2;
            this.ClientCount_lbl.Text = "Client Count";
            // 
            // ClientCount_txt
            // 
            this.ClientCount_txt.Location = new System.Drawing.Point(18, 126);
            this.ClientCount_txt.Name = "ClientCount_txt";
            this.ClientCount_txt.Size = new System.Drawing.Size(100, 31);
            this.ClientCount_txt.TabIndex = 3;
            // 
            // JobsDonePastMonth_lbl
            // 
            this.JobsDonePastMonth_lbl.AutoSize = true;
            this.JobsDonePastMonth_lbl.Location = new System.Drawing.Point(309, 24);
            this.JobsDonePastMonth_lbl.Name = "JobsDonePastMonth_lbl";
            this.JobsDonePastMonth_lbl.Size = new System.Drawing.Size(99, 25);
            this.JobsDonePastMonth_lbl.TabIndex = 4;
            this.JobsDonePastMonth_lbl.Text = "Jobs Done";
            // 
            // JobsCanceledPastMonth_lbl
            // 
            this.JobsCanceledPastMonth_lbl.AutoSize = true;
            this.JobsCanceledPastMonth_lbl.Location = new System.Drawing.Point(711, 23);
            this.JobsCanceledPastMonth_lbl.Name = "JobsCanceledPastMonth_lbl";
            this.JobsCanceledPastMonth_lbl.Size = new System.Drawing.Size(129, 25);
            this.JobsCanceledPastMonth_lbl.TabIndex = 5;
            this.JobsCanceledPastMonth_lbl.Text = "Jobs Canceled";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(315, 116);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(716, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(316, 116);
            this.dataGridView2.TabIndex = 7;
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
            this.ContractPerformancePastYear_gbx.Location = new System.Drawing.Point(6, 219);
            this.ContractPerformancePastYear_gbx.Name = "ContractPerformancePastYear_gbx";
            this.ContractPerformancePastYear_gbx.Size = new System.Drawing.Size(1044, 200);
            this.ContractPerformancePastYear_gbx.TabIndex = 8;
            this.ContractPerformancePastYear_gbx.TabStop = false;
            this.ContractPerformancePastYear_gbx.Text = "Contract Performance Past Year";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(716, 52);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(316, 116);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(314, 52);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(315, 116);
            this.dataGridView4.TabIndex = 6;
            // 
            // JobCanceledPastYear_lbl
            // 
            this.JobCanceledPastYear_lbl.AutoSize = true;
            this.JobCanceledPastYear_lbl.Location = new System.Drawing.Point(711, 23);
            this.JobCanceledPastYear_lbl.Name = "JobCanceledPastYear_lbl";
            this.JobCanceledPastYear_lbl.Size = new System.Drawing.Size(129, 25);
            this.JobCanceledPastYear_lbl.TabIndex = 5;
            this.JobCanceledPastYear_lbl.Text = "Jobs Canceled";
            // 
            // JobDonePastYear_lbl
            // 
            this.JobDonePastYear_lbl.AutoSize = true;
            this.JobDonePastYear_lbl.Location = new System.Drawing.Point(309, 24);
            this.JobDonePastYear_lbl.Name = "JobDonePastYear_lbl";
            this.JobDonePastYear_lbl.Size = new System.Drawing.Size(99, 25);
            this.JobDonePastYear_lbl.TabIndex = 4;
            this.JobDonePastYear_lbl.Text = "Jobs Done";
            // 
            // ClientCountPastYear_txt
            // 
            this.ClientCountPastYear_txt.Location = new System.Drawing.Point(18, 126);
            this.ClientCountPastYear_txt.Name = "ClientCountPastYear_txt";
            this.ClientCountPastYear_txt.Size = new System.Drawing.Size(100, 31);
            this.ClientCountPastYear_txt.TabIndex = 3;
            // 
            // ClientCountPastYear_lbl
            // 
            this.ClientCountPastYear_lbl.AutoSize = true;
            this.ClientCountPastYear_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ClientCountPastYear_lbl.Location = new System.Drawing.Point(13, 98);
            this.ClientCountPastYear_lbl.Name = "ClientCountPastYear_lbl";
            this.ClientCountPastYear_lbl.Size = new System.Drawing.Size(117, 25);
            this.ClientCountPastYear_lbl.TabIndex = 2;
            this.ClientCountPastYear_lbl.Text = "Client Count";
            // 
            // ContractTypePastMonth_cbx
            // 
            this.ContractTypePastMonth_cbx.FormattingEnabled = true;
            this.ContractTypePastMonth_cbx.Location = new System.Drawing.Point(18, 51);
            this.ContractTypePastMonth_cbx.Name = "ContractTypePastMonth_cbx";
            this.ContractTypePastMonth_cbx.Size = new System.Drawing.Size(121, 33);
            this.ContractTypePastMonth_cbx.TabIndex = 1;
            // 
            // ContractTypePastYear_lbl
            // 
            this.ContractTypePastYear_lbl.AutoSize = true;
            this.ContractTypePastYear_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ContractTypePastYear_lbl.Location = new System.Drawing.Point(13, 23);
            this.ContractTypePastYear_lbl.Name = "ContractTypePastYear_lbl";
            this.ContractTypePastYear_lbl.Size = new System.Drawing.Size(127, 25);
            this.ContractTypePastYear_lbl.TabIndex = 0;
            this.ContractTypePastYear_lbl.Text = "Contract Type";
            // 
            // ContractManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ContractManagement_tbc);
            this.Controls.Add(this.Header_pnl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContractManagerForm";
            this.Text = "ContractManagerForm";
            this.Load += new System.EventHandler(this.ContractManagerForm_Load);
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.ContractManagement_tbc.ResumeLayout(false);
            this.ContractPerformance_tbp.ResumeLayout(false);
            this.ContractPerformancePastMonth_gbx.ResumeLayout(false);
            this.ContractPerformancePastMonth_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ContractPerformancePastYear_gbx.ResumeLayout(false);
            this.ContractPerformancePastYear_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.TabControl ContractManagement_tbc;
        private System.Windows.Forms.TabPage ContractPerformance_tbp;
        private System.Windows.Forms.TabPage ServiceConfiguration_tbp;
        private System.Windows.Forms.TabPage ContractConfiguration_tbp;
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
    }
}