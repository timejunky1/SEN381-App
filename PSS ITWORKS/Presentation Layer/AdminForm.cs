using PSS_ITWORKS.ConstantData;
using PSS_ITWORKS.LogicLayer;
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
        string conString = "";
        LoginController.UserInfo userInfo;
        public AdminForm(Dashboard dashboard, LoginController.UserInfo userInfo)
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
            this.userInfo = userInfo;
            Welcome_lbl.Text = $"Welcome Back {userInfo.Name} {userInfo.Surname} <Admin>";
        }

  
        private void AdminForm_Load(object sender, EventArgs e)
        {
            conString = SystemData.GetConString();
            cm = new StrategyContextManager(new StrategyClientManager());
            Users_dgv.DataSource = cm.Get();
            int id = 0;
            try
            {
                EntityClient client = cm.Get(id) as EntityClient;
            }
            catch
            {

            }

            cm = new StrategyContextManager(new StratagyEmployeeManagement());
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            EntityEmployee user = null;
            try
            {
             
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

        private void radioBtn_gb_Enter(object sender, EventArgs e)
        {

        }

        private void client_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (client_Rbtn.Checked) { clientDetails_gb.Visible=true; }
        }

        private void employee_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (employee_Rbtn.Checked) { clientDetails_gb.Visible = false; }
        }
    }
}
