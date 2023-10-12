using System;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = UserName_txt.Text;
            string password = Password_txt.Text;

            // Check if username and password are not empty
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Authenticate the user using the LoginController
                bool isAuthenticated = loginController.AuthenticateUser(username, password);

                if (isAuthenticated)
                {
                    // User is authenticated, you can proceed to fetch name and surname and role
                    string name = loginController.FetchNameAndSurname(username);
                    string role = loginController.GetUserRole(username);


                    // Open the correct portal based on the user's role using a Factory
                    FactoryAMainFactory factory = new FactoryUserFactory();
                    FactoryIUser userPortal = factory.CreateUser(role);
                    userPortal.ShowUserInterface(this);

                    // Display a welcome message
                    WelcomeLabel_txt.Text = $"Welcome, {name}";

                    

                    // Close the login form
                    //this.Close();
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            else
            {
                // Username or password is empty
                MessageBox.Show("Username and password are required.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void UserName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_txt_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
