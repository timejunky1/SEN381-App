// DatabaseAPI.cs

using PSS_ITWORKS.LogicLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

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

        public void CreateContract(EntityContract contract)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.CreateContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SLA", contract.GetSLA());
                cmd.Parameters.AddWithValue("@duration", contract.GetDuration());
                cmd.Parameters.AddWithValue("@priority", contract.GetPriority());
                cmd.Parameters.AddWithValue("@cost", contract.GetCost());
                cmd.Parameters.AddWithValue("@availability", contract.GetAvailability());
                cmd.ExecuteNonQuery();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            conn.Close();
        }
        public void UpdateContract(EntityContract contract)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.UpdateContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@contractId", contract.GetId());
                cmd.Parameters.AddWithValue("@SLA", contract.GetSLA());
                cmd.Parameters.AddWithValue("@duration", contract.GetDuration());
                cmd.Parameters.AddWithValue("@priority", contract.GetPriority());
                cmd.Parameters.AddWithValue("@cost", contract.GetCost());
                cmd.Parameters.AddWithValue("@availability", contract.GetAvailability());
                cmd.ExecuteNonQuery();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            conn.Close();
        }

        public async BindingSource GetContractStats(int contractId, int period)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.GetContractStats", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@period", period);
                cmd.Parameters.AddWithValue("@contractid", contractId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }
        public void DeleteContract(int contractId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.DeleteContract", conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@contractId", contractId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void AddContractRef(int contractId, int serviceId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.AddContractRef", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@contractId", contractId);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void AddContractRef(int serviceId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.AddContractRef", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void DeleteContractRef(int contractId, int serviceId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.DeleteContractRef", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@contractId", contractId);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        //Servicemanagement--working
        public BindingSource GetServices()
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.GetServices", conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }
        public void DeleteService(int serviceId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.DeleteService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void UpdateService(EntityService service)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.UpdateService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serviceId", service.GetId());
                cmd.Parameters.AddWithValue("@title", service.GetTitle());
                cmd.Parameters.AddWithValue("@duration", service.GetDuration());
                cmd.Parameters.AddWithValue("@priority", service.GetPriority());
                cmd.Parameters.AddWithValue("@cost", service.GetCost());
                cmd.Parameters.AddWithValue("@availability", service.GetAvailability());
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void CreateService(EntityService service)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ContractPortalProcedures.CreateService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", service.GetTitle());
                cmd.Parameters.AddWithValue("@duration", service.GetDuration());
                cmd.Parameters.AddWithValue("@priority", service.GetPriority());
                cmd.Parameters.AddWithValue("@cost", service.GetCost());
                cmd.Parameters.AddWithValue("@availability", service.GetAvailability());
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        //Client--Working

        public BindingSource GetClientWithDetails(int clientId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientPortalProcedures.GetClientsWithDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientId", clientId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                ErrorHandler.DisplayError("Quary Successfully executed");
            }
            catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            conn.Close();
            MessageBox.Show("GetClientDetails");
            return bs;
        }

        //UserManagement--Working
        public void InsertUser(EntityUser user)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.InsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@companyName", user.GetCompanyName());
                cmd.Parameters.AddWithValue("@name", user.GetName());
                cmd.Parameters.AddWithValue("@surname", user.GetSurname());
                cmd.Parameters.AddWithValue("@email", user.GetEmail());
                cmd.Parameters.AddWithValue("@phone", user.GetPhone());
                cmd.Parameters.AddWithValue("@streetNumber", user.GetStreetNumber());
                cmd.Parameters.AddWithValue("@street", user.GetStreetName());
                cmd.Parameters.AddWithValue("@city", user.GetCity());
                cmd.Parameters.AddWithValue("@province", user.GetProvince());
                cmd.Parameters.AddWithValue("@zipcode", user.GetZipCode());
                cmd.Parameters.AddWithValue("@role", user.GetRole());
                cmd.Parameters.AddWithValue("@contractId", user.GetContractId());
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("query successful");
            }catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

        }

        public void SetPassword(string username, string password, string newPassword)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.SetPassword", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("query successful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void UpdateUser(EntityUser user)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.UpdateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", user.GetID());
                cmd.Parameters.AddWithValue("@companyName", user.GetCompanyName());
                cmd.Parameters.AddWithValue("@name", user.GetName());
                cmd.Parameters.AddWithValue("@surname", user.GetSurname());
                cmd.Parameters.AddWithValue("@email", user.GetEmail());
                cmd.Parameters.AddWithValue("@phone", user.GetPhone());
                cmd.Parameters.AddWithValue("@streetNumber", user.GetStreetNumber());
                cmd.Parameters.AddWithValue("@street", user.GetStreetName());
                cmd.Parameters.AddWithValue("@city", user.GetCity());
                cmd.Parameters.AddWithValue("@province", user.GetProvince());
                cmd.Parameters.AddWithValue("@zipcode", user.GetZipCode());
                cmd.Parameters.AddWithValue("@role", user.GetRole());
                cmd.Parameters.AddWithValue("@contractId", user.GetContractId());
                cmd.ExecuteNonQuery();
                ErrorHandler.DisplayError("query successful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public BindingSource ViewAllUsers()
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.ViewAllUsers", conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("ViewUsers");
            return bs;
        }

        public BindingSource FilterUsers(string username)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.FilterUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@username", username);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetServices");
            return bs;
        }

        public void DeleteUser(int id, string role)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.DeleteUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("role", role);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfull");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        //ClientManagement--Working

        public BindingSource GetClientAndContractInfo(int clientId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientManagementProcedures.GetClientAndContractInfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientID", clientId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("query succesful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }

        public BindingSource GetClientInfo(int clientId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientManagementProcedures.GetClientInfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientId", clientId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("query succesful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetClientInfo");
            return bs;
        }//Also Used At CallManagement

        public BindingSource GetClientJobs(int clientId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientManagementProcedures.GetClientJobs", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientID", clientId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("quary successful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }

        //CallManagement--Working
        public void CreateServiceRequest(EntityJob job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientPortalProcedures.CreateServiceRequest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientId", job.GetClientId());
                cmd.Parameters.AddWithValue("@serviceId", job.GetServiceId());
                cmd.Parameters.AddWithValue("@notes", job.GetNotes());
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError($"query successful");
            }
            catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }
        public BindingSource GetClientOverview(string clientName)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CallsPortalProcedures.GetClientOverview", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", clientName);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("query successful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            return bs;
        }
        public BindingSource GetEmployeeOverview(int employeeId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CallsPortalProcedures.GetEmployeeOverview", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("query successful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }

        //JobManagement--Working
        public BindingSource GetTechnician(int id)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.GetTechnician", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("Query Successfull");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }

        public BindingSource GetJobSchedule()
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.GetJobSchedule", conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("Query Successfull");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }

        public void AssignJob(int employeeId, int jobId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.AssignJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@jobId", jobId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Query Successfull");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void UpdateAssignedJob(EntityJob job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.UpdateAssignedJob", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void DeleteEmployeeJobRef(int jobId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.DeleteEmployeeJobRef", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@jobId", jobId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfull");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public void AddEmployeeJobRef(int jobId, int employeeId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.AddEmployeeJobRef", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@jobId", jobId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ErrorHandler.DisplayError("Quary Successfull");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public BindingSource GetJobsOnDate(DateTime date)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.GetJobsOnDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@specificDate", date);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("UnassignedJobsOnDate");
            return bs;
        }

        public BindingSource GetJobsAssignedToEmployeeName(string employeeName)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.GetJobsAssignedToEmployeeByName", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeName", employeeName);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("Query Successful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }

        public BindingSource GetUnasignedJobs()
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.GetUnassignedJobs", conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetUnassignedJobs");
            return bs;
        }

        //TechnicalPortalProcedures--Working

        public BindingSource GetTechnicianTaskList(int employeeId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicalPortalProcedures.GetTechnicianTaskList", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("Query Successfull");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            return bs;
        }

        public void UpdateJobNotesAndStatus(EntityJob job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicalPortalProcedures.GetTechnicianTaskList", conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientId", job.GetId());
                cmd.Parameters.AddWithValue("@jobNotes", job.GetNotes());
                cmd.Parameters.AddWithValue("@jobStartus", job.GetStatus());
                conn.Close();
                ErrorHandler.DisplayError($"{job.GetNotes()}, {job.GetStatus()}");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
        }

        public BindingSource GetClientDetails(int clientId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicalPortalProcedures.GetClientDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientId", clientId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
                ErrorHandler.DisplayError("quary successful");
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            return bs;
        }

        public BindingSource GetServiceOverview(int serviceId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicalPortalProcedures.GetServiceOverview", conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetServiceOverview");
            return bs;
        }

        public BindingSource GetTechnicianSchedule(int employeeId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicianPortalProcedures.GetTechnicianSchedule", conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetTechnicianSchedule");
            return bs;
        }
    }

    
}