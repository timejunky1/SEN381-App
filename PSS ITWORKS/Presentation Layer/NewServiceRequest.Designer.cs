namespace PSS_ITWORKS.Presentation_Layer
{
    partial class ServiceRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestForm));
            this.PSS_lbl = new System.Windows.Forms.Label();
            this.PSS_img = new System.Windows.Forms.PictureBox();
            this.PersonalInfo_gbx = new System.Windows.Forms.GroupBox();
            this.EmailAddress_txt = new System.Windows.Forms.TextBox();
            this.EmailAddress_lbl = new System.Windows.Forms.Label();
            this.ContactNumber_txt = new System.Windows.Forms.TextBox();
            this.ContactNumber_lbl = new System.Windows.Forms.Label();
            this.CustomerName_txt = new System.Windows.Forms.TextBox();
            this.CustomerName_lbl = new System.Windows.Forms.Label();
            this.QueryInfo_gbx = new System.Windows.Forms.GroupBox();
            this.Description_rbx = new System.Windows.Forms.RichTextBox();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.ServiceType_cbx = new System.Windows.Forms.ComboBox();
            this.PriorityLevel__cbx = new System.Windows.Forms.ComboBox();
            this.ServiceType_lbl = new System.Windows.Forms.Label();
            this.PriorityLevel_lbl = new System.Windows.Forms.Label();
            this.EquipmentSerialNumber_txt = new System.Windows.Forms.TextBox();
            this.EquipmentSerialNumber_lbl = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).BeginInit();
            this.PersonalInfo_gbx.SuspendLayout();
            this.QueryInfo_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // PSS_lbl
            // 
            this.PSS_lbl.AutoSize = true;
            this.PSS_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSS_lbl.ForeColor = System.Drawing.Color.Black;
            this.PSS_lbl.Location = new System.Drawing.Point(94, 26);
            this.PSS_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PSS_lbl.Name = "PSS_lbl";
            this.PSS_lbl.Size = new System.Drawing.Size(313, 32);
            this.PSS_lbl.TabIndex = 1;
            this.PSS_lbl.Text = "Create New Service Request";
            // 
            // PSS_img
            // 
            this.PSS_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PSS_img.BackgroundImage")));
            this.PSS_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PSS_img.Location = new System.Drawing.Point(12, 9);
            this.PSS_img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSS_img.Name = "PSS_img";
            this.PSS_img.Size = new System.Drawing.Size(76, 61);
            this.PSS_img.TabIndex = 0;
            this.PSS_img.TabStop = false;
            // 
            // PersonalInfo_gbx
            // 
            this.PersonalInfo_gbx.Controls.Add(this.EmailAddress_txt);
            this.PersonalInfo_gbx.Controls.Add(this.EmailAddress_lbl);
            this.PersonalInfo_gbx.Controls.Add(this.ContactNumber_txt);
            this.PersonalInfo_gbx.Controls.Add(this.ContactNumber_lbl);
            this.PersonalInfo_gbx.Controls.Add(this.CustomerName_txt);
            this.PersonalInfo_gbx.Controls.Add(this.CustomerName_lbl);
            this.PersonalInfo_gbx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfo_gbx.Location = new System.Drawing.Point(25, 96);
            this.PersonalInfo_gbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PersonalInfo_gbx.Name = "PersonalInfo_gbx";
            this.PersonalInfo_gbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PersonalInfo_gbx.Size = new System.Drawing.Size(257, 248);
            this.PersonalInfo_gbx.TabIndex = 2;
            this.PersonalInfo_gbx.TabStop = false;
            this.PersonalInfo_gbx.Text = "Personal Information";
            // 
            // EmailAddress_txt
            // 
            this.EmailAddress_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress_txt.Location = new System.Drawing.Point(20, 168);
            this.EmailAddress_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailAddress_txt.Name = "EmailAddress_txt";
            this.EmailAddress_txt.Size = new System.Drawing.Size(214, 29);
            this.EmailAddress_txt.TabIndex = 5;
            // 
            // EmailAddress_lbl
            // 
            this.EmailAddress_lbl.AutoSize = true;
            this.EmailAddress_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.EmailAddress_lbl.Location = new System.Drawing.Point(16, 145);
            this.EmailAddress_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailAddress_lbl.Name = "EmailAddress_lbl";
            this.EmailAddress_lbl.Size = new System.Drawing.Size(108, 21);
            this.EmailAddress_lbl.TabIndex = 4;
            this.EmailAddress_lbl.Text = "Email Address";
            // 
            // ContactNumber_txt
            // 
            this.ContactNumber_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumber_txt.Location = new System.Drawing.Point(20, 107);
            this.ContactNumber_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactNumber_txt.Name = "ContactNumber_txt";
            this.ContactNumber_txt.Size = new System.Drawing.Size(214, 29);
            this.ContactNumber_txt.TabIndex = 3;
            // 
            // ContactNumber_lbl
            // 
            this.ContactNumber_lbl.AutoSize = true;
            this.ContactNumber_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumber_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ContactNumber_lbl.Location = new System.Drawing.Point(16, 84);
            this.ContactNumber_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContactNumber_lbl.Name = "ContactNumber_lbl";
            this.ContactNumber_lbl.Size = new System.Drawing.Size(125, 21);
            this.ContactNumber_lbl.TabIndex = 2;
            this.ContactNumber_lbl.Text = "Contact Number";
            // 
            // CustomerName_txt
            // 
            this.CustomerName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName_txt.Location = new System.Drawing.Point(21, 46);
            this.CustomerName_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerName_txt.Name = "CustomerName_txt";
            this.CustomerName_txt.Size = new System.Drawing.Size(213, 29);
            this.CustomerName_txt.TabIndex = 1;
            // 
            // CustomerName_lbl
            // 
            this.CustomerName_lbl.AutoSize = true;
            this.CustomerName_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.CustomerName_lbl.Location = new System.Drawing.Point(16, 23);
            this.CustomerName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerName_lbl.Name = "CustomerName_lbl";
            this.CustomerName_lbl.Size = new System.Drawing.Size(124, 21);
            this.CustomerName_lbl.TabIndex = 0;
            this.CustomerName_lbl.Text = "Customer Name";
            // 
            // QueryInfo_gbx
            // 
            this.QueryInfo_gbx.Controls.Add(this.Description_rbx);
            this.QueryInfo_gbx.Controls.Add(this.Description_lbl);
            this.QueryInfo_gbx.Controls.Add(this.ServiceType_cbx);
            this.QueryInfo_gbx.Controls.Add(this.PriorityLevel__cbx);
            this.QueryInfo_gbx.Controls.Add(this.ServiceType_lbl);
            this.QueryInfo_gbx.Controls.Add(this.PriorityLevel_lbl);
            this.QueryInfo_gbx.Controls.Add(this.EquipmentSerialNumber_txt);
            this.QueryInfo_gbx.Controls.Add(this.EquipmentSerialNumber_lbl);
            this.QueryInfo_gbx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryInfo_gbx.Location = new System.Drawing.Point(301, 96);
            this.QueryInfo_gbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryInfo_gbx.Name = "QueryInfo_gbx";
            this.QueryInfo_gbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryInfo_gbx.Size = new System.Drawing.Size(526, 248);
            this.QueryInfo_gbx.TabIndex = 3;
            this.QueryInfo_gbx.TabStop = false;
            this.QueryInfo_gbx.Text = "Query Information";
            // 
            // Description_rbx
            // 
            this.Description_rbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_rbx.Location = new System.Drawing.Point(241, 50);
            this.Description_rbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Description_rbx.Name = "Description_rbx";
            this.Description_rbx.Size = new System.Drawing.Size(281, 159);
            this.Description_rbx.TabIndex = 15;
            this.Description_rbx.Text = "";
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.Description_lbl.Location = new System.Drawing.Point(237, 23);
            this.Description_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(146, 21);
            this.Description_lbl.TabIndex = 14;
            this.Description_lbl.Text = "Description of Issue";
            this.Description_lbl.Click += new System.EventHandler(this.Description_lbl_Click);
            // 
            // ServiceType_cbx
            // 
            this.ServiceType_cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceType_cbx.FormattingEnabled = true;
            this.ServiceType_cbx.Location = new System.Drawing.Point(14, 168);
            this.ServiceType_cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceType_cbx.Name = "ServiceType_cbx";
            this.ServiceType_cbx.Size = new System.Drawing.Size(190, 29);
            this.ServiceType_cbx.TabIndex = 13;
            // 
            // PriorityLevel__cbx
            // 
            this.PriorityLevel__cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityLevel__cbx.FormattingEnabled = true;
            this.PriorityLevel__cbx.Location = new System.Drawing.Point(14, 107);
            this.PriorityLevel__cbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriorityLevel__cbx.Name = "PriorityLevel__cbx";
            this.PriorityLevel__cbx.Size = new System.Drawing.Size(190, 29);
            this.PriorityLevel__cbx.TabIndex = 12;
            // 
            // ServiceType_lbl
            // 
            this.ServiceType_lbl.AutoSize = true;
            this.ServiceType_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceType_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.ServiceType_lbl.Location = new System.Drawing.Point(11, 145);
            this.ServiceType_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceType_lbl.Name = "ServiceType_lbl";
            this.ServiceType_lbl.Size = new System.Drawing.Size(96, 21);
            this.ServiceType_lbl.TabIndex = 10;
            this.ServiceType_lbl.Text = "Service Type";
            // 
            // PriorityLevel_lbl
            // 
            this.PriorityLevel_lbl.AutoSize = true;
            this.PriorityLevel_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityLevel_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.PriorityLevel_lbl.Location = new System.Drawing.Point(11, 84);
            this.PriorityLevel_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriorityLevel_lbl.Name = "PriorityLevel_lbl";
            this.PriorityLevel_lbl.Size = new System.Drawing.Size(101, 21);
            this.PriorityLevel_lbl.TabIndex = 8;
            this.PriorityLevel_lbl.Text = "Priority Level";
            // 
            // EquipmentSerialNumber_txt
            // 
            this.EquipmentSerialNumber_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentSerialNumber_txt.Location = new System.Drawing.Point(15, 46);
            this.EquipmentSerialNumber_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EquipmentSerialNumber_txt.Name = "EquipmentSerialNumber_txt";
            this.EquipmentSerialNumber_txt.Size = new System.Drawing.Size(189, 29);
            this.EquipmentSerialNumber_txt.TabIndex = 7;
            // 
            // EquipmentSerialNumber_lbl
            // 
            this.EquipmentSerialNumber_lbl.AutoSize = true;
            this.EquipmentSerialNumber_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentSerialNumber_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.EquipmentSerialNumber_lbl.Location = new System.Drawing.Point(11, 23);
            this.EquipmentSerialNumber_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EquipmentSerialNumber_lbl.Name = "EquipmentSerialNumber_lbl";
            this.EquipmentSerialNumber_lbl.Size = new System.Drawing.Size(190, 21);
            this.EquipmentSerialNumber_lbl.TabIndex = 6;
            this.EquipmentSerialNumber_lbl.Text = "Equipment Serial Number";
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Submit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_btn.FlatAppearance.BorderSize = 0;
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.ForeColor = System.Drawing.Color.White;
            this.Submit_btn.Location = new System.Drawing.Point(25, 359);
            this.Submit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(158, 35);
            this.Submit_btn.TabIndex = 4;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(201, 359);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(158, 35);
            this.Close_btn.TabIndex = 5;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            // 
            // ServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.PSS_img);
            this.Controls.Add(this.PSS_lbl);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.QueryInfo_gbx);
            this.Controls.Add(this.PersonalInfo_gbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ServiceRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request";
            ((System.ComponentModel.ISupportInitialize)(this.PSS_img)).EndInit();
            this.PersonalInfo_gbx.ResumeLayout(false);
            this.PersonalInfo_gbx.PerformLayout();
            this.QueryInfo_gbx.ResumeLayout(false);
            this.QueryInfo_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PSS_lbl;
        private System.Windows.Forms.PictureBox PSS_img;
        private System.Windows.Forms.GroupBox PersonalInfo_gbx;
        private System.Windows.Forms.TextBox EmailAddress_txt;
        private System.Windows.Forms.Label EmailAddress_lbl;
        private System.Windows.Forms.TextBox ContactNumber_txt;
        private System.Windows.Forms.Label ContactNumber_lbl;
        private System.Windows.Forms.TextBox CustomerName_txt;
        private System.Windows.Forms.Label CustomerName_lbl;
        private System.Windows.Forms.GroupBox QueryInfo_gbx;
        private System.Windows.Forms.RichTextBox Description_rbx;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.ComboBox ServiceType_cbx;
        private System.Windows.Forms.ComboBox PriorityLevel__cbx;
        private System.Windows.Forms.Label ServiceType_lbl;
        private System.Windows.Forms.Label PriorityLevel_lbl;
        private System.Windows.Forms.TextBox EquipmentSerialNumber_txt;
        private System.Windows.Forms.Label EquipmentSerialNumber_lbl;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button Close_btn;
    }
}