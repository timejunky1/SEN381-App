using PSS_ITWORKS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using PSS_ITWORKS.Presentation_Layer;

public class LoginController
{
    private DatabaseAPI api = new DatabaseAPI();
    private string connectionString = @"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True";
    UserInfo userInfo;


    public class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }

        public int ID { get; set; }

    }
    public void Connect()
    {
        api.SetConnection(connectionString);
    }

    public void HandleLoginButtonClick(string username, string password, LogIn loginForm, Label welcomeLabel)
    {

        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {

            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {

                Dashboard dashboard = new Dashboard(this, userInfo, loginForm);
                dashboard.Show();

                loginForm.Close();
            }
            else
            {
 
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        else
        {
 
            MessageBox.Show("Username and password are required.");
        }
    }

    public bool AuthenticateUser(string username, string password)
    {
        userInfo = api.GetUserInformation(username);
        MessageBox.Show(userInfo.Name);
        return api.AuthenticateUser(username, password);
    }
   

    public UserInfo GetUserInfo()
    {
        return userInfo;
    }

    public int getID(UserInfo)
    {
        return ID;
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


