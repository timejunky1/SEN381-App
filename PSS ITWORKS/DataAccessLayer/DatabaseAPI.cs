// DatabaseAPI.cs

using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
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
                    var idperam = new SqlParameter
                    {
                        ParameterName = "@userId",
                        SqlDbType = SqlDbType.VarChar,
                        Size = 30,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(nameParam);
                    command.Parameters.Add(surnameParam);
                    command.Parameters.Add(roleParam);
                    command.Parameters.Add(idperam);

                    command.ExecuteNonQuery();

                    string name = nameParam.Value.ToString();
                    string surname = surnameParam.Value.ToString();
                    string role = roleParam.Value.ToString();
                    int userId = int.Parse(idperam.Value.ToString());

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

        private string HashPassword(string password)
        {
            // Implement password hashing logic here (e.g., SHA-256)
            // Return the hashed password
            // string salt = BCrypt.Net.BCrypt.GenerateSalt(12); // 12 is the work factor (adjust as needed)
            // string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            string hashedPassword = password;
            return hashedPassword;
        }


        //Employee
        public void InsertEmployee(EntityEmployee employee)
        {
            using (conn)
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.CommandType= CommandType.StoredProcedure;
                    command.ExecuteNonQuery ();
                }
            }
        }

        public void UpdateEmployee(EntityEmployee employee)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(int employeeid)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public EntityEmployee GetEmployee(int employeeId)
        {
            EntityEmployee employee = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return employee;
        }

        public List<EntityEmployee> GetEmployees()
        {
            List<EntityEmployee> employees = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return employees;
        }

        //Call
        public void InsertCall(EntityCall call)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCall(EntityCall call)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCall(int callId)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public EntityCall GetCall(int callId)
        {
            EntityCall call = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return call;
        }

        public List<EntityCall> GetCalls()
        {
            List<EntityCall> calls = new List<EntityCall>();
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return calls;
        }

        //Client

        public void InsertClient(EntityClient client)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateClient(EntityClient client)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteClient(int clientId)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public EntityClient GetClient (int clientId)
        {
            EntityClient client = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.AddWithValue("@clientid", clientId);

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
                    var idperam = new SqlParameter
                    {
                        ParameterName = "@userId",
                        SqlDbType = SqlDbType.VarChar,
                        Size = 30,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(nameParam);
                    command.Parameters.Add(surnameParam);
                    command.Parameters.Add(roleParam);
                    command.Parameters.Add(idperam);

                    client = new EntityClient()
                }
            }
            return client;
        }

        public List<EntityClient> GetClients()
        {
            List<EntityClient> clients = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return clients;
        }

        //Contract

        public void InsertContract(EntityContract contract)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateContract(EntityContract contract)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteContract(int contractId)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public EntityContract GetContract(int contractid)
        {
            EntityContract contract = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return contract;
        }

        public List<EntityContract> GetContracts()
        {
            List<EntityContract> contracts = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return contracts;
        }

        //Job

        public void InsertJob(EntityJob job)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateJob(EntityJob job)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteJob(int jobId)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public EntityJob GetJob(int jobId)
        {
            EntityJob job = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return job;
        }

        public List<EntityJob> GetJobs()
        {
            List<EntityJob> jobs = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return jobs;
        }

        //Service

        public void InsertService(EntityService service)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateService(EntityService service)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteService(EntityService service)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public EntityService GetService(int serviceid)
        {
            EntityService service = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return service;
        }

        public List<EntityService> GetServices()
        {
            List<EntityService> services = null;
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            return services;
        }

        //References

        public List<int> GetJobEmployeeref()
        {
            return new List<int>();
        }
    }
}