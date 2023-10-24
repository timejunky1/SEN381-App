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
            System.Windows.Forms.TextBox Email_txt;
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Admin_tc = new System.Windows.Forms.TabControl();
            this.CRUD_tp = new System.Windows.Forms.TabPage();
            this.userManagement_lbl = new System.Windows.Forms.Label();
            this.systemSettings_tp = new System.Windows.Forms.TabPage();
            this.jobStatus_dud = new System.Windows.Forms.DomainUpDown();
            this.jobStatus_lbl = new System.Windows.Forms.Label();
            this.jobNotes_lbl = new System.Windows.Forms.Label();
            this.jobNotes_rtb = new System.Windows.Forms.RichTextBox();
            this.submitUpdate_btn = new System.Windows.Forms.Button();
            this.searchJob_btn = new System.Windows.Forms.Button();
            this.jobID_txt = new System.Windows.Forms.TextBox();
            this.JobID_lbl = new System.Windows.Forms.Label();
            this.taskUpdateInfo_lbl = new System.Windows.Forms.Label();
            this.taskUpdate_lbl = new System.Windows.Forms.Label();
            this.Users_tp = new System.Windows.Forms.TabPage();
            this.Clients_lbl = new System.Windows.Forms.Label();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.Logo_img = new System.Windows.Forms.PictureBox();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.updateUser_btn = new System.Windows.Forms.Button();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.Number_lbl = new System.Windows.Forms.Label();
            this.Role_txt = new System.Windows.Forms.TextBox();
            this.Role_lbl = new System.Windows.Forms.Label();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.DOB_lbl = new System.Windows.Forms.Label();
            this.DOB_dtp = new System.Windows.Forms.DateTimePicker();
            this.Number_txt = new System.Windows.Forms.TextBox();
            this.infoCRUD_lbl = new System.Windows.Forms.Label();
            this.clientUsername_txt = new System.Windows.Forms.TextBox();
            this.clientUsername_lbl = new System.Windows.Forms.Label();
            this.clientsFilter_btn = new System.Windows.Forms.Button();
            this.clientsView_btn = new System.Windows.Forms.Button();
            this.employeeView_btn = new System.Windows.Forms.Button();
            this.employeeFilter_btn = new System.Windows.Forms.Button();
            this.employeeID_txt = new System.Windows.Forms.TextBox();
            this.employeeID_lbl = new System.Windows.Forms.Label();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Users_dgv = new System.Windows.Forms.DataGridView();
            Email_txt = new System.Windows.Forms.TextBox();
            this.Admin_tc.SuspendLayout();
            this.CRUD_tp.SuspendLayout();
            this.systemSettings_tp.SuspendLayout();
            this.Users_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dgv)).BeginInit();
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
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            // 
            // Admin_tc
            // 
            this.Admin_tc.Controls.Add(this.CRUD_tp);
            this.Admin_tc.Controls.Add(this.systemSettings_tp);
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
            this.CRUD_tp.Controls.Add(this.infoCRUD_lbl);
            this.CRUD_tp.Controls.Add(this.Number_txt);
            this.CRUD_tp.Controls.Add(this.DOB_dtp);
            this.CRUD_tp.Controls.Add(this.Role_txt);
            this.CRUD_tp.Controls.Add(this.Role_lbl);
            this.CRUD_tp.Controls.Add(this.Address_txt);
            this.CRUD_tp.Controls.Add(this.Address_lbl);
            this.CRUD_tp.Controls.Add(this.DOB_lbl);
            this.CRUD_tp.Controls.Add(this.Number_lbl);
            this.CRUD_tp.Controls.Add(this.Surname_txt);
            this.CRUD_tp.Controls.Add(this.Surname_lbl);
            this.CRUD_tp.Controls.Add(this.Name_txt);
            this.CRUD_tp.Controls.Add(this.Name_lbl);
            this.CRUD_tp.Controls.Add(Email_txt);
            this.CRUD_tp.Controls.Add(this.Email_lbl);
            this.CRUD_tp.Controls.Add(this.Password_txt);
            this.CRUD_tp.Controls.Add(this.Password_lbl);
            this.CRUD_tp.Controls.Add(this.Username_txt);
            this.CRUD_tp.Controls.Add(this.Username_lbl);
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
            // systemSettings_tp
            // 
            this.systemSettings_tp.Controls.Add(this.jobStatus_dud);
            this.systemSettings_tp.Controls.Add(this.jobStatus_lbl);
            this.systemSettings_tp.Controls.Add(this.jobNotes_lbl);
            this.systemSettings_tp.Controls.Add(this.jobNotes_rtb);
            this.systemSettings_tp.Controls.Add(this.submitUpdate_btn);
            this.systemSettings_tp.Controls.Add(this.searchJob_btn);
            this.systemSettings_tp.Controls.Add(this.jobID_txt);
            this.systemSettings_tp.Controls.Add(this.JobID_lbl);
            this.systemSettings_tp.Controls.Add(this.taskUpdateInfo_lbl);
            this.systemSettings_tp.Controls.Add(this.taskUpdate_lbl);
            this.systemSettings_tp.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.systemSettings_tp.Location = new System.Drawing.Point(4, 39);
            this.systemSettings_tp.Name = "systemSettings_tp";
            this.systemSettings_tp.Padding = new System.Windows.Forms.Padding(3);
            this.systemSettings_tp.Size = new System.Drawing.Size(865, 413);
            this.systemSettings_tp.TabIndex = 1;
            this.systemSettings_tp.Text = "System Settings";
            this.systemSettings_tp.UseVisualStyleBackColor = true;
            // 
            // jobStatus_dud
            // 
            this.jobStatus_dud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobStatus_dud.Location = new System.Drawing.Point(299, 267);
            this.jobStatus_dud.Name = "jobStatus_dud";
            this.jobStatus_dud.Size = new System.Drawing.Size(159, 29);
            this.jobStatus_dud.TabIndex = 25;
            this.jobStatus_dud.Text = "domainUpDown1";
            // 
            // jobStatus_lbl
            // 
            this.jobStatus_lbl.AutoSize = true;
            this.jobStatus_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobStatus_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.jobStatus_lbl.Location = new System.Drawing.Point(295, 243);
            this.jobStatus_lbl.Name = "jobStatus_lbl";
            this.jobStatus_lbl.Size = new System.Drawing.Size(80, 21);
            this.jobStatus_lbl.TabIndex = 24;
            this.jobStatus_lbl.Text = "Job Status";
            // 
            // jobNotes_lbl
            // 
            this.jobNotes_lbl.AutoSize = true;
            this.jobNotes_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNotes_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.jobNotes_lbl.Location = new System.Drawing.Point(295, 84);
            this.jobNotes_lbl.Name = "jobNotes_lbl";
            this.jobNotes_lbl.Size = new System.Drawing.Size(79, 21);
            this.jobNotes_lbl.TabIndex = 23;
            this.jobNotes_lbl.Text = "Job Notes";
            // 
            // jobNotes_rtb
            // 
            this.jobNotes_rtb.Location = new System.Drawing.Point(297, 108);
            this.jobNotes_rtb.Name = "jobNotes_rtb";
            this.jobNotes_rtb.Size = new System.Drawing.Size(531, 119);
            this.jobNotes_rtb.TabIndex = 22;
            this.jobNotes_rtb.Text = "";
            // 
            // submitUpdate_btn
            // 
            this.submitUpdate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(183)))), ((int)(((byte)(132)))));
            this.submitUpdate_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitUpdate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitUpdate_btn.FlatAppearance.BorderSize = 0;
            this.submitUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitUpdate_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdate_btn.ForeColor = System.Drawing.Color.White;
            this.submitUpdate_btn.Location = new System.Drawing.Point(297, 329);
            this.submitUpdate_btn.Name = "submitUpdate_btn";
            this.submitUpdate_btn.Size = new System.Drawing.Size(158, 35);
            this.submitUpdate_btn.TabIndex = 21;
            this.submitUpdate_btn.Text = "Submit";
            this.submitUpdate_btn.UseVisualStyleBackColor = false;
            // 
            // searchJob_btn
            // 
            this.searchJob_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.searchJob_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchJob_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchJob_btn.FlatAppearance.BorderSize = 0;
            this.searchJob_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchJob_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJob_btn.Location = new System.Drawing.Point(11, 156);
            this.searchJob_btn.Name = "searchJob_btn";
            this.searchJob_btn.Size = new System.Drawing.Size(158, 35);
            this.searchJob_btn.TabIndex = 20;
            this.searchJob_btn.Text = "Search";
            this.searchJob_btn.UseVisualStyleBackColor = false;
            // 
            // jobID_txt
            // 
            this.jobID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jobID_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobID_txt.Location = new System.Drawing.Point(11, 108);
            this.jobID_txt.Name = "jobID_txt";
            this.jobID_txt.Size = new System.Drawing.Size(158, 29);
            this.jobID_txt.TabIndex = 19;
            this.jobID_txt.Tag = "";
            // 
            // JobID_lbl
            // 
            this.JobID_lbl.AutoSize = true;
            this.JobID_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.JobID_lbl.Location = new System.Drawing.Point(7, 84);
            this.JobID_lbl.Name = "JobID_lbl";
            this.JobID_lbl.Size = new System.Drawing.Size(53, 21);
            this.JobID_lbl.TabIndex = 18;
            this.JobID_lbl.Text = "Job ID";
            // 
            // taskUpdateInfo_lbl
            // 
            this.taskUpdateInfo_lbl.AutoSize = true;
            this.taskUpdateInfo_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskUpdateInfo_lbl.ForeColor = System.Drawing.Color.Black;
            this.taskUpdateInfo_lbl.Location = new System.Drawing.Point(6, 44);
            this.taskUpdateInfo_lbl.Name = "taskUpdateInfo_lbl";
            this.taskUpdateInfo_lbl.Size = new System.Drawing.Size(558, 25);
            this.taskUpdateInfo_lbl.TabIndex = 17;
            this.taskUpdateInfo_lbl.Text = "Real-time Status Monitoring and Collaborative Task Management";
            // 
            // taskUpdate_lbl
            // 
            this.taskUpdate_lbl.AutoSize = true;
            this.taskUpdate_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskUpdate_lbl.ForeColor = System.Drawing.Color.Black;
            this.taskUpdate_lbl.Location = new System.Drawing.Point(6, 14);
            this.taskUpdate_lbl.Name = "taskUpdate_lbl";
            this.taskUpdate_lbl.Size = new System.Drawing.Size(342, 30);
            this.taskUpdate_lbl.TabIndex = 16;
            this.taskUpdate_lbl.Text = "Task Updates and Progress Tracking";
            // 
            // Users_tp
            // 
            this.Users_tp.Controls.Add(this.Users_dgv);
            this.Users_tp.Controls.Add(this.employeeView_btn);
            this.Users_tp.Controls.Add(this.employeeFilter_btn);
            this.Users_tp.Controls.Add(this.employeeID_txt);
            this.Users_tp.Controls.Add(this.employeeID_lbl);
            this.Users_tp.Controls.Add(this.Employee_lbl);
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
            // Clients_lbl
            // 
            this.Clients_lbl.AutoSize = true;
            this.Clients_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients_lbl.ForeColor = System.Drawing.Color.Black;
            this.Clients_lbl.Location = new System.Drawing.Point(3, 14);
            this.Clients_lbl.Name = "Clients_lbl";
            this.Clients_lbl.Size = new System.Drawing.Size(75, 30);
            this.Clients_lbl.TabIndex = 18;
            this.Clients_lbl.Text = "Clients";
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
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Username_lbl.Location = new System.Drawing.Point(25, 130);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(81, 21);
            this.Username_lbl.TabIndex = 27;
            this.Username_lbl.Text = "Username";
            // 
            // Password_txt
            // 
            this.Password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(29, 230);
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
            this.Password_lbl.Location = new System.Drawing.Point(25, 206);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(76, 21);
            this.Password_lbl.TabIndex = 30;
            this.Password_lbl.Text = "Password";
            // 
            // Email_txt
            // 
            Email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            Email_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Email_txt.Location = new System.Drawing.Point(29, 312);
            Email_txt.Name = "Email_txt";
            Email_txt.Size = new System.Drawing.Size(158, 29);
            Email_txt.TabIndex = 33;
            Email_txt.Tag = "";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Email_lbl.Location = new System.Drawing.Point(25, 288);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(48, 21);
            this.Email_lbl.TabIndex = 32;
            this.Email_lbl.Text = "Email";
            // 
            // Name_txt
            // 
            this.Name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(271, 154);
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
            this.Name_lbl.Location = new System.Drawing.Point(267, 130);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(52, 21);
            this.Name_lbl.TabIndex = 34;
            this.Name_lbl.Text = "Name";
            // 
            // Surname_txt
            // 
            this.Surname_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Surname_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_txt.Location = new System.Drawing.Point(271, 230);
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
            this.Surname_lbl.Location = new System.Drawing.Point(267, 206);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(73, 21);
            this.Surname_lbl.TabIndex = 36;
            this.Surname_lbl.Text = "Surname";
            // 
            // Number_lbl
            // 
            this.Number_lbl.AutoSize = true;
            this.Number_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Number_lbl.Location = new System.Drawing.Point(267, 288);
            this.Number_lbl.Name = "Number_lbl";
            this.Number_lbl.Size = new System.Drawing.Size(125, 21);
            this.Number_lbl.TabIndex = 38;
            this.Number_lbl.Text = "Contact Number";
            // 
            // Role_txt
            // 
            this.Role_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Role_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_txt.Location = new System.Drawing.Point(494, 312);
            this.Role_txt.Name = "Role_txt";
            this.Role_txt.Size = new System.Drawing.Size(158, 29);
            this.Role_txt.TabIndex = 45;
            this.Role_txt.Tag = "";
            // 
            // Role_lbl
            // 
            this.Role_lbl.AutoSize = true;
            this.Role_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Role_lbl.Location = new System.Drawing.Point(490, 288);
            this.Role_lbl.Name = "Role_lbl";
            this.Role_lbl.Size = new System.Drawing.Size(41, 21);
            this.Role_lbl.TabIndex = 44;
            this.Role_lbl.Text = "Role";
            // 
            // Address_txt
            // 
            this.Address_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_txt.Location = new System.Drawing.Point(494, 230);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(158, 29);
            this.Address_txt.TabIndex = 43;
            this.Address_txt.Tag = "";
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Address_lbl.Location = new System.Drawing.Point(490, 206);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(66, 21);
            this.Address_lbl.TabIndex = 42;
            this.Address_lbl.Text = "Address";
            // 
            // DOB_lbl
            // 
            this.DOB_lbl.AutoSize = true;
            this.DOB_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.DOB_lbl.Location = new System.Drawing.Point(490, 130);
            this.DOB_lbl.Name = "DOB_lbl";
            this.DOB_lbl.Size = new System.Drawing.Size(97, 21);
            this.DOB_lbl.TabIndex = 40;
            this.DOB_lbl.Text = "Date of Birth";
            // 
            // DOB_dtp
            // 
            this.DOB_dtp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_dtp.Location = new System.Drawing.Point(494, 154);
            this.DOB_dtp.Name = "DOB_dtp";
            this.DOB_dtp.Size = new System.Drawing.Size(158, 29);
            this.DOB_dtp.TabIndex = 46;
            // 
            // Number_txt
            // 
            this.Number_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Number_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_txt.Location = new System.Drawing.Point(271, 312);
            this.Number_txt.Name = "Number_txt";
            this.Number_txt.Size = new System.Drawing.Size(158, 29);
            this.Number_txt.TabIndex = 47;
            this.Number_txt.Tag = "";
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
            // employeeView_btn
            // 
            this.employeeView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.employeeView_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employeeView_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeView_btn.FlatAppearance.BorderSize = 0;
            this.employeeView_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeView_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeView_btn.Location = new System.Drawing.Point(8, 339);
            this.employeeView_btn.Name = "employeeView_btn";
            this.employeeView_btn.Size = new System.Drawing.Size(158, 35);
            this.employeeView_btn.TabIndex = 37;
            this.employeeView_btn.Text = "View All";
            this.employeeView_btn.UseVisualStyleBackColor = false;
            // 
            // employeeFilter_btn
            // 
            this.employeeFilter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(91)))));
            this.employeeFilter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employeeFilter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeFilter_btn.FlatAppearance.BorderSize = 0;
            this.employeeFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeFilter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeFilter_btn.Location = new System.Drawing.Point(8, 298);
            this.employeeFilter_btn.Name = "employeeFilter_btn";
            this.employeeFilter_btn.Size = new System.Drawing.Size(158, 35);
            this.employeeFilter_btn.TabIndex = 36;
            this.employeeFilter_btn.Text = "Filter";
            this.employeeFilter_btn.UseVisualStyleBackColor = false;
            // 
            // employeeID_txt
            // 
            this.employeeID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeID_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeID_txt.Location = new System.Drawing.Point(8, 263);
            this.employeeID_txt.Name = "employeeID_txt";
            this.employeeID_txt.Size = new System.Drawing.Size(158, 29);
            this.employeeID_txt.TabIndex = 35;
            this.employeeID_txt.Tag = "";
            // 
            // employeeID_lbl
            // 
            this.employeeID_lbl.AutoSize = true;
            this.employeeID_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.employeeID_lbl.Location = new System.Drawing.Point(4, 239);
            this.employeeID_lbl.Name = "employeeID_lbl";
            this.employeeID_lbl.Size = new System.Drawing.Size(97, 21);
            this.employeeID_lbl.TabIndex = 34;
            this.employeeID_lbl.Text = "Employee ID";
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_lbl.ForeColor = System.Drawing.Color.Black;
            this.Employee_lbl.Location = new System.Drawing.Point(3, 201);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(103, 30);
            this.Employee_lbl.TabIndex = 33;
            this.Employee_lbl.Text = "Employee";
            // 
            // Users_dgv
            // 
            this.Users_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dgv.Location = new System.Drawing.Point(286, 52);
            this.Users_dgv.Name = "Users_dgv";
            this.Users_dgv.Size = new System.Drawing.Size(552, 322);
            this.Users_dgv.TabIndex = 38;
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
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Admin_tc.ResumeLayout(false);
            this.CRUD_tp.ResumeLayout(false);
            this.CRUD_tp.PerformLayout();
            this.systemSettings_tp.ResumeLayout(false);
            this.systemSettings_tp.PerformLayout();
            this.Users_tp.ResumeLayout(false);
            this.Users_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.TabControl Admin_tc;
        private System.Windows.Forms.TabPage CRUD_tp;
        private System.Windows.Forms.Label userManagement_lbl;
        private System.Windows.Forms.TabPage systemSettings_tp;
        private System.Windows.Forms.DomainUpDown jobStatus_dud;
        private System.Windows.Forms.Label jobStatus_lbl;
        private System.Windows.Forms.Label jobNotes_lbl;
        private System.Windows.Forms.RichTextBox jobNotes_rtb;
        private System.Windows.Forms.Button submitUpdate_btn;
        private System.Windows.Forms.Button searchJob_btn;
        private System.Windows.Forms.TextBox jobID_txt;
        private System.Windows.Forms.Label JobID_lbl;
        private System.Windows.Forms.Label taskUpdateInfo_lbl;
        private System.Windows.Forms.Label taskUpdate_lbl;
        private System.Windows.Forms.TabPage Users_tp;
        private System.Windows.Forms.Label Clients_lbl;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.PictureBox Logo_img;
        private System.Windows.Forms.Button updateUser_btn;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.Label infoCRUD_lbl;
        private System.Windows.Forms.TextBox Number_txt;
        private System.Windows.Forms.DateTimePicker DOB_dtp;
        private System.Windows.Forms.TextBox Role_txt;
        private System.Windows.Forms.Label Role_lbl;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.Label DOB_lbl;
        private System.Windows.Forms.Label Number_lbl;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.DataGridView Users_dgv;
        private System.Windows.Forms.Button employeeView_btn;
        private System.Windows.Forms.Button employeeFilter_btn;
        private System.Windows.Forms.TextBox employeeID_txt;
        private System.Windows.Forms.Label employeeID_lbl;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.Button clientsView_btn;
        private System.Windows.Forms.Button clientsFilter_btn;
        private System.Windows.Forms.TextBox clientUsername_txt;
        private System.Windows.Forms.Label clientUsername_lbl;
    }
}