using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public partial class LogIn : Form
    {
        
        private LoginController loginController;
        public LogIn()
        {
            InitializeComponent();
            loginController = new LoginController();
            loginController.Connect();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = UserName_txt.Text;
            string password = Password_txt.Text;
            loginController.HandleLoginButtonClick(username, password, this, WelcomeLabel_txt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
