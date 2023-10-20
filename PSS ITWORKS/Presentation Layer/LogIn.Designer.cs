namespace PSS_ITWORKS
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Login_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.WelcomeLabel_txt = new System.Windows.Forms.Label();
            this.PPS_lbl = new System.Windows.Forms.Label();
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.Login_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(487, 325);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(223, 36);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(487, 379);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(223, 36);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(423, 161);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(97, 25);
            this.Username_lbl.TabIndex = 3;
            this.Username_lbl.Text = "Username";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(423, 236);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(91, 25);
            this.Password_lbl.TabIndex = 4;
            this.Password_lbl.Text = "Password";
            // 
            // UserName_txt
            // 
            this.UserName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_txt.Location = new System.Drawing.Point(428, 189);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(232, 29);
            this.UserName_txt.TabIndex = 5;
            this.UserName_txt.Tag = "";
            this.UserName_txt.TextChanged += new System.EventHandler(this.UserName_txt_TextChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(428, 264);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(232, 29);
            this.Password_txt.TabIndex = 6;
            this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
            // 
            // WelcomeLabel_txt
            // 
            this.WelcomeLabel_txt.AutoSize = true;
            this.WelcomeLabel_txt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel_txt.Location = new System.Drawing.Point(410, 103);
            this.WelcomeLabel_txt.Name = "WelcomeLabel_txt";
            this.WelcomeLabel_txt.Size = new System.Drawing.Size(365, 30);
            this.WelcomeLabel_txt.TabIndex = 7;
            this.WelcomeLabel_txt.Text = "Excellence in Equipment Maintenance";
            this.WelcomeLabel_txt.Click += new System.EventHandler(this.WelcomeLabel_txt_Click);
            // 
            // PPS_lbl
            // 
            this.PPS_lbl.AutoSize = true;
            this.PPS_lbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPS_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.PPS_lbl.Location = new System.Drawing.Point(94, 19);
            this.PPS_lbl.Name = "PPS_lbl";
            this.PPS_lbl.Size = new System.Drawing.Size(385, 40);
            this.PPS_lbl.TabIndex = 8;
            this.PPS_lbl.Text = "Premiere Service Solutions";
            this.PPS_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo_img.BackgroundImage")));
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(12, 9);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(76, 61);
            this.Logo_img.TabIndex = 9;
            this.Logo_img.TabStop = false;
            // 
            // Login_img
            // 
            this.Login_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_img.BackgroundImage")));
            this.Login_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_img.Location = new System.Drawing.Point(24, 90);
            this.Login_img.Name = "Login_img";
            this.Login_img.Size = new System.Drawing.Size(359, 336);
            this.Login_img.TabIndex = 10;
            this.Login_img.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_img);
            this.Controls.Add(this.Logo_img);
            this.Controls.Add(this.PPS_lbl);
            this.Controls.Add(this.WelcomeLabel_txt);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Login_btn);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label WelcomeLabel_txt;
        private System.Windows.Forms.Label PPS_lbl;
        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.PictureBox Login_img;
    }
}

