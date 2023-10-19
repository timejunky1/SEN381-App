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

        public BindingSource GetClientOverview(string username, string contactNumber)
        {
            SqlDataReader reader = null;
            BindingSource bs = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetClientOverview", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientUserName", username);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
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

            }
            return bs;
        }

        public void InsertUser(EntityClient client)
        {
            SqlDataReader reader = null;
            BindingSource bs = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.InsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompanyName", client.GetCompanyName());
                cmd.Parameters.AddWithValue("@Name", client.GetName());
                cmd.Parameters.AddWithValue("@Surname", client.GetSurname());
                cmd.Parameters.AddWithValue("@ContractId", client.GetContractId());
                cmd.Parameters.AddWithValue("@Phone", client.GetPhone());
                cmd.Parameters.AddWithValue("@Email", client.GetEmail());
                cmd.Parameters.AddWithValue("@ContractInitiationDate", client.GetContractInitiationDate());
                cmd.Parameters.AddWithValue("@StreetNumber", client.GetStreetNumber());
                cmd.Parameters.AddWithValue("@Street", client.GetStreetName());
                cmd.Parameters.AddWithValue("@City", client.GetCity());
                cmd.Parameters.AddWithValue("@Province", client.GetProvince());
                cmd.Parameters.AddWithValue("@ZipCode", client.GetZipCode());
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

            }
        }
    }
}