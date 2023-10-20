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

        //Contract Interaction

        public void CreateContract(EntityContract contract)
        {
            MessageBox.Show("Create Contract");
        }

        public void GetContractStats(int id, int period)
        {
            MessageBox.Show("GetContract Stats");
        }

        public void GetServices()
        {
            MessageBox.Show("GetServices");
        }

        public void UpdateContract(EntityContract contract)
        {
            MessageBox.Show("UpdateContract");
        }

        public void DeleteContract(int Id)
        {
            MessageBox.Show("DeleteContract");
        }
        public void AddContractRef(int contractId, int serviceId)
        {
            MessageBox.Show("AddContractRef");
        }

        //

        public void InsertUser(EntityUser user)
        {
            SqlDataReader reader = null;
            BindingSource bs = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminPortalProcedures.InsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompanyName", user.GetCompanyName());
                cmd.Parameters.AddWithValue("@Name", user.GetName());
                cmd.Parameters.AddWithValue("@Surname", user.GetSurname());
                cmd.Parameters.AddWithValue("@ContractId", user.GetContractId());
                cmd.Parameters.AddWithValue("@Phone", user.GetPhone());
                cmd.Parameters.AddWithValue("@Email", user.GetEmail());
                cmd.Parameters.AddWithValue("@ContractInitiationDate", user.GetContractInitiationDate());
                cmd.Parameters.AddWithValue("@StreetNumber", user.GetStreetNumber());
                cmd.Parameters.AddWithValue("@Street", user.GetStreetName());
                cmd.Parameters.AddWithValue("@City", user.GetCity());
                cmd.Parameters.AddWithValue("@Province", user.GetProvince());
                cmd.Parameters.AddWithValue("@ZipCode", user.GetZipCode());
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