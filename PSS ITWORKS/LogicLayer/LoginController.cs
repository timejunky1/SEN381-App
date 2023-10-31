using PSS_ITWORKS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

public class LoginController
{
    private DatabaseAPI api = new DatabaseAPI();
    private string connectionString = @"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True";
    UserInfo userInfo;

    // Property to access the Name
    public class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        // Other properties if needed
    }
    public void Connect()
    {
        api.SetConnection(connectionString);
    }

    public void HandleLoginButtonClick(string username, string password, LogIn loginForm, Label welcomeLabel)
    {
        // Check if username and password are not empty
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
            // Authenticate the user using the LoginController
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // User is authenticated, you can proceed to fetch name and surname and role

                // Open the correct portal based on the user's role using a Factory
                FactoryAMainFactory factory = new FactoryUserFactory(this);
                FactoryIUser userPortal = factory.CreateUser(userInfo.Role);
                userPortal.ShowUserInterface(loginForm);

                // Display a welcome message
                welcomeLabel.Text = $"Welcome, {userInfo.Name} {userInfo.Surname}";

                // Close the login form (you can uncomment this line if needed)
                // loginForm.Close();
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

    public bool AuthenticateUser(string username, string password)
    {
        userInfo = api.GetUserInformation(username);
        MessageBox.Show(userInfo.Name);
        return api.AuthenticateUser(username, password);
    }
    //this stored procedure was not implemented yet

    public UserInfo GetUserInfo()
    {
        return userInfo;
    }

    public string GetUserRole(string username)
    {
        return api.GetUserRole(username);
    }

    public string FetchNameAndSurname(string username)
    {
        return api.FetchNameAndSurname(username);
    }



    private string HashPassword(string password)
    {
        // Implement password hashing logic here (e.g., SHA-256)
        // Return the hashed password
        // string salt = BCrypt.Net.BCrypt.GenerateSalt(12); // 12 is the work factor (adjust as needed)
        //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
        string hashedPassword = password;
        return hashedPassword;
    }

    public void SetPassword(string username, string password, string newPassword)
    {
        api.SetPassword(username, password, newPassword);
    }
}


