// EntityContract.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityContract : IEntity
    {
        private int Contract_ID;
        private int Ref_ID;
        private string SLA;
        private int Duration;
        private string Priority;

        public void Get()
        {
            // Retrieve data for EntityContract from the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to fetch EntityContract data
                SqlCommand command = new SqlCommand("SELECT * FROM Contract WHERE Contract_ID = @Contract_ID", connection);
                command.Parameters.AddWithValue("@Contract_ID", Contract_ID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Map retrieved data to class properties
                    Contract_ID = (int)reader["Contract_ID"];
                    Ref_ID = (int)reader["Ref_ID"];
                    SLA = reader["SLA"].ToString();
                    Duration = (int)reader["Duration"];
                    Priority = reader["Priority"].ToString();
                }

                reader.Close();
            }
        }

        public void Set()
        {
            // Update or insert data for EntityContract into the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to update or insert data
                SqlCommand command = new SqlCommand("INSERT INTO Contract (Contract_ID, Ref_ID, SLA, Duration, Priority) VALUES (@Contract_ID, @Ref_ID, @SLA, @Duration, @Priority)", connection);
                command.Parameters.AddWithValue("@Contract_ID", Contract_ID);
                command.Parameters.AddWithValue("@Ref_ID", Ref_ID);
                command.Parameters.AddWithValue("@SLA", SLA);
                command.Parameters.AddWithValue("@Duration", Duration);
                command.Parameters.AddWithValue("@Priority", Priority);
                command.ExecuteNonQuery();
            }
        }
    }
}
