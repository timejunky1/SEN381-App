using PSS_ITWORKS;
using System;
using System.Data;
using System.Data.SqlClient;

public class LoginController
{
    private DatabaseAPI databaseAPI;

    public LoginController(DatabaseAPI databaseAPI)
    {
        this.databaseAPI = databaseAPI;
    }

    private string connectionString = @"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True";

    public bool AuthenticateUser(string username, string password)
    {
        return databaseAPI.AuthenticateUser(username, password);
    }

    public string GetUserRole(string username)
    {
        return databaseAPI.GetUserRole(username);
    }

    public string FetchNameAndSurname(string username)
    {
        return databaseAPI.FetchNameAndSurname(username);
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
}
