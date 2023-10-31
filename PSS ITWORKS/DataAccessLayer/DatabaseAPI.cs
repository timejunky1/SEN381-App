// DatabaseAPI.cs

using PSS_ITWORKS.LogicLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSS_ITWORKS
{
    internal class DatabaseAPI
    {
        SqlConnection conn;
        
        public void SetConnection(string connString)
        {
            conn = new SqlConnection(connString);
        }

        //LoginProcedures
        public bool AuthenticateUser(string username, string password)
        {
            bool res = false;
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("LogInProcedures.AuthenticateUser", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", HashPassword(password));

                    var result = new SqlParameter
                    {
                        ParameterName = "@result",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(result);

                    command.ExecuteNonQuery();

                    int authenticationResult = Convert.ToInt32(result.Value);

                    res = authenticationResult == 1;
                }
                conn.Close();
            }catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return res;
        }

        // this stored procedure has not been created yet
        public LoginController.UserInfo GetUserInformation(string username)
        {
            LoginController.UserInfo userInfo = null;
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("LoginProcedures.GetUserInformation", conn))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", username);

                    var nameParam = new SqlParameter
                    {
                        ParameterName = "@name",
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50,
                        Direction = ParameterDirection.Output
                    };

                    var surnameParam = new SqlParameter
                    {
                        ParameterName = "@surname",
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50,
                        Direction = ParameterDirection.Output
                    };

                    var roleParam = new SqlParameter
                    {
                        ParameterName = "@role",
                        SqlDbType = SqlDbType.VarChar,
                        Size = 30,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(nameParam);
                    command.Parameters.Add(surnameParam);
                    command.Parameters.Add(roleParam);

                    command.ExecuteNonQuery();

                    string name = nameParam.Value.ToString();
                    string surname = surnameParam.Value.ToString();
                    string role = roleParam.Value.ToString();

                    userInfo = new LoginController.UserInfo { Name = name, Surname = surname, Role = role };
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return userInfo;
        }

        public string GetUserRole(string username)
        {
            string role = "";
            try
            {

                using (conn)
                {
                    using (SqlCommand command = new SqlCommand("sp_GetUserRole", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", username);

                        var roleParam = new SqlParameter
                        {
                            ParameterName = "@Role",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 30,
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(roleParam);

                        command.ExecuteNonQuery();

                        role = roleParam.Value.ToString();

                    }
                }
            }
            catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return role;
        }

        public string FetchNameAndSurname(string username)
        {
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_FetchNameAndSurname", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", username);

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

                    command.ExecuteNonQuery();

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
            // string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            string hashedPassword = password;
            return hashedPassword;
        }


        //ContractManager-Working
        
    }

    
}