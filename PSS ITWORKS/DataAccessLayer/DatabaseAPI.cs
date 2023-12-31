﻿// DatabaseAPI.cs

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
        string connString = "";
        
        public void SetConnection(string connString)
        {
            this.connString = connString;
        }

        //LoginProcedures
        public bool AuthenticateUser(string username, string password)
        {
            bool res = false;
            try
            {
                using(SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("logInProcedures.AuthenticateUser", conn))
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
                }
                ErrorHandler.DisplayError(res.ToString());
            }catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return res;
        }

        // this stored procedure has not been created yet
        public LoginController.UserInfo GetUserInformation(string username)
        {
            LoginController.UserInfo userInfo = null;
            try
            {
                using(SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("loginProcedures.GetUserInformation", conn))
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
                        var idPeram = new SqlParameter
                        {
                            ParameterName = "@userId",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 30,
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(nameParam);
                        command.Parameters.Add(surnameParam);
                        command.Parameters.Add(roleParam);
                        command.Parameters.Add(idPeram);

                        command.ExecuteNonQuery();

                        string name = nameParam.Value.ToString();
                        string surname = surnameParam.Value.ToString();
                        string role = roleParam.Value.ToString();
                        int userId = int.Parse(idPeram.Value.ToString());

                        userInfo = new LoginController.UserInfo { Name = name, Surname = surname, Role = role, ID = userId};
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return userInfo;
        }

        public void LogOut(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("loginProcedures.Logout"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@email", username);
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Loged Out");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void ResetPassword(string username, string oldPassword, string newPassword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("loginProcedures.ResetPassword"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@email", username);
                        command.Parameters.AddWithValue("@oldPassword", username);
                        command.Parameters.AddWithValue("@newPassword", username);
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Reset Password");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
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


        //Employee
        public void InsertEmployee(EntityEmployee employee)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("employeeProcedures.InsertEmployee", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@name", employee.GetName());//VARCHAR(15)
                        command.Parameters.AddWithValue("@surname", employee.GetSurname());//VARCHAR(15)
                        command.Parameters.AddWithValue("@role", employee.GetRole());//VARCHAR(30)
                        command.Parameters.AddWithValue("@phone", employee.GetPhone());//VARCHAR(10)
                        command.Parameters.AddWithValue("@email", employee.GetEmail());//VARCHAR(30)
                        command.Parameters.AddWithValue("@streetNo", employee.GetStreetNumber());//INT
                        command.Parameters.AddWithValue("@street", employee.GetStreetName());//VARCHAR(50)
                        command.Parameters.AddWithValue("@City", employee.GetCity());//VARCHAR(30)
                        command.Parameters.AddWithValue("@Province", employee.GetProvince());//VARCHAR(15)
                        command.Parameters.AddWithValue("@Zipcode", employee.GetZipCode());//VARCHAR(5)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted Employee");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void UpdateEmployee(EntityEmployee employee)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("employeeProcedures.UpdateEmployee", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@employeeId", employee.GetID());//INT
                        command.Parameters.AddWithValue("@name", employee.GetName());//VARCHAR(15)
                        command.Parameters.AddWithValue("@surname", employee.GetSurname());//VARCHAR(15)
                        command.Parameters.AddWithValue("@role", employee.GetRole());//VARCHAR(30)
                        command.Parameters.AddWithValue("@phone", employee.GetPhone());//VARCHAR(10)
                        command.Parameters.AddWithValue("@email", employee.GetEmail());//VARCHAR(30)
                        command.Parameters.AddWithValue("@streetNo", employee.GetStreetNumber());//INT
                        command.Parameters.AddWithValue("@street", employee.GetStreetName());//VARCHAR(50)
                        command.Parameters.AddWithValue("@City", employee.GetCity());//VARCHAR(30)
                        command.Parameters.AddWithValue("@Province", employee.GetProvince());//VARCHAR(15)
                        command.Parameters.AddWithValue("@Zipcode", employee.GetZipCode());//VARCHAR(5)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Updated Employee");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void DeleteEmployee(int employeeid)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("employeeProcedures.DeleteEmployee", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@employeeId", employeeid);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted Employee");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public EntityEmployee GetEmployee(int employeeId)
        {
            EntityEmployee employee = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("employeeProcedures.GetEmployee",conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@employeeId", employeeId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employee = new EntityEmployee(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetInt32(6),
                                    reader.GetString(7),
                                    reader.GetString(8),
                                    reader.GetString(8),
                                    reader.GetString(9)
                                    );
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            reader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return employee;
        }

        public List<EntityEmployee> GetEmployees()
        {
            List<EntityEmployee> employees = new List<EntityEmployee>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand("employeeProcedures.GetEmployees",conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EntityEmployee employee = new EntityEmployee(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetInt32(6),
                                reader.GetString(7),
                                reader.GetString(8),
                                reader.GetString(8),
                                reader.GetString(9)
                                );

                            employees.Add(employee);
                        }
                        if (!reader.HasRows)
                        {
                            ErrorHandler.DisplayError("No Data");
                        }
                        else
                        {
                            ErrorHandler.DisplayError($"{employees.Count} employees found");
                        }
                        reader.Close();
                    }
                }
            }
            return employees;
        }

        //Call
        public void InsertCall(EntityCall call)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("callProcedures.InsertCallLog", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@employeeId", call.GetEmployeeId());//INT
                        command.Parameters.AddWithValue("@clientId", call.GetClientId());//INT
                        command.Parameters.AddWithValue("@callTime", call.GetCallTime());//DATETIME
                        command.Parameters.AddWithValue("@description", call.GetDescription());//VARCHAR(255)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted Call");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public EntityCall GetCall(int callId)
        {
            EntityCall call = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("callProcedures.GetCall", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", callId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                call = new EntityCall(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetDateTime(3),
                                    reader.GetString(4)
                                    );
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return call;
        }

        public List<EntityCall> GetCalls()
        {
            List<EntityCall> calls = new List<EntityCall>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("callProcedures.GetCalls", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EntityCall call = new EntityCall(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetDateTime(3),
                                    reader.GetString(4)
                                    );

                                calls.Add(call);    
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{calls.Count} calls found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return calls;
        }

        //Client

        public void InsertClient(EntityClient client)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("clientProcedures.InsertClient", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@companyName", client.GetCompanyName());//VARCHAR(50)
                        command.Parameters.AddWithValue("@name", client.GetName());//VARCHAR(15)
                        command.Parameters.AddWithValue("@surname", client.GetSurname());//VARCHAR(15)
                        command.Parameters.AddWithValue("@role", client.GetRole());//VARCHAR(30)
                        command.Parameters.AddWithValue("@contractId", client.GetContractId());//INT
                        command.Parameters.AddWithValue("@phone", client.GetPhone());//VARCHAR(10)
                        command.Parameters.AddWithValue("@email", client.GetEmail());//VARCHAR(30)
                        command.Parameters.AddWithValue("@contractinitiationDate", client.GetContractInitiationDate());//DATETIME
                        command.Parameters.AddWithValue("@streetNo", client.GetStreetNumber());//INT
                        command.Parameters.AddWithValue("@street", client.GetStreetName());//VARCHAR(50)
                        command.Parameters.AddWithValue("@City", client.GetCity());//VARCHAR(30)
                        command.Parameters.AddWithValue("@Province", client.GetProvince());//VARCHAR(15)
                        command.Parameters.AddWithValue("@Zipcode", client.GetZipCode());//VARCHAR(5)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted Client");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void UpdateClient(EntityClient client)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("clientProcedures.UpdateClient", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@clientId", client.GetID());//VARCHAR(50)
                        command.Parameters.AddWithValue("@companyName", client.GetCompanyName());//VARCHAR(50)
                        command.Parameters.AddWithValue("@name", client.GetName());//VARCHAR(15)
                        command.Parameters.AddWithValue("@surname", client.GetSurname());//VARCHAR(15)
                        command.Parameters.AddWithValue("@role", client.GetRole());//VARCHAR(30)
                        command.Parameters.AddWithValue("@contractId", client.GetContractId());//INT
                        command.Parameters.AddWithValue("@phone", client.GetPhone());//VARCHAR(10)
                        command.Parameters.AddWithValue("@email", client.GetEmail());//VARCHAR(30)
                        command.Parameters.AddWithValue("@contractinitiationDate", client.GetContractInitiationDate());//DATETIME
                        command.Parameters.AddWithValue("@streetNo", client.GetStreetNumber());//INT
                        command.Parameters.AddWithValue("@street", client.GetStreetName());//VARCHAR(50)
                        command.Parameters.AddWithValue("@City", client.GetCity());//VARCHAR(30)
                        command.Parameters.AddWithValue("@Province", client.GetProvince());//VARCHAR(15)
                        command.Parameters.AddWithValue("@Zipcode", client.GetZipCode());//VARCHAR(5)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Updated Client");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void DeleteClient(int clientId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("clientProcedures.DeleteClient", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@clientId", clientId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted Client");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public EntityClient GetClient (int clientId)
        {
            EntityClient client = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("clientProcedures.GetClient", conn))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@clientId", clientId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                client = new EntityClient(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetInt32(5),
                                    reader.GetString(6),
                                    reader.GetString(7),
                                    reader.GetDateTime(8),
                                    reader.GetInt32(9),
                                    reader.GetString(10),
                                    reader.GetString(11),
                                    reader.GetString(12),
                                    reader.GetString(13)
                                    );
                            }
                            if(!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return client;
        }

        public List<EntityClient> GetClients()
        {
            List<EntityClient> clients = new List<EntityClient>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("clientProcedures.GetClients", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EntityClient client = new EntityClient(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetInt32(5),
                                    reader.GetString(6),
                                    reader.GetString(7),
                                    reader.GetDateTime(8),
                                    reader.GetInt32(9),
                                    reader.GetString(10),
                                    reader.GetString(11),
                                    reader.GetString(12),
                                    reader.GetString(13)
                                    );
                                clients.Add(client);
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{clients.Count} clients found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return clients;
        }

        //Contract

        public void InsertContract(EntityContract contract)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("contractProcedures.InsertContract", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@title", contract.GetTitle());//VARCHAR(30)
                        command.Parameters.AddWithValue("@SLA", contract.GetSLA());//VARCHAR(255)
                        command.Parameters.AddWithValue("@duration", contract.GetDuration());//INT
                        command.Parameters.AddWithValue("@cost", contract.GetCost());//DECIMAL(10,2)
                        command.Parameters.AddWithValue("@priority", contract.GetPriority());//INT 0 - 5
                        command.Parameters.AddWithValue("@availability", contract.GetAvailability());//VARCHAR(30)

                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted Contract");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void UpdateContract(EntityContract contract)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("contractProcedures.UpdateContract", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@contractId", contract.GetId());//VARCHAR(30)
                        command.Parameters.AddWithValue("@title", contract.GetTitle());//VARCHAR(30)
                        command.Parameters.AddWithValue("@SLA", contract.GetSLA());//VARCHAR(255)
                        command.Parameters.AddWithValue("@duration", contract.GetDuration());//INT
                        command.Parameters.AddWithValue("@cost", contract.GetCost());//DECIMAL(10,2)
                        command.Parameters.AddWithValue("@priority", contract.GetPriority());//INT 0 - 5
                        command.Parameters.AddWithValue("@availability", contract.GetAvailability());//VARCHAR(30)

                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Updated Contract");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void DeleteContract(int contractId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("contractProcedure.DeleteContract", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@contractId", contractId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted Contract");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public EntityContract GetContract(int contractid)
        {
            EntityContract contract = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("contractProcedures.GetContract", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@contractId", contractid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                contract = new EntityContract(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetInt32(3),
                                    reader.GetDecimal(4),
                                    reader.GetInt32(5),
                                    reader.GetString(6)
                                    );
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return contract;
        }

        public List<EntityContract> GetContracts()
        {
            List<EntityContract> contracts = new List<EntityContract>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("contractProcedures.GetContracts", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EntityContract contract = new EntityContract(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetInt32(3),
                                    reader.GetDecimal(4),
                                    reader.GetInt32(5),
                                    reader.GetString(6)
                                    );
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{contracts.Count} contracts found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return contracts;
        }

        //Job

        public void InsertJob(EntityJob job)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("jobProcedures.InsertJob", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@clientId", job.GetClientId());//INT
                        command.Parameters.AddWithValue("@serviceId", job.GetServiceId());//INT
                        command.Parameters.AddWithValue("@status", job.GetStatus());//VARCHAR(15)
                        command.Parameters.AddWithValue("@notes", job.GetNotes());//VARCHAR(255)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted Job");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void UpdateJob(EntityJob job)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("jobProcedures.UpdateJob", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", job.GetId());//INT
                        command.Parameters.AddWithValue("@clientId", job.GetClientId());//INT
                        command.Parameters.AddWithValue("@serviceId", job.GetServiceId());//INT
                        command.Parameters.AddWithValue("@status", job.GetStatus());//VARCHAR(15)
                        command.Parameters.AddWithValue("@notes", job.GetNotes());//VARCHAR(255)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Updated Job");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void DeleteJob(int jobId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("jobProcedures.UpdateJob", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted Job");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public EntityJob GetJob(int jobId)
        {
            EntityJob job = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("jobProcedures.GetJob", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                job = new EntityJob(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetDateTime(3),
                                    reader.GetDateTime(4),
                                    reader.GetString(5),
                                    reader.GetString(6)
                                    );
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return job;
        }

        public List<EntityJob> GetJobs()
        {
            List<EntityJob> jobs = new List<EntityJob>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("jobProcedures.GetJobs", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EntityJob job = new EntityJob(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetDateTime(3),
                                    reader.GetDateTime(4),
                                    reader.GetString(5),
                                    reader.GetString(6)
                                    );
                                jobs.Add(job);
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{jobs.Count} jobs found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return jobs;
        }

        //Service

        public void InsertService(EntityService service)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("serviceProcedures.InsertService", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@title", service.GetTitle());//VARCHAR(30)
                        command.Parameters.AddWithValue("@duration", service.GetDuration());//INT
                        command.Parameters.AddWithValue("@priority", service.GetTitle());//INT 0 - 5
                        command.Parameters.AddWithValue("@cost", service.GetCost());//DECIMAL(10,2)
                        command.Parameters.AddWithValue("availability", service.GetAvailability());//VARCHAR(20)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted Service");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void UpdateService(EntityService service)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("serviceProcedures.UpdateService", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@serviceId", service.GetId());//INT
                        command.Parameters.AddWithValue("@title", service.GetTitle());//VARCHAR(30)
                        command.Parameters.AddWithValue("@duration", service.GetDuration());//INT
                        command.Parameters.AddWithValue("@priority", service.GetTitle());//INT 0 - 5
                        command.Parameters.AddWithValue("@cost", service.GetCost());//DECIMAL(10,2)
                        command.Parameters.AddWithValue("availability", service.GetAvailability());//VARCHAR(20)
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Updated Service");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void DeleteService(int serviceId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("serviceProcedures.DeleteCService", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@serviceId", serviceId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted Service");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public EntityService GetService(int serviceid)
        {
            EntityService service = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("serviceProcedures.GetService", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@serviceId", serviceid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                service = new EntityService(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    reader.GetInt32(3),
                                    reader.GetDecimal(4),
                                    reader.GetString(5)
                                    );
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return service;
        }

        public List<EntityService> GetServices()
        {
            List<EntityService> services = new List<EntityService>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("serviceProcedures.GetServices", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EntityService service = new EntityService(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    reader.GetInt32(3),
                                    reader.GetDecimal(4),
                                    reader.GetString(5)
                                    );
                                services.Add(service);
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{services.Count} services found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return services;
        }

        //References

        public List<int> GetJobEmployeeRef(int jobId = 0, int employeeId = 0)
        {
            List<int> ids = new List<int>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.GetJobEmployeeRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);//INT
                        command.Parameters.AddWithValue("@employeeId", employeeId);//INT
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                ids.Add(id);
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{ids.Count} references found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return ids;
        }

        public List<int> GetJobCallRef(int jobId = 0, int callId = 0)
        {
            List<int> ids = new List<int>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.GetJobCallRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);//INT
                        command.Parameters.AddWithValue("@callId", callId);//INT
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                ids.Add(id);
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{ids.Count} references found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return ids;
        }

        public List<int> GetContractRef(int contractId = 0, int serviceId = 0)
        {
            List<int> ids = new List<int>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.GetContractRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@contractId", contractId);//INT
                        command.Parameters.AddWithValue("@serviceId", serviceId);//INT
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                ids.Add(id);
                            }
                            if (!reader.HasRows)
                            {
                                ErrorHandler.DisplayError("No Data");
                            }
                            else
                            {
                                ErrorHandler.DisplayError($"{ids.Count} references found");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            return ids;
        }

        public void DeleteJobEmployeeRef(int jobId = 0, int employeeId = 0)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.DeleteJobEmployeeRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);//INT
                        command.Parameters.AddWithValue("@employeeId", employeeId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted References");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void DeleteJobCallRef(int jobId = 0, int callId = 0)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.DeleteJobEmployeeRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);//INT
                        command.Parameters.AddWithValue("@callId", callId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted References");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void DeleteContractRef(int contractId = 0, int serviceId = 0)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.DeleteJobEmployeeRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@contractId", contractId);//INT
                        command.Parameters.AddWithValue("@serviceId", serviceId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Deleted References");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void InsertJobEmployeeRef(int jobId, int employeeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.InsertJobEmployeeRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);//INT
                        command.Parameters.AddWithValue("@employeeId", employeeId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted References");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void InsertJobCallRef(int jobId, int callId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.InsertJobEmployeeRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@jobId", jobId);//INT
                        command.Parameters.AddWithValue("@callId", callId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted References");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void InsertContractRef(int contractId, int serviceId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("referenceProcedures.InsertJobEmployeeRef", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@contractId", contractId);//INT
                        command.Parameters.AddWithValue("@serviceId", serviceId);//INT
                        command.ExecuteNonQuery();
                    }
                }
                ErrorHandler.DisplayError("Successfully Inserted References");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }
    }
}