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
            this.Header_pnl = new System.Windows.Forms.Panel();
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.CallEmployee_tbc = new System.Windows.Forms.TabControl();
            this.Dashboard_tbp = new System.Windows.Forms.TabPage();
            this.ServiceRequest_tbp = new System.Windows.Forms.TabPage();
            this.Client_tbp = new System.Windows.Forms.TabPage();
            this.CommunicationHistory_tbp = new System.Windows.Forms.TabPage();
            this.Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.CallEmployee_tbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_pnl
            // 
            this.Header_pnl.AutoSize = true;
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
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(938, 23);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(102, 50);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // CallEmployee_tbc
            // 
            this.CallEmployee_tbc.Controls.Add(this.Dashboard_tbp);
            this.CallEmployee_tbc.Controls.Add(this.ServiceRequest_tbp);
            this.CallEmployee_tbc.Controls.Add(this.Client_tbp);
            this.CallEmployee_tbc.Controls.Add(this.CommunicationHistory_tbp);
            this.CallEmployee_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CallEmployee_tbc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallEmployee_tbc.Location = new System.Drawing.Point(0, 89);
            this.CallEmployee_tbc.Name = "CallEmployee_tbc";
            this.CallEmployee_tbc.SelectedIndex = 0;
            this.CallEmployee_tbc.Size = new System.Drawing.Size(1067, 465);
            this.CallEmployee_tbc.TabIndex = 1;
            // 
            // Dashboard_tbp
            // 
            this.Dashboard_tbp.Location = new System.Drawing.Point(4, 34);
            this.Dashboard_tbp.Name = "Dashboard_tbp";
            this.Dashboard_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard_tbp.Size = new System.Drawing.Size(1059, 427);
            this.Dashboard_tbp.TabIndex = 0;
            this.Dashboard_tbp.Text = "Dashboard";
            this.Dashboard_tbp.UseVisualStyleBackColor = true;
            // 
            // ServiceRequest_tbp
            // 
            this.ServiceRequest_tbp.Location = new System.Drawing.Point(4, 34);
            this.ServiceRequest_tbp.Name = "ServiceRequest_tbp";
            this.ServiceRequest_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceRequest_tbp.Size = new System.Drawing.Size(1059, 427);
            this.ServiceRequest_tbp.TabIndex = 1;
            this.ServiceRequest_tbp.Text = "Service Request";
            this.ServiceRequest_tbp.UseVisualStyleBackColor = true;
            // 
            // Client_tbp
            // 
            this.Client_tbp.Location = new System.Drawing.Point(4, 34);
            this.Client_tbp.Name = "Client_tbp";
            this.Client_tbp.Size = new System.Drawing.Size(1059, 427);
            this.Client_tbp.TabIndex = 2;
            this.Client_tbp.Text = "Client";
            this.Client_tbp.UseVisualStyleBackColor = true;
            // 
            // CommunicationHistory_tbp
            // 
            this.CommunicationHistory_tbp.Location = new System.Drawing.Point(4, 34);
            this.CommunicationHistory_tbp.Name = "CommunicationHistory_tbp";
            this.CommunicationHistory_tbp.Size = new System.Drawing.Size(1059, 427);
            this.CommunicationHistory_tbp.TabIndex = 3;
            this.CommunicationHistory_tbp.Text = "Communication History";
            this.CommunicationHistory_tbp.UseVisualStyleBackColor = true;
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CallEmployee_tbc);
            this.Controls.Add(this.Header_pnl);
            this.Name = "CallForm";
            this.Text = "CallForm";
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.CallEmployee_tbc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.TabControl CallEmployee_tbc;
        private System.Windows.Forms.TabPage Dashboard_tbp;
        private System.Windows.Forms.TabPage ServiceRequest_tbp;
        private System.Windows.Forms.TabPage Client_tbp;
        private System.Windows.Forms.TabPage CommunicationHistory_tbp;
    }
}