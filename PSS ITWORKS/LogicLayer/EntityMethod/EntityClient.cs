// EntityClient.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityClient : IEntity
    {
        private int Id;
        private string clientName;
        private string address;
        private string contactDetails;
        private string clientRole;
        private int contract;

        public void Get()
        {
            // Retrieve data for EntityClient from the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to fetch EntityClient data
                SqlCommand command = new SqlCommand("SELECT * FROM Client WHERE Client_ID = @Id", connection);
                command.Parameters.AddWithValue("@Id", Id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Map retrieved data to class properties
                    Id = (int)reader["Client_ID"];
                    clientName = reader["Company_Name"].ToString();
                    address = reader["Address"].ToString();
                    contactDetails = reader["Contact_Details"].ToString();
                    clientRole = reader["Role"].ToString();
                    contract = (int)reader["Contract_ID"];
                }

                reader.Close();
            }
        }

        public void Set()
        {
            // Update or insert data for EntityClient into the database
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                // Create and execute SQL query to update or insert data
                SqlCommand command = new SqlCommand("INSERT INTO Client (Client_ID, Company_Name, Address, Contact_Details, Role, Contract_ID) VALUES (@Id, @ClientName, @Address, @ContactDetails, @Role, @Contract)", connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@ClientName", clientName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@ContactDetails", contactDetails);
                command.Parameters.AddWithValue("@Role", clientRole);
                command.Parameters.AddWithValue("@Contract", contract);
                command.ExecuteNonQuery();
            }
        }
    }
}
