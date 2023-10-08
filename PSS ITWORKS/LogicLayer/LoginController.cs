using System;
using System.Data.SqlClient;
using PSS_ITWORKS.LogicLayer;

namespace PSS_ITWORKS
{
    class LoginController
    {
        private readonly string connectionString = "your_connection_string_here";

        public FactoryIUser Login(string Username, string Password)
        {
            // Initialize a user instance (FactoryIUser) to return
            FactoryIUser user = null;

            // Hash the provided password for security (You should use a proper password hashing library)
            string hashedPassword = HashPassword(Password);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query the database to check the credentials and retrieve the user's role
                SqlCommand command = new SqlCommand("SELECT Role FROM EmployeeTable WHERE username = @Username AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Authentication successful, retrieve the user's role
                    string role = reader["Role"].ToString();
                    user = CreateUserBasedOnRole(role);
                }

                reader.Close();
            }

            return user;
        }

        private string HashPassword(string password)
        {
            // Generate a salt and hash the password with BCrypt
            string salt = BCrypt.Net.BCrypt.GenerateSalt(12); // 12 is the work factor (adjust as needed)
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashedPassword;
        }

        private FactoryIUser CreateUserBasedOnRole(string role)
        {
            // Create a user instance (FactoryIUser) based on the role
            FactoryIUser user = null;

            switch (role.ToLower())
            {
                case "admin":
                    user = new FactoryCAdminDetails();
                    break;
                case "callmanager":
                    user = new FactoryCCallEmployeeDetails();
                    break;
                case "manager":
                    user = new FactoryCManagerDetails();
                    break;
                case "technician":
                    user = new FactoryCTechnicianDetails();
                    break;
                default:
                    // Handle unknown or invalid roles
                    break;
            }

            return user;
        }
    }
}
