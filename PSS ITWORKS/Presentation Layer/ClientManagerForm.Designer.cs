namespace PSS_ITWORKS.Presentation_Layer
{
    partial class ClientManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagerForm));
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.WelcomeClientManager_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientID_txt = new System.Windows.Forms.TextBox();
            this.clientID_lbl = new System.Windows.Forms.Label();
            this.clientContactDetail_txt = new System.Windows.Forms.TextBox();
            this.clientContactDetail_lbl = new System.Windows.Forms.Label();
            this.clientContract_txt = new System.Windows.Forms.TextBox();
            this.clientContract_lbl = new System.Windows.Forms.Label();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.client_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo_img.BackgroundImage")));
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(13, 13);
            this.Logo_img.Margin = new System.Windows.Forms.Padding(4);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(101, 75);
            this.Logo_img.TabIndex = 11;
            this.Logo_img.TabStop = false;
            // 
            // WelcomeClientManager_lbl
            // 
            this.WelcomeClientManager_lbl.AutoSize = true;
            this.WelcomeClientManager_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeClientManager_lbl.ForeColor = System.Drawing.Color.Black;
            this.WelcomeClientManager_lbl.Location = new System.Drawing.Point(122, 25);
            this.WelcomeClientManager_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeClientManager_lbl.Name = "WelcomeClientManager_lbl";
            this.WelcomeClientManager_lbl.Size = new System.Drawing.Size(448, 41);
            this.WelcomeClientManager_lbl.TabIndex = 10;
            this.WelcomeClientManager_lbl.Text = "Welcome back  (Client Manager)";
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(757, 26);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(297, 44);
            this.Logout_btn.TabIndex = 12;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(294, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 406);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientID_txt
            // 
            this.clientID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientID_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_txt.Location = new System.Drawing.Point(25, 236);
            this.clientID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.clientID_txt.Name = "clientID_txt";
            this.clientID_txt.Size = new System.Drawing.Size(235, 34);
            this.clientID_txt.TabIndex = 15;
            this.clientID_txt.Tag = "";
            // 
            // clientID_lbl
            // 
            this.clientID_lbl.AutoSize = true;
            this.clientID_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_lbl.Location = new System.Drawing.Point(18, 201);
            this.clientID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientID_lbl.Name = "clientID_lbl";
            this.clientID_lbl.Size = new System.Drawing.Size(86, 28);
            this.clientID_lbl.TabIndex = 14;
            this.clientID_lbl.Text = "Client ID";
            // 
            // clientContactDetail_txt
            // 
            this.clientContactDetail_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientContactDetail_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContactDetail_txt.Location = new System.Drawing.Point(26, 324);
            this.clientContactDetail_txt.Margin = new System.Windows.Forms.Padding(4);
            this.clientContactDetail_txt.Name = "clientContactDetail_txt";
            this.clientContactDetail_txt.Size = new System.Drawing.Size(235, 34);
            this.clientContactDetail_txt.TabIndex = 17;
            this.clientContactDetail_txt.Tag = "";
            // 
            // clientContactDetail_lbl
            // 
            this.clientContactDetail_lbl.AutoSize = true;
            this.clientContactDetail_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContactDetail_lbl.Location = new System.Drawing.Point(19, 289);
            this.clientContactDetail_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientContactDetail_lbl.Name = "clientContactDetail_lbl";
            this.clientContactDetail_lbl.Size = new System.Drawing.Size(144, 28);
            this.clientContactDetail_lbl.TabIndex = 16;
            this.clientContactDetail_lbl.Text = "Contact Details";
            // 
            // clientContract_txt
            // 
            this.clientContract_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientContract_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContract_txt.Location = new System.Drawing.Point(27, 416);
            this.clientContract_txt.Margin = new System.Windows.Forms.Padding(4);
            this.clientContract_txt.Name = "clientContract_txt";
            this.clientContract_txt.Size = new System.Drawing.Size(235, 34);
            this.clientContract_txt.TabIndex = 19;
            this.clientContract_txt.Tag = "";
            // 
            // clientContract_lbl
            // 
            this.clientContract_lbl.AutoSize = true;
            this.clientContract_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContract_lbl.Location = new System.Drawing.Point(20, 381);
            this.clientContract_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientContract_lbl.Name = "clientContract_lbl";
            this.clientContract_lbl.Size = new System.Drawing.Size(87, 28);
            this.clientContract_lbl.TabIndex = 18;
            this.clientContract_lbl.Text = "Contract";
            // 
            // Filter_btn
            // 
            this.Filter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.Filter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Filter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter_btn.FlatAppearance.BorderSize = 0;
            this.Filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_btn.Location = new System.Drawing.Point(27, 483);
            this.Filter_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(233, 44);
            this.Filter_btn.TabIndex = 20;
            this.Filter_btn.Text = "Filter";
            this.Filter_btn.UseVisualStyleBackColor = false;
            // 
            // client_lbl
            // 
            this.client_lbl.AutoSize = true;
            this.client_lbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_lbl.Location = new System.Drawing.Point(28, 146);
            this.client_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.Size = new System.Drawing.Size(123, 38);
            this.client_lbl.TabIndex = 21;
            this.client_lbl.Text = "Client ID";
            // 
            // ClientManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.client_lbl);
            this.Controls.Add(this.Filter_btn);
            this.Controls.Add(this.clientContract_txt);
            this.Controls.Add(this.clientContract_lbl);
            this.Controls.Add(this.clientContactDetail_txt);
            this.Controls.Add(this.clientContactDetail_lbl);
            this.Controls.Add(this.clientID_txt);
            this.Controls.Add(this.clientID_lbl);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Logo_img);
            this.Controls.Add(this.WelcomeClientManager_lbl);
            this.Name = "ClientManagerForm";
            this.Text = "ClientManagerForm";
            this.Load += new System.EventHandler(this.ClientManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.Label WelcomeClientManager_lbl;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox clientID_txt;
        private System.Windows.Forms.Label clientID_lbl;
        private System.Windows.Forms.TextBox clientContactDetail_txt;
        private System.Windows.Forms.Label clientContactDetail_lbl;
        private System.Windows.Forms.TextBox clientContract_txt;
        private System.Windows.Forms.Label clientContract_lbl;
        private System.Windows.Forms.Button Filter_btn;
        private System.Windows.Forms.Label client_lbl;
    }
}