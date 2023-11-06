﻿using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class AdminForm : Form
    {
        LoginController loginController;
        protected StrategyContextManager cm;
        int UserId;
        private Dashboard dashboard;
        public AdminForm(Dashboard dashboard)
        {
            InitializeComponent();
            role_cmb.Items.Clear();
            role_cmb.Items.Add("Admin");
            role_cmb.Items.Add("Technician");
            role_cmb.Items.Add("Call Employee");
            role_cmb.Items.Add("Client Manager");
            role_cmb.Items.Add("Contract Manager");
            role_cmb.Items.Add("Service Manager");
            role_cmb.Items.Add("Client Manager");
            role_cmb.Items.Add("Client");
            clientDetails_gb.Visible = false;
            clientDetails_gb.Enabled = false;
            this.dashboard = dashboard;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cm = new StrategyContextManager(new StrategyClientManager());
            Users_dgv.DataSource = cm.Get();
            int id = 0;
            try
            {
                EntityClient client = cm.Get(id) as EntityClient;
            }

            cm = new StrategyContextManager(new StratagyEmployeeManagement());
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            EntityEmployee user = null;
            try
            {
                user = new EntityUser(UserId, company_txt.Text, Name_txt.Text, Surname_txt.Text, 1,
                            int.Parse(address_txt.Text), street_txt.Text, city_txt.Text, province_txt.Text, zipCode_txt.Text,
                            Number_txt.Text, Username_txt.Text, DateTime.Now, role_cmb.Text);
            }
            catch
            {
                MessageBox.Show("Some Values are incorrect");
                return;
            }
            cm.Create(user);
            loginController.SetPassword(Username_txt.Text, Password_txt.Text, Password_txt.Text);
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            cm.Delete(UserId);
        }

        private void updateUser_btn_Click(object sender, EventArgs e)
        {
            EntityEmployee user = null;
            try
            {
                user = new EntityUser(UserId, company_txt.Text, Name_txt.Text, Surname_txt.Text, 1,
                       int.Parse(address_txt.Text), street_txt.Text, city_txt.Text, province_txt.Text, zipCode_txt.Text,
                       Number_txt.Text, Username_txt.Text, DateTime.Now, role_cmb.Text);
            }
            catch
            {
                MessageBox.Show("Some Values are incorrect");
                return;
            }
            cm.Update(user);
        }

        private void role_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(role_cmb.Text == "Client")
            {
                clientDetails_gb.Visible = true;
                clientDetails_gb.Enabled = true;
            }
            else
            {
                clientDetails_gb.Visible = false;
                clientDetails_gb.Enabled = false;
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            
            this.Close();
            dashboard.Show();
        }

        private void Email_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
