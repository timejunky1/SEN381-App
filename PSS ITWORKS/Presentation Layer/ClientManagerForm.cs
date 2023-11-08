using PSS_ITWORKS.ConstantData;
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
    public partial class ClientManagerForm : Form
    {
        private Dashboard dashboard;
        LoginController.UserInfo userInfo;
        string connString = SystemData.GetConString();
        public ClientManagerForm(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.userInfo = userInfo;
            welcome_lbl.Text = $"Welcome Back {userInfo.Name} {userInfo.Surname} <Client Manager>";
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }
    }
}
