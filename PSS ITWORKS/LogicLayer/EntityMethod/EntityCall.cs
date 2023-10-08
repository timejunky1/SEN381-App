// EntityCall.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityCall : IEntity
    {
        private int Id;
        private string eUsername;
        private int clientId;
        private DateTime time;
        private string service;
        private string clientDescription;

        public void Get()
        {
            // Retrieve data for EntityCall from the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to fetch EntityCall data
                SqlCommand command = new SqlCommand("SELECT * FROM CallLog WHERE Call_ID = @Id", connection);
                command.Parameters.AddWithValue("@Id", Id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Map retrieved data to class properties
                    Id = (int)reader["Call_ID"];
                    eUsername = reader["Employee_Username"].ToString();
                    clientId = (int)reader["Client_ID"];
                    time = (DateTime)reader["TimeStamp"];
                    service = reader["Role"].ToString();
                    clientDescription = reader["Description"].ToString();
                }

                reader.Close();
            }
        }

        public void Set()
        {
            
            // Update or insert data for EntityCall into the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to update or insert data
                SqlCommand command = new SqlCommand("INSERT INTO CallLog (Call_ID, Employee_Username, Client_ID, TimeStamp, Role, Description) VALUES (@Id, @Username, @ClientId, @Time, @Service, @Description)", connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Username", eUsername);
                command.Parameters.AddWithValue("@ClientId", clientId);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Service", service);
                command.Parameters.AddWithValue("@Description", clientDescription);
                command.ExecuteNonQuery();
            }
        }
    }
}