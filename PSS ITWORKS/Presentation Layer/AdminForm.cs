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
        public AdminForm()
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
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            loginController = new LoginController();
            loginController.Connect();
            cm = new StrategyContextManager(new StrategyUserManager());
            cm.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            Users_dgv.DataSource = cm.Get();
            UserId = 0;
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            EntityUser user = null;
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
            cm.Delete(UserId, role_cmb.Text);
        }

        private void updateUser_btn_Click(object sender, EventArgs e)
        {
            EntityUser user = null;
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
    }
}
