using PSS_ITWORKS;
using System;
using System.Data;
using System.Data.SqlClient;

public class LoginController
{
    private string connectionString = @"Data Source=DESKTOP-TBBSO02\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True";

    public bool AuthenticateUser(string username, string password)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("sp_AuthenticateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Set the parameters for the stored procedure
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", HashPassword(password));

                // Output parameter to capture the result
                var result = new SqlParameter
                {
                    ParameterName = "@Result",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(result);

                // Execute the stored procedure
                command.ExecuteNonQuery();

                // Check the result to authenticate the user
                int authenticationResult = Convert.ToInt32(result.Value);

                return authenticationResult == 1;
            }
        }
    }

    public string GetUserRole(string username)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("sp_GetUserRole", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Set the parameters for the stored procedure
                command.Parameters.AddWithValue("@Username", username);

                // Output parameter to capture the user's role
                var roleParam = new SqlParameter
                {
                    ParameterName = "@Role",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 30,
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(roleParam);

                // Execute the stored procedure
                command.ExecuteNonQuery();

                // Retrieve the role from the output parameter
                string role = roleParam.Value.ToString();

                return role;
            }
        }
    }

    public string FetchNameAndSurname(string username)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("sp_FetchNameAndSurname", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Set the parameters for the stored procedure
                command.Parameters.AddWithValue("@Username", username);

                // Output parameters to capture the name and surname
                var nameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Direction = ParameterDirection.Output
                };

                var surnameParam = new SqlParameter
                {
                    ParameterName = "@Surname",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(nameParam);
                command.Parameters.Add(surnameParam);

                // Execute the stored procedure
                command.ExecuteNonQuery();

                // Retrieve the name and surname from the output parameters
                string name = nameParam.Value.ToString();
                string surname = surnameParam.Value.ToString();

                return $"{name} {surname}";
            }
        }
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
