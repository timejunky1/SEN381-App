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
    public partial class Dashboard: Form

    {
        private LoginController loginController;
        private LoginController.UserInfo userInfo; 
        private LogIn loginForm;

        public Dashboard(LoginController loginController, LoginController.UserInfo userInfo,LogIn loginForm)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.userInfo = userInfo;
            this.loginForm = loginForm;
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            userInfo = null;

            this.Close();

            LogIn loginForm = new LogIn();
            loginForm.Show();

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            FactoryAMainFactory factory = new FactoryUserFactory(loginController);
            FactoryIUser userPortal = factory.CreateUser(userInfo.Role);
            userPortal.ShowUserInterface(this, userInfo);

        }

        private void ChangePass_btn_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
