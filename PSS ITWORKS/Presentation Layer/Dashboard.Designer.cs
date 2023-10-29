
namespace PSS_ITWORKS.Presentation_Layer
{
    partial class Dashboard
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
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.PrevPass_txt = new System.Windows.Forms.TextBox();
            this.LogOut_btn = new System.Windows.Forms.Button();
            this.NewPass_txt = new System.Windows.Forms.TextBox();
            this.ChangePass_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.Location = new System.Drawing.Point(581, 313);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(75, 23);
            this.Dashboard_btn.TabIndex = 0;
            this.Dashboard_btn.Text = "Go To Portal";
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // PrevPass_txt
            // 
            this.PrevPass_txt.Location = new System.Drawing.Point(164, 166);
            this.PrevPass_txt.Name = "PrevPass_txt";
            this.PrevPass_txt.Size = new System.Drawing.Size(110, 20);
            this.PrevPass_txt.TabIndex = 1;
            this.PrevPass_txt.Text = "previous password";
            // 
            // LogOut_btn
            // 
            this.LogOut_btn.Location = new System.Drawing.Point(663, 44);
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.Size = new System.Drawing.Size(75, 23);
            this.LogOut_btn.TabIndex = 2;
            this.LogOut_btn.Text = "Log Out";
            this.LogOut_btn.UseVisualStyleBackColor = true;
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // NewPass_txt
            // 
            this.NewPass_txt.Location = new System.Drawing.Point(164, 208);
            this.NewPass_txt.Name = "NewPass_txt";
            this.NewPass_txt.Size = new System.Drawing.Size(110, 20);
            this.NewPass_txt.TabIndex = 3;
            this.NewPass_txt.Text = "new password";
            // 
            // ChangePass_btn
            // 
            this.ChangePass_btn.Location = new System.Drawing.Point(164, 269);
            this.ChangePass_btn.Name = "ChangePass_btn";
            this.ChangePass_btn.Size = new System.Drawing.Size(110, 23);
            this.ChangePass_btn.TabIndex = 4;
            this.ChangePass_btn.Text = "Change Password";
            this.ChangePass_btn.UseVisualStyleBackColor = true;
            this.ChangePass_btn.Click += new System.EventHandler(this.ChangePass_btn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangePass_btn);
            this.Controls.Add(this.NewPass_txt);
            this.Controls.Add(this.LogOut_btn);
            this.Controls.Add(this.PrevPass_txt);
            this.Controls.Add(this.Dashboard_btn);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.TextBox PrevPass_txt;
        private System.Windows.Forms.Button LogOut_btn;
        private System.Windows.Forms.TextBox NewPass_txt;
        private System.Windows.Forms.Button ChangePass_btn;
    }
}