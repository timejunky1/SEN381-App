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
        string connString = SystemData.GetConString();
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
            
            this.dashboard = dashboard;
            this.userInfo = userInfo;
            Welcome_lbl.Text = $"Welcome Back {userInfo.Name} {userInfo.Surname} <Admin>";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Welcome_lbl.Text = $"Welcome {userInfo.Name} {userInfo.Surname} (Admin)";
            cm = new StrategyContextManager(new StrategyClientManager());
            cm.Connect(connString);
            Users_dgv.Rows.Clear();
            Users_dgv.ColumnCount = 8;
            List<IEntity> entities = cm.Get();
            foreach(IEntity entity in entities)
            {
                EntityClient client = entity as EntityClient;
                Users_dgv.Rows.Add(client.GetEmail(), client.GetName(), client.GetSurname(), "client", client.GetStreetNumber(), client.GetStreetName(), client.GetCity(), client.GetZipCode());
            }
            cm = new StrategyContextManager(new StratagyEmployeeManagement());
            cm.Connect(connString);
            entities.Clear();
            entities = cm.Get();
            foreach (IEntity entity in entities)
            {
                EntityEmployee client = entity as EntityEmployee;
                Users_dgv.Rows.Add(client.GetEmail(), client.GetName(), client.GetSurname(), client.GetRole(), client.GetStreetNumber(), client.GetStreetName(), client.GetCity(), client.GetZipCode());
            }
        }

        void FilterByName(string username)
        {
            cm = new StrategyContextManager(new StrategyClientManager());
            cm.Connect(connString);
            Users_dgv.Rows.Clear();
            Users_dgv.ColumnCount = 8;
            List<IEntity> entities = cm.Get();
            foreach (IEntity entity in entities)
            {
                EntityClient client = entity as EntityClient;
                Users_dgv.Rows.Add(client.GetEmail(), client.GetName(), client.GetSurname(), "client", client.GetStreetNumber(), client.GetStreetName(), client.GetCity(), client.GetZipCode());
            }
            cm = new StrategyContextManager(new StratagyEmployeeManagement());
            cm.Connect(connString);
            entities.Clear();
            entities = cm.Get();
            foreach (IEntity entity in entities)
            {
                EntityEmployee client = entity as EntityEmployee;
                Users_dgv.Rows.Add(client.GetEmail(), client.GetName(), client.GetSurname(), client.GetRole(), client.GetStreetNumber(), client.GetStreetName(), client.GetCity(), client.GetZipCode());
            }
        }

        void GetIDFromEmail()
        {
            if (role_cmb.Text == "Client")
            {
                cm = new StrategyContextManager(new StrategyClientManager());
                cm.Connect(connString);
                List<IEntity> entities = cm.Get();
                foreach(IEntity entity in entities)
                {
                    EntityClient client = entity as EntityClient;
                    if (client.GetEmail() == clientUsername_txt.Text)
                    {
                        UserId = client.GetID();
                    }
                }
            }
            else
            {
                cm = new StrategyContextManager(new StratagyEmployeeManagement());
                cm.Connect(connString);
                List<IEntity> entities = cm.Get();
                foreach (IEntity entity in entities)
                {
                    EntityEmployee employee = entity as EntityEmployee;
                    if (employee.GetEmail() == clientUsername_txt.Text)
                    {
                        UserId = employee.GetID();
                    }
                }
            }
        }
        private void addUser_btn_Click(object sender, EventArgs e)
        {
            if(role_cmb.SelectedItem.ToString() == "Client")
            {
                cm.Update(new EntityClient(UserId, companyName_txt.Text, Name_txt.Text, Surname_txt.Text, role_cmb.Text, int.Parse(contractNumber_txt.Text), phone_txt.Text, Username_txt.Text, 
                    DateTime.Now, int.Parse(streetNumber_txt.Text), street_txt.Text, city_txt.Text, province_txt.Text, "0001"));
            }
            else
            {
                cm.Update(new EntityEmployee(UserId, Name_txt.Text, Surname_txt.Text, role_cmb.Text, phone_txt.Text, Username_txt.Text,
                    int.Parse(streetNumber_txt.Text), street_txt.Text, city_txt.Text, province_txt.Text, "0001")); ;
            }
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            cm.Delete(UserId);
        }

        private void updateUser_btn_Click(object sender, EventArgs e)
        {
            if (role_cmb.SelectedItem.ToString() == "Client")
            {
                cm.Update(new EntityClient(UserId, companyName_txt.Text, Name_txt.Text, Surname_txt.Text, role_cmb.Text, int.Parse(contractNumber_txt.Text), phone_txt.Text, Username_txt.Text,
                    DateTime.Now, int.Parse(streetNumber_txt.Text), street_txt.Text, city_txt.Text, province_txt.Text, "0001"));
            }
            else
            {
                cm.Update(new EntityEmployee(UserId, Name_txt.Text, Surname_txt.Text, role_cmb.Text, phone_txt.Text, Username_txt.Text,
                    int.Parse(streetNumber_txt.Text), street_txt.Text, city_txt.Text, province_txt.Text, "0001")); ;
            }
        }

        private void role_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(role_cmb.SelectedItem.ToString() == "Client")
            {
                cm = new StrategyContextManager(new StrategyClientManager());
                cm.Connect(connString);
            }
            else
            {
                cm = new StrategyContextManager(new StratagyEmployeeManagement());
                cm.Connect(connString);
            }
        }

        private void Users_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Username_txt.Text = Users_dgv.Rows[Users_dgv.CurrentRow.Index].Cells[0].Value.ToString();
            string role = Users_dgv.Rows[Users_dgv.CurrentRow.Index].Cells[4].Value.ToString();
            UserId = 1;
            role_cmb.SelectedIndex = role_cmb.Items.IndexOf(role);
            //GetIDFromEmail();
            if (role == "Client")
            {
                cm = new StrategyContextManager(new StrategyClientManager());
                cm.Connect(connString);
                EntityClient client = cm.Get(UserId) as EntityClient;
                companyName_txt.Text = client.GetCompanyName();
                Name_txt.Text = client.GetName();
                Surname_txt.Text = client.GetSurname();
                role_cmb.Text = "Client";
                contractNumber_txt.Text = $"{client.GetContractId()}";
                phone_txt.Text = client.GetPhone();
                Username_txt.Text = client.GetEmail();
                streetNumber_txt.Text = client.GetStreetNumber().ToString();
                street_txt.Text = client.GetStreetName();
                city_txt.Text = client.GetCity();
                province_txt.Text = client.GetProvince();
            }
            else
            {
                cm = new StrategyContextManager(new StratagyEmployeeManagement());
                cm.Connect(connString);
                EntityEmployee employee = cm.Get(UserId) as EntityEmployee;
                Name_txt.Text = employee.GetName();
                Surname_txt.Text = employee.GetSurname();
                role_cmb.Text = employee.GetRole();
                phone_txt.Text = employee.GetPhone();
                Username_txt.Text = employee.GetEmail();
                streetNumber_txt.Text = employee.GetStreetNumber().ToString();
                street_txt.Text = employee.GetStreetName();
                city_txt.Text = employee.GetCity();
                province_txt.Text = employee.GetProvince();
            }
        }

        private void clientsFilter_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
