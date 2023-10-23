// DatabaseAPI.cs

using PSS_ITWORKS.LogicLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("LogInProcedures.AuthenticateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", HashPassword(password));
                    command.Parameters.AddWithValue("@UserRole", null);

                    var result = new SqlParameter
                    {
                        ParameterName = "@Result",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(result);

                    command.ExecuteNonQuery();

                    int authenticationResult = Convert.ToInt32(result.Value);

                    return authenticationResult == 1;
                }
            }
        }

        public string GetUserRole(string username)
        {
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GetUserRole", connection))
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

                    string role = roleParam.Value.ToString();

                    return role;
                }
            }
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


        //ContractManager

        public void CreateContract(EntityContract contract)
        {
            MessageBox.Show("Create Contract");
        }
        public void UpdateContract(EntityContract contract)
        {
            MessageBox.Show("UpdateContract");
        }

        public BindingSource GetContractStats(int contractId, int period)
        {
            MessageBox.Show("GetContract Stats");
            return null;
        }
        public void DeleteContract(int contractid)
        {
            MessageBox.Show("DeleteContract");
        }

        public void AddContractRef(int contractId, int serviceId)
        {
            MessageBox.Show("AddContractRef");
        }

        //Servicemanagement
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
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetServices");
            return bs;
        }
        public void DeleteService(int Id)
        {

        }

        public void UpdateService(EntityService service)
        {

        }

        public void CreateService(EntityService service)
        {

        }

        //Client
        public void CreateServiceRequest(EntityJob job)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientPortalProcedures.CreateServiceRequest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientId", job.GetClientId());
                cmd.Parameters.AddWithValue("@serviceId", job.GetServiceId());
                cmd.Parameters.AddWithValue("@notes", job.GetNotes());
                reader = cmd.ExecuteReader();
                reader.Close();
            }catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            conn.Close();
        }//Also Used By Call Management

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
            }
            catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            conn.Close();
            MessageBox.Show("GetClientDetails");
            return bs;
        }

        //UserManagement
        public void InsertUser(EntityUser user)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.InsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }

        }

        public void UpdateUser(EntityUser user)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.UpdateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
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

        //ClientManagement

        public BindingSource GetClientAndContractInfo(int Id)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientManagementProcedures.GetClientAndContractInfo", conn);
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

            MessageBox.Show("GetClientAndContractInfo");
            return bs;
        }

        public BindingSource GetClientInfo(int Id)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientManagementProcedures.GetClientInfo", conn);
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

            MessageBox.Show("GetClientInfo");
            return bs;
        }//Also Used At CallManagement

        public BindingSource GetClientJobs(int Id)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ClientManagementProcedures.GetClientJobs", conn);
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

            MessageBox.Show("GetClientJobs");
            return bs;
        }

        //CallManagement

        public BindingSource GetClientOverview(int Id)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CallsPortalProcedures.GetClientOverview", conn);
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

            MessageBox.Show("GetClientOverview");
            return bs;
        }
        public BindingSource GetEmployeeOverview(int Id)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CallsPortalProcedures.GetEmployeeOverview", conn);
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

            MessageBox.Show("GetEmployeeOverview");
            return bs;
        }

        //JobManagement
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
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetJobSchedule");
            return bs;
        }

        public void AssignJob(EntityJob job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.AssignJob", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("AssignJob");
        }

        public void UpdateAssignedJob(EntityJob job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.UpdateAssignedJob", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }
            MessageBox.Show("UpdateAssignedJob");
        }

        public BindingSource UnassignedJobsOnDate(DateTime date)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.UnassignedJobsOnDate", conn);
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
                SqlCommand cmd = new SqlCommand("ServicePortalProcedures.GetJobsAssignedToEmployeeName", conn);
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

            MessageBox.Show("GetJobsAssignedToEmployeeName");
            return bs;
        }

        //TechnicalPortalProcedures

        public BindingSource GetTechnicianTaskList(int employeeId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicianPortalProcedures.GetTechnicianTaskList", conn);
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

            MessageBox.Show("GetTechnicianTaskList");
            return bs;
        }

        public void UpdateJobNotesAndStatus(EntityJob job)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicianPortalProcedures.GetTechnicianTaskList", conn);
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
                conn.Close();
            }

            MessageBox.Show("GetTechnicianTaskList");
        }

        public BindingSource GetClientDetails()
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicianPortalProcedures.GetClientDetails", conn);
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

            MessageBox.Show("GetClientDetails");
            return bs;
        }

        public BindingSource GetServiceOverview(int clientId)
        {
            SqlDataReader reader;
            BindingSource bs = new BindingSource();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TechnicianPortalProcedures.GetServiceOverview", conn);
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