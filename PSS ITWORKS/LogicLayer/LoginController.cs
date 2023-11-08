using PSS_ITWORKS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using PSS_ITWORKS.Presentation_Layer;
using PSS_ITWORKS.ConstantData;

public class LoginController
{
    private DatabaseAPI api = new DatabaseAPI();
    private string connectionString = SystemData.GetConString();
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
                welcomeLabel.Text = "Invalid UserName or Password";
                welcomeLabel.Visible = true;
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

    public int getID(UserInfo userInfo)
    {
        int ID = userInfo.ID;
        return ID;
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
        api.ResetPassword(username, password, newPassword);
    }
}


