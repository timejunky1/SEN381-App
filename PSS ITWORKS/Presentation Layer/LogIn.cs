using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public partial class LogIn : Form
    {
        StrategyContextManager context = new StrategyContextManager();
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            // Get the username and password from the textboxes
            string username = UserName_txt.Text;
            string password = Password_txt.Text;

            // Initialize the LoginController (you should have this class)
            LoginController loginController = new LoginController();

            // Authenticate the user
            FactoryIUser user = loginController.Login(username, password);

            if (user != null)
            {
                // Authentication successful, now you have the user instance with the associated role
                // Redirect to the appropriate user interface based on the role
                user.ShowUserInterface();
            }
            else
            {
                // Authentication failed, show an error message or take appropriate action
                MessageBox.Show("Authentication failed. Please check your credentials.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.ExecuteStrategy("sort");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.ExecuteStrategy("webjfveaj");
        }

        private void UserName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
