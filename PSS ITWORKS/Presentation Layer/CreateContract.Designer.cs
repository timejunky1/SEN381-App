namespace PSS_ITWORKS.Presentation_Layer
{
    partial class CreateContract
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
            this.Heading_lbl = new System.Windows.Forms.Label();
            this.CreateContract_gbx = new System.Windows.Forms.GroupBox();
            this.Duration_lbl = new System.Windows.Forms.Label();
            this.Duration_txt = new System.Windows.Forms.TextBox();
            this.SLA_lbl = new System.Windows.Forms.Label();
            this.Availability_lbl = new System.Windows.Forms.Label();
            this.Cost_txt = new System.Windows.Forms.TextBox();
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.Priority_txt = new System.Windows.Forms.TextBox();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.Availability_cbx = new System.Windows.Forms.ComboBox();
            this.SLA_rtb = new System.Windows.Forms.RichTextBox();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.CreateContract_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo_img
            // 
            this.Logo_img.Location = new System.Drawing.Point(16, 11);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(101, 75);
            this.Logo_img.TabIndex = 0;
            this.Logo_img.TabStop = false;
            // 
            // Heading_lbl
            // 
            this.Heading_lbl.AutoSize = true;
            this.Heading_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading_lbl.Location = new System.Drawing.Point(125, 32);
            this.Heading_lbl.Name = "Heading_lbl";
            this.Heading_lbl.Size = new System.Drawing.Size(584, 41);
            this.Heading_lbl.TabIndex = 1;
            this.Heading_lbl.Text = "Welcome back <name> <surname> (title) ";
            // 
            // CreateContract_gbx
            // 
            this.CreateContract_gbx.Controls.Add(this.Close_btn);
            this.CreateContract_gbx.Controls.Add(this.Create_btn);
            this.CreateContract_gbx.Controls.Add(this.SLA_rtb);
            this.CreateContract_gbx.Controls.Add(this.Availability_cbx);
            this.CreateContract_gbx.Controls.Add(this.Priority_txt);
            this.CreateContract_gbx.Controls.Add(this.Priority_lbl);
            this.CreateContract_gbx.Controls.Add(this.Cost_txt);
            this.CreateContract_gbx.Controls.Add(this.Cost_lbl);
            this.CreateContract_gbx.Controls.Add(this.Availability_lbl);
            this.CreateContract_gbx.Controls.Add(this.SLA_lbl);
            this.CreateContract_gbx.Controls.Add(this.Duration_txt);
            this.CreateContract_gbx.Controls.Add(this.Duration_lbl);
            this.CreateContract_gbx.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateContract_gbx.Location = new System.Drawing.Point(16, 123);
            this.CreateContract_gbx.Name = "CreateContract_gbx";
            this.CreateContract_gbx.Size = new System.Drawing.Size(1203, 544);
            this.CreateContract_gbx.TabIndex = 3;
            this.CreateContract_gbx.TabStop = false;
            this.CreateContract_gbx.Text = "Create Contract";
            // 
            // Duration_lbl
            // 
            this.Duration_lbl.AutoSize = true;
            this.Duration_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Duration_lbl.Location = new System.Drawing.Point(36, 37);
            this.Duration_lbl.Name = "Duration_lbl";
            this.Duration_lbl.Size = new System.Drawing.Size(153, 25);
            this.Duration_lbl.TabIndex = 0;
            this.Duration_lbl.Text = "Contract Duration";
            // 
            // Duration_txt
            // 
            this.Duration_txt.Location = new System.Drawing.Point(41, 75);
            this.Duration_txt.Name = "Duration_txt";
            this.Duration_txt.Size = new System.Drawing.Size(209, 31);
            this.Duration_txt.TabIndex = 1;
            // 
            // SLA_lbl
            // 
            this.SLA_lbl.AutoSize = true;
            this.SLA_lbl.ForeColor = System.Drawing.Color.Blue;
            this.SLA_lbl.Location = new System.Drawing.Point(458, 37);
            this.SLA_lbl.Name = "SLA_lbl";
            this.SLA_lbl.Size = new System.Drawing.Size(204, 25);
            this.SLA_lbl.TabIndex = 2;
            this.SLA_lbl.Text = "Service Level Agreement";
            // 
            // Availability_lbl
            // 
            this.Availability_lbl.AutoSize = true;
            this.Availability_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Availability_lbl.Location = new System.Drawing.Point(36, 307);
            this.Availability_lbl.Name = "Availability_lbl";
            this.Availability_lbl.Size = new System.Drawing.Size(97, 25);
            this.Availability_lbl.TabIndex = 4;
            this.Availability_lbl.Text = "Availability";
            // 
            // Cost_txt
            // 
            this.Cost_txt.Location = new System.Drawing.Point(41, 255);
            this.Cost_txt.Name = "Cost_txt";
            this.Cost_txt.Size = new System.Drawing.Size(209, 31);
            this.Cost_txt.TabIndex = 7;
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Cost_lbl.Location = new System.Drawing.Point(36, 214);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(48, 25);
            this.Cost_lbl.TabIndex = 6;
            this.Cost_lbl.Text = "Cost";
            // 
            // Priority_txt
            // 
            this.Priority_txt.Location = new System.Drawing.Point(41, 162);
            this.Priority_txt.Name = "Priority_txt";
            this.Priority_txt.Size = new System.Drawing.Size(209, 31);
            this.Priority_txt.TabIndex = 9;
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Priority_lbl.Location = new System.Drawing.Point(36, 124);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(68, 25);
            this.Priority_lbl.TabIndex = 8;
            this.Priority_lbl.Text = "Priority";
            // 
            // Availability_cbx
            // 
            this.Availability_cbx.FormattingEnabled = true;
            this.Availability_cbx.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.Availability_cbx.Location = new System.Drawing.Point(41, 336);
            this.Availability_cbx.Name = "Availability_cbx";
            this.Availability_cbx.Size = new System.Drawing.Size(209, 33);
            this.Availability_cbx.TabIndex = 10;
            // 
            // SLA_rtb
            // 
            this.SLA_rtb.Location = new System.Drawing.Point(463, 75);
            this.SLA_rtb.Name = "SLA_rtb";
            this.SLA_rtb.Size = new System.Drawing.Size(677, 372);
            this.SLA_rtb.TabIndex = 11;
            this.SLA_rtb.Text = "";
            // 
            // Create_btn
            // 
            this.Create_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Create_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_btn.ForeColor = System.Drawing.Color.White;
            this.Create_btn.Location = new System.Drawing.Point(41, 473);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(211, 43);
            this.Create_btn.TabIndex = 12;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = false;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(463, 473);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(211, 43);
            this.Close_btn.TabIndex = 13;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            // 
            // CreateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 689);
            this.Controls.Add(this.CreateContract_gbx);
            this.Controls.Add(this.Heading_lbl);
            this.Controls.Add(this.Logo_img);
            this.Name = "CreateContract";
            this.Text = "CreateContract";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.CreateContract_gbx.ResumeLayout(false);
            this.CreateContract_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.Label Heading_lbl;
        private System.Windows.Forms.GroupBox CreateContract_gbx;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.RichTextBox SLA_rtb;
        private System.Windows.Forms.ComboBox Availability_cbx;
        private System.Windows.Forms.TextBox Priority_txt;
        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.TextBox Cost_txt;
        private System.Windows.Forms.Label Cost_lbl;
        private System.Windows.Forms.Label Availability_lbl;
        private System.Windows.Forms.Label SLA_lbl;
        private System.Windows.Forms.TextBox Duration_txt;
        private System.Windows.Forms.Label Duration_lbl;
    }
}