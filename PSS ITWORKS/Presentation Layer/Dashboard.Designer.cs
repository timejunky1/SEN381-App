
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.PrevPass_txt = new System.Windows.Forms.TextBox();
            this.LogOut_btn = new System.Windows.Forms.Button();
            this.NewPass_txt = new System.Windows.Forms.TextBox();
            this.ChangePass_btn = new System.Windows.Forms.Button();
            this.Login_img = new System.Windows.Forms.PictureBox();
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.PPS_lbl = new System.Windows.Forms.Label();
            this.oldPassword_lbl = new System.Windows.Forms.Label();
            this.newPassword_lbl = new System.Windows.Forms.Label();
            this.secureLabel_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.Dashboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Location = new System.Drawing.Point(489, 355);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(223, 36);
            this.Dashboard_btn.TabIndex = 0;
            this.Dashboard_btn.Text = "Go To Portal";
            this.Dashboard_btn.UseVisualStyleBackColor = false;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // PrevPass_txt
            // 
            this.PrevPass_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevPass_txt.Location = new System.Drawing.Point(473, 152);
            this.PrevPass_txt.Name = "PrevPass_txt";
            this.PrevPass_txt.Size = new System.Drawing.Size(250, 29);
            this.PrevPass_txt.TabIndex = 1;
            this.PrevPass_txt.Text = "Previous password";
            // 
            // LogOut_btn
            // 
            this.LogOut_btn.BackColor = System.Drawing.Color.Firebrick;
            this.LogOut_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut_btn.FlatAppearance.BorderSize = 0;
            this.LogOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_btn.ForeColor = System.Drawing.Color.White;
            this.LogOut_btn.Location = new System.Drawing.Point(489, 397);
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.Size = new System.Drawing.Size(223, 36);
            this.LogOut_btn.TabIndex = 2;
            this.LogOut_btn.Text = "Log Out";
            this.LogOut_btn.UseVisualStyleBackColor = false;
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // NewPass_txt
            // 
            this.NewPass_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass_txt.Location = new System.Drawing.Point(473, 226);
            this.NewPass_txt.Name = "NewPass_txt";
            this.NewPass_txt.Size = new System.Drawing.Size(250, 29);
            this.NewPass_txt.TabIndex = 3;
            this.NewPass_txt.Text = "New password";
            // 
            // ChangePass_btn
            // 
            this.ChangePass_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.ChangePass_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChangePass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePass_btn.FlatAppearance.BorderSize = 0;
            this.ChangePass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePass_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass_btn.ForeColor = System.Drawing.Color.Black;
            this.ChangePass_btn.Location = new System.Drawing.Point(489, 270);
            this.ChangePass_btn.Name = "ChangePass_btn";
            this.ChangePass_btn.Size = new System.Drawing.Size(223, 36);
            this.ChangePass_btn.TabIndex = 4;
            this.ChangePass_btn.Text = "Change Password";
            this.ChangePass_btn.UseVisualStyleBackColor = false;
            this.ChangePass_btn.Click += new System.EventHandler(this.ChangePass_btn_Click);
            // 
            // Login_img
            // 
            this.Login_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_img.BackgroundImage")));
            this.Login_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_img.Location = new System.Drawing.Point(26, 85);
            this.Login_img.Name = "Login_img";
            this.Login_img.Size = new System.Drawing.Size(359, 336);
            this.Login_img.TabIndex = 11;
            this.Login_img.TabStop = false;
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo_img.BackgroundImage")));
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(12, 9);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(76, 61);
            this.Logo_img.TabIndex = 13;
            this.Logo_img.TabStop = false;
            // 
            // PPS_lbl
            // 
            this.PPS_lbl.AutoSize = true;
            this.PPS_lbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPS_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.PPS_lbl.Location = new System.Drawing.Point(94, 19);
            this.PPS_lbl.Name = "PPS_lbl";
            this.PPS_lbl.Size = new System.Drawing.Size(385, 40);
            this.PPS_lbl.TabIndex = 12;
            this.PPS_lbl.Text = "Premiere Service Solutions";
            // 
            // oldPassword_lbl
            // 
            this.oldPassword_lbl.AutoSize = true;
            this.oldPassword_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassword_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.oldPassword_lbl.Location = new System.Drawing.Point(469, 128);
            this.oldPassword_lbl.Name = "oldPassword_lbl";
            this.oldPassword_lbl.Size = new System.Drawing.Size(105, 21);
            this.oldPassword_lbl.TabIndex = 14;
            this.oldPassword_lbl.Text = "Old Password";
            // 
            // newPassword_lbl
            // 
            this.newPassword_lbl.AutoSize = true;
            this.newPassword_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.newPassword_lbl.Location = new System.Drawing.Point(469, 202);
            this.newPassword_lbl.Name = "newPassword_lbl";
            this.newPassword_lbl.Size = new System.Drawing.Size(112, 21);
            this.newPassword_lbl.TabIndex = 15;
            this.newPassword_lbl.Text = "New Password";
            // 
            // secureLabel_txt
            // 
            this.secureLabel_txt.AutoSize = true;
            this.secureLabel_txt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secureLabel_txt.Location = new System.Drawing.Point(483, 85);
            this.secureLabel_txt.Name = "secureLabel_txt";
            this.secureLabel_txt.Size = new System.Drawing.Size(240, 30);
            this.secureLabel_txt.TabIndex = 16;
            this.secureLabel_txt.Text = "Secure Password Update";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secureLabel_txt);
            this.Controls.Add(this.newPassword_lbl);
            this.Controls.Add(this.oldPassword_lbl);
            this.Controls.Add(this.Logo_img);
            this.Controls.Add(this.PPS_lbl);
            this.Controls.Add(this.Login_img);
            this.Controls.Add(this.ChangePass_btn);
            this.Controls.Add(this.NewPass_txt);
            this.Controls.Add(this.LogOut_btn);
            this.Controls.Add(this.PrevPass_txt);
            this.Controls.Add(this.Dashboard_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.TextBox PrevPass_txt;
        private System.Windows.Forms.Button LogOut_btn;
        private System.Windows.Forms.TextBox NewPass_txt;
        private System.Windows.Forms.Button ChangePass_btn;
        private System.Windows.Forms.PictureBox Login_img;
        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.Label PPS_lbl;
        private System.Windows.Forms.Label oldPassword_lbl;
        private System.Windows.Forms.Label newPassword_lbl;
        private System.Windows.Forms.Label secureLabel_txt;
    }
}