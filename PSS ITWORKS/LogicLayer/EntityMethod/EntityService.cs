// EntityService.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityService : IEntity
    {
        private int Service_ID;
        private string Title;
        private string Duration;
        private string Priority;
        private decimal Cost;

        public void Get()
        {
            // Retrieve data for EntityService from the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to fetch EntityService data
                SqlCommand command = new SqlCommand("SELECT * FROM Services WHERE Service_ID = @Service_ID", connection);
                command.Parameters.AddWithValue("@Service_ID", Service_ID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Map retrieved data to class properties
                    Service_ID = (int)reader["Service_ID"];
                    Title = reader["Title"].ToString();
                    Duration = reader["Duration"].ToString();
                    Priority = reader["Priority"].ToString();
                    Cost = (decimal)reader["Cost"];
                }

                reader.Close();
            }
        }

        public void Set()
        {
            // Update or insert data for EntityService into the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to update or insert data
                SqlCommand command = new SqlCommand("INSERT INTO Services (Service_ID, Title, Duration, Priority, Cost) VALUES (@Service_ID, @Title, @Duration, @Priority, @Cost)", connection);
                command.Parameters.AddWithValue("@Service_ID", Service_ID);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@Duration", Duration);
                command.Parameters.AddWithValue("@Priority", Priority);
                command.Parameters.AddWithValue("@Cost", Cost);
                command.ExecuteNonQuery();
            }
        }
    }
}
