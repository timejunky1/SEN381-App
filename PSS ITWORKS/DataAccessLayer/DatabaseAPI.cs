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

        public BindingSource GetContractStats(int id, int period)
        {
            MessageBox.Show("GetContract Stats");
            return null;
        }

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
    }
}