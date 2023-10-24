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
            this.Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.ContractManagement_tbc.SuspendLayout();
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
    }
}