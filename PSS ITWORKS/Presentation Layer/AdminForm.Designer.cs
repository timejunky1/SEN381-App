namespace PSS_ITWORKS.Presentation_Layer
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Admin_tc = new System.Windows.Forms.TabControl();
            this.CRUD_tp = new System.Windows.Forms.TabPage();
            this.province_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.street_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.streetNumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.role_cmb = new System.Windows.Forms.ComboBox();
            this.infoCRUD_lbl = new System.Windows.Forms.Label();
            this.contractNumber_txt = new System.Windows.Forms.TextBox();
            this.Role_lbl = new System.Windows.Forms.Label();
            this.Number_lbl = new System.Windows.Forms.Label();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.updateUser_btn = new System.Windows.Forms.Button();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.userManagement_lbl = new System.Windows.Forms.Label();
            this.Users_tp = new System.Windows.Forms.TabPage();
            this.Users_dgv = new System.Windows.Forms.DataGridView();
            this.clientsView_btn = new System.Windows.Forms.Button();
            this.clientsFilter_btn = new System.Windows.Forms.Button();
            this.clientUsername_txt = new System.Windows.Forms.TextBox();
            this.clientUsername_lbl = new System.Windows.Forms.Label();
            this.Clients_lbl = new System.Windows.Forms.Label();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.Admin_tc.SuspendLayout();
            this.CRUD_tp.SuspendLayout();
            this.Users_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(749, 29);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(118, 36);
            this.Logout_btn.TabIndex = 17;
            this.Logout_btn.Text = "DashBoard";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // Admin_tc
            // 
            this.Admin_tc.Controls.Add(this.CRUD_tp);
            this.Admin_tc.Controls.Add(this.Users_tp);
            this.Admin_tc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_tc.Location = new System.Drawing.Point(12, 103);
            this.Admin_tc.Multiline = true;
            this.Admin_tc.Name = "Admin_tc";
            this.Admin_tc.SelectedIndex = 0;
            this.Admin_tc.Size = new System.Drawing.Size(873, 456);
            this.Admin_tc.TabIndex = 16;
            // 
            // CRUD_tp
            // 
            this.CRUD_tp.Controls.Add(this.province_txt);
            this.CRUD_tp.Controls.Add(this.label4);
            this.CRUD_tp.Controls.Add(this.street_txt);
            this.CRUD_tp.Controls.Add(this.label5);
            this.CRUD_tp.Controls.Add(this.phone_txt);
            this.CRUD_tp.Controls.Add(this.label6);
            this.CRUD_tp.Controls.Add(this.city_txt);
            this.CRUD_tp.Controls.Add(this.label1);
            this.CRUD_tp.Controls.Add(this.streetNumber_txt);
            this.CRUD_tp.Controls.Add(this.label2);
            this.CRUD_tp.Controls.Add(this.companyName_txt);
            this.CRUD_tp.Controls.Add(this.label3);
            this.CRUD_tp.Controls.Add(this.role_cmb);
            this.CRUD_tp.Controls.Add(this.infoCRUD_lbl);
            this.CRUD_tp.Controls.Add(this.contractNumber_txt);
            this.CRUD_tp.Controls.Add(this.Role_lbl);
            this.CRUD_tp.Controls.Add(this.Number_lbl);
            this.CRUD_tp.Controls.Add(this.Surname_txt);
            this.CRUD_tp.Controls.Add(this.Surname_lbl);
            this.CRUD_tp.Controls.Add(this.Name_txt);
            this.CRUD_tp.Controls.Add(this.Name_lbl);
            this.CRUD_tp.Controls.Add(this.Email_lbl);
            this.CRUD_tp.Controls.Add(this.Password_txt);
            this.CRUD_tp.Controls.Add(this.Password_lbl);
            this.CRUD_tp.Controls.Add(this.Username_txt);
            this.CRUD_tp.Controls.Add(this.updateUser_btn);
            this.CRUD_tp.Controls.Add(this.deleteUser_btn);
            this.CRUD_tp.Controls.Add(this.addUser_btn);
            this.CRUD_tp.Controls.Add(this.userManagement_lbl);
            this.CRUD_tp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD_tp.Location = new System.Drawing.Point(4, 39);
            this.CRUD_tp.Name = "CRUD_tp";
            this.CRUD_tp.Padding = new System.Windows.Forms.Padding(3);
            this.CRUD_tp.Size = new System.Drawing.Size(865, 413);
            this.CRUD_tp.TabIndex = 0;
            this.CRUD_tp.Text = "CRUD";
            this.CRUD_tp.UseVisualStyleBackColor = true;
            // 
            // province_txt
            // 
            this.province_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.province_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province_txt.Location = new System.Drawing.Point(684, 312);
            this.province_txt.Name = "province_txt";
            this.province_txt.Size = new System.Drawing.Size(158, 29);
            this.province_txt.TabIndex = 71;
            this.province_txt.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(680, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Province";
            // 
            // street_txt
            // 
            this.street_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.street_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street_txt.Location = new System.Drawing.Point(684, 230);
            this.street_txt.Name = "street_txt";
            this.street_txt.Size = new System.Drawing.Size(158, 29);
            this.street_txt.TabIndex = 69;
            this.street_txt.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.label5.Location = new System.Drawing.Point(680, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 68;
            this.label5.Text = "Street name";
            // 
            // phone_txt
            // 
            this.phone_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(684, 154);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(158, 29);
            this.phone_txt.TabIndex = 67;
            this.phone_txt.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.label6.Location = new System.Drawing.Point(680, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "Phone";
            // 
            // city_txt
            // 
            this.city_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_txt.Location = new System.Drawing.Point(466, 312);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(158, 29);
            this.city_txt.TabIndex = 65;
            this.city_txt.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(462, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "City";
            // 
            // streetNumber_txt
            // 
            this.streetNumber_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.streetNumber_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetNumber_txt.Location = new System.Drawing.Point(466, 230);
            this.streetNumber_txt.Name = "streetNumber_txt";
            this.streetNumber_txt.Size = new System.Drawing.Size(158, 29);
            this.streetNumber_txt.TabIndex = 63;
            this.streetNumber_txt.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(462, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Street Number";
            // 
            // companyName_txt
            // 
            this.companyName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName_txt.Location = new System.Drawing.Point(466, 154);
            this.companyName_txt.Name = "companyName_txt";
            this.companyName_txt.Size = new System.Drawing.Size(158, 29);
            this.companyName_txt.TabIndex = 61;
            this.companyName_txt.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(462, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Company Name";
            // 
            // role_cmb
            // 
            this.role_cmb.FormattingEnabled = true;
            this.role_cmb.Location = new System.Drawing.Point(251, 303);
            this.role_cmb.Name = "role_cmb";
            this.role_cmb.Size = new System.Drawing.Size(158, 40);
            this.role_cmb.TabIndex = 59;
            this.role_cmb.SelectedIndexChanged += new System.EventHandler(this.role_cmb_SelectedIndexChanged);
            // 
            // infoCRUD_lbl
            // 
            this.infoCRUD_lbl.AutoSize = true;
            this.infoCRUD_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCRUD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.infoCRUD_lbl.Location = new System.Drawing.Point(25, 369);
            this.infoCRUD_lbl.Name = "infoCRUD_lbl";
            this.infoCRUD_lbl.Size = new System.Drawing.Size(488, 21);
            this.infoCRUD_lbl.TabIndex = 48;
            this.infoCRUD_lbl.Text = "* Once the info is entered please click on the desired CRUD operation";
            // 
            // contractNumber_txt
            // 
            this.contractNumber_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contractNumber_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractNumber_txt.Location = new System.Drawing.Point(29, 230);
            this.contractNumber_txt.Name = "contractNumber_txt";
            this.contractNumber_txt.Size = new System.Drawing.Size(158, 29);
            this.contractNumber_txt.TabIndex = 47;
            this.contractNumber_txt.Tag = "";
            // 
            // Role_lbl
            // 
            this.Role_lbl.AutoSize = true;
            this.Role_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Role_lbl.Location = new System.Drawing.Point(247, 279);
            this.Role_lbl.Name = "Role_lbl";
            this.Role_lbl.Size = new System.Drawing.Size(41, 21);
            this.Role_lbl.TabIndex = 44;
            this.Role_lbl.Text = "Role";
            // 
            // Number_lbl
            // 
            this.Number_lbl.AutoSize = true;
            this.Number_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Number_lbl.Location = new System.Drawing.Point(25, 206);
            this.Number_lbl.Name = "Number_lbl";
            this.Number_lbl.Size = new System.Drawing.Size(125, 21);
            this.Number_lbl.TabIndex = 38;
            this.Number_lbl.Text = "Contact Number";
            // 
            // Surname_txt
            // 
            this.Surname_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Surname_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_txt.Location = new System.Drawing.Point(251, 230);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(158, 29);
            this.Surname_txt.TabIndex = 37;
            this.Surname_txt.Tag = "";
            // 
            // Surname_lbl
            // 
            this.Surname_lbl.AutoSize = true;
            this.Surname_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Surname_lbl.Location = new System.Drawing.Point(247, 206);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(73, 21);
            this.Surname_lbl.TabIndex = 36;
            this.Surname_lbl.Text = "Surname";
            // 
            // Name_txt
            // 
            this.Name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(251, 154);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(158, 29);
            this.Name_txt.TabIndex = 35;
            this.Name_txt.Tag = "";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Name_lbl.Location = new System.Drawing.Point(247, 130);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(52, 21);
            this.Name_lbl.TabIndex = 34;
            this.Name_lbl.Text = "Name";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Email_lbl.Location = new System.Drawing.Point(25, 130);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(48, 21);
            this.Email_lbl.TabIndex = 32;
            this.Email_lbl.Text = "Email";
            // 
            // Password_txt
            // 
            this.Password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(29, 312);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(158, 29);
            this.Password_txt.TabIndex = 31;
            this.Password_txt.Tag = "";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Password_lbl.Location = new System.Drawing.Point(25, 288);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(76, 21);
            this.Password_lbl.TabIndex = 30;
            this.Password_lbl.Text = "Password";
            // 
            // Username_txt
            // 
            this.Username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.Location = new System.Drawing.Point(29, 154);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(158, 29);
            this.Username_txt.TabIndex = 28;
            this.Username_txt.Tag = "";
            // 
            // updateUser_btn
            // 
            this.updateUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.updateUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateUser_btn.FlatAppearance.BorderSize = 0;
            this.updateUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateUser_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUser_btn.ForeColor = System.Drawing.Color.White;
            this.updateUser_btn.Location = new System.Drawing.Point(684, 65);
            this.updateUser_btn.Name = "updateUser_btn";
            this.updateUser_btn.Size = new System.Drawing.Size(158, 35);
            this.updateUser_btn.TabIndex = 26;
            this.updateUser_btn.Text = "Update User";
            this.updateUser_btn.UseVisualStyleBackColor = false;
            this.updateUser_btn.Click += new System.EventHandler(this.updateUser_btn_Click);
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.deleteUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser_btn.FlatAppearance.BorderSize = 0;
            this.deleteUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser_btn.ForeColor = System.Drawing.Color.White;
            this.deleteUser_btn.Location = new System.Drawing.Point(360, 65);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(158, 35);
            this.deleteUser_btn.TabIndex = 25;
            this.deleteUser_btn.Text = "Delete User";
            this.deleteUser_btn.UseVisualStyleBackColor = false;
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // addUser_btn
            // 
            this.addUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.addUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser_btn.FlatAppearance.BorderSize = 0;
            this.addUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_btn.ForeColor = System.Drawing.Color.White;
            this.addUser_btn.Location = new System.Drawing.Point(29, 65);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(158, 35);
            this.addUser_btn.TabIndex = 24;
            this.addUser_btn.Text = "Add User";
            this.addUser_btn.UseVisualStyleBackColor = false;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // userManagement_lbl
            // 
            this.userManagement_lbl.AutoSize = true;
            this.userManagement_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagement_lbl.ForeColor = System.Drawing.Color.Black;
            this.userManagement_lbl.Location = new System.Drawing.Point(3, 14);
            this.userManagement_lbl.Name = "userManagement_lbl";
            this.userManagement_lbl.Size = new System.Drawing.Size(184, 30);
            this.userManagement_lbl.TabIndex = 14;
            this.userManagement_lbl.Text = "User Management";
            // 
            // Users_tp
            // 
            this.Users_tp.Controls.Add(this.Users_dgv);
            this.Users_tp.Controls.Add(this.clientsView_btn);
            this.Users_tp.Controls.Add(this.clientsFilter_btn);
            this.Users_tp.Controls.Add(this.clientUsername_txt);
            this.Users_tp.Controls.Add(this.clientUsername_lbl);
            this.Users_tp.Controls.Add(this.Clients_lbl);
            this.Users_tp.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Users_tp.Location = new System.Drawing.Point(4, 39);
            this.Users_tp.Name = "Users_tp";
            this.Users_tp.Size = new System.Drawing.Size(865, 413);
            this.Users_tp.TabIndex = 2;
            this.Users_tp.Text = "Users";
            this.Users_tp.UseVisualStyleBackColor = true;
            // 
            // Users_dgv
            // 
            this.Users_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dgv.Location = new System.Drawing.Point(286, 52);
            this.Users_dgv.Name = "Users_dgv";
            this.Users_dgv.Size = new System.Drawing.Size(552, 322);
            this.Users_dgv.TabIndex = 38;
            this.Users_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_dgv_CellContentClick);
            // 
            // clientsView_btn
            // 
            this.clientsView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.clientsView_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientsView_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsView_btn.FlatAppearance.BorderSize = 0;
            this.clientsView_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsView_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsView_btn.Location = new System.Drawing.Point(8, 152);
            this.clientsView_btn.Name = "clientsView_btn";
            this.clientsView_btn.Size = new System.Drawing.Size(158, 35);
            this.clientsView_btn.TabIndex = 32;
            this.clientsView_btn.Text = "View All";
            this.clientsView_btn.UseVisualStyleBackColor = false;
            // 
            // clientsFilter_btn
            // 
            this.clientsFilter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.clientsFilter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientsFilter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsFilter_btn.FlatAppearance.BorderSize = 0;
            this.clientsFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsFilter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsFilter_btn.Location = new System.Drawing.Point(8, 111);
            this.clientsFilter_btn.Name = "clientsFilter_btn";
            this.clientsFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.clientsFilter_btn.TabIndex = 31;
            this.clientsFilter_btn.Text = "Filter";
            this.clientsFilter_btn.UseVisualStyleBackColor = false;
            this.clientsFilter_btn.Click += new System.EventHandler(this.clientsFilter_btn_Click);
            // 
            // clientUsername_txt
            // 
            this.clientUsername_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientUsername_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientUsername_txt.Location = new System.Drawing.Point(8, 76);
            this.clientUsername_txt.Name = "clientUsername_txt";
            this.clientUsername_txt.Size = new System.Drawing.Size(158, 29);
            this.clientUsername_txt.TabIndex = 30;
            this.clientUsername_txt.Tag = "";
            // 
            // clientUsername_lbl
            // 
            this.clientUsername_lbl.AutoSize = true;
            this.clientUsername_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientUsername_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.clientUsername_lbl.Location = new System.Drawing.Point(4, 52);
            this.clientUsername_lbl.Name = "clientUsername_lbl";
            this.clientUsername_lbl.Size = new System.Drawing.Size(125, 21);
            this.clientUsername_lbl.TabIndex = 29;
            this.clientUsername_lbl.Text = "Client Username";
            // 
            // Clients_lbl
            // 
            this.Clients_lbl.AutoSize = true;
            this.Clients_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients_lbl.ForeColor = System.Drawing.Color.Black;
            this.Clients_lbl.Location = new System.Drawing.Point(3, 14);
            this.Clients_lbl.Name = "Clients_lbl";
            this.Clients_lbl.Size = new System.Drawing.Size(63, 30);
            this.Clients_lbl.TabIndex = 18;
            this.Clients_lbl.Text = "Users";
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.ForeColor = System.Drawing.Color.Black;
            this.Welcome_lbl.Location = new System.Drawing.Point(94, 29);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(497, 32);
            this.Welcome_lbl.TabIndex = 15;
            this.Welcome_lbl.Text = "Welcome back <Name> <Surname> (Admin)";
            // 
            // Logo_img
            // 
            this.Logo_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo_img.BackgroundImage")));
            this.Logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_img.Location = new System.Drawing.Point(12, 12);
            this.Logo_img.Name = "Logo_img";
            this.Logo_img.Size = new System.Drawing.Size(76, 61);
            this.Logo_img.TabIndex = 14;
            this.Logo_img.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Admin_tc);
            this.Controls.Add(this.Welcome_lbl);
            this.Controls.Add(this.Logo_img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Admin_tc.ResumeLayout(false);
            this.CRUD_tp.ResumeLayout(false);
            this.CRUD_tp.PerformLayout();
            this.Users_tp.ResumeLayout(false);
            this.Users_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.TabControl Admin_tc;
        private System.Windows.Forms.TabPage CRUD_tp;
        private System.Windows.Forms.Label userManagement_lbl;
        private System.Windows.Forms.TabPage Users_tp;
        private System.Windows.Forms.Label Clients_lbl;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.Button updateUser_btn;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.Label infoCRUD_lbl;
        private System.Windows.Forms.TextBox contractNumber_txt;
        private System.Windows.Forms.Label Role_lbl;
        private System.Windows.Forms.Label Number_lbl;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.DataGridView Users_dgv;
        private System.Windows.Forms.Button clientsView_btn;
        private System.Windows.Forms.Button clientsFilter_btn;
        private System.Windows.Forms.TextBox clientUsername_txt;
        private System.Windows.Forms.Label clientUsername_lbl;
        private System.Windows.Forms.ComboBox role_cmb;
        private System.Windows.Forms.TextBox province_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox street_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox streetNumber_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyName_txt;
        private System.Windows.Forms.Label label3;
    }
}