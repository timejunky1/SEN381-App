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
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.Search_gbx = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
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
            this.Search_gbx.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_gbx.Location = new System.Drawing.Point(16, 122);
            this.Search_gbx.Name = "Search_gbx";
            this.Search_gbx.Size = new System.Drawing.Size(1203, 81);
            this.Search_gbx.TabIndex = 2;
            this.Search_gbx.TabStop = false;
            this.Search_gbx.Text = "Search";
            // 
            // ModifyJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 689);
            this.Controls.Add(this.Search_gbx);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.PSS_img);
            this.Name = "ModifyJobs";
            this.Text = "ModifyJobs";
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.GroupBox Search_gbx;
    }
}