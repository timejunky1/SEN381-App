// EntityJob.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityJob : IEntity
    {
        private int Job_ID;
        private int Technician_ID;
        private int Client_ID;
        private int Service_ID;
        private DateTime Time_Begin;
        private DateTime Time_End;
        private string Status;
        private int Call_ID;

        public void Get()
        {
            // Retrieve data for EntityJob from the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to fetch EntityJob data
                SqlCommand command = new SqlCommand("SELECT * FROM JobTable WHERE Job_ID = @Job_ID", connection);
                command.Parameters.AddWithValue("@Job_ID", Job_ID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Map retrieved data to class properties
                    Job_ID = (int)reader["Job_ID"];
                    Technician_ID = (int)reader["Technician_ID"];
                    Client_ID = (int)reader["Client_ID"];
                    Service_ID = (int)reader["Service_ID"];
                    Time_Begin = (DateTime)reader["Time_Begin"];
                    Time_End = (DateTime)reader["Time_End"];
                    Status = reader["Status"].ToString();
                    Call_ID = (int)reader["Call_ID"];
                }

                reader.Close();
            }
        }

        public void Set()
        {
            // Update or insert data for EntityJob into the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to update or insert data
                SqlCommand command = new SqlCommand("INSERT INTO JobTable (Job_ID, Technician_ID, Client_ID, Service_ID, Time_Begin, Time_End, Status, Call_ID) VALUES (@Job_ID, @Technician_ID, @Client_ID, @Service_ID, @Time_Begin, @Time_End, @Status, @Call_ID)", connection);
                command.Parameters.AddWithValue("@Job_ID", Job_ID);
                command.Parameters.AddWithValue("@Technician_ID", Technician_ID);
                command.Parameters.AddWithValue("@Client_ID", Client_ID);
                command.Parameters.AddWithValue("@Service_ID", Service_ID);
                command.Parameters.AddWithValue("@Time_Begin", Time_Begin);
                command.Parameters.AddWithValue("@Time_End", Time_End);
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@Call_ID", Call_ID);
                command.ExecuteNonQuery();
            }
        }
    }
}
