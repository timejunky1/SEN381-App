using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.Presentation_Layer;
using System.Data.SqlClient;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ServiceRequestForm : Form
    {
        StrategyContextManager context;
        string conn = @"Data Source = DESKTOP - 8GCK8IN\SQLEXPRESS; Initial Catalog = PSS; Integrated Security = True";
        
        public int clientId = 0;
        public int empId = 0;

        void LoadPriority()
        {

        }

        void LoadService(int clientId)
        {
            int clientID = 0;
            int contractID = 0;
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(conn);

            List<IEntity> entities = (List<IEntity>)context.Get();
            List<EntityContract> contracts = new List<EntityContract>();
            foreach (IEntity ent in entities)
            {
                EntityContract c = ent as EntityContract;
                if (c.GetId() == contractID)
                {
                    contracts.Add(c.GetServices());

                }
            }

            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect(conn);

            List<IEntity> entity = (List<IEntity>)context.Get();


            if (contractID == 0)
            {
                
            }

            
        }
        
        public ServiceRequestForm(int employeeid, int customerId)
        {
            empId = employeeid;
            clientId = customerId;
            InitializeComponent();
        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            
            /////Populate Priority combo box
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT service_id,DISTINCT priority, DISTINCT title FROM service");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            PriorityLevel__cbx.DataSource = ds.Tables[0];
            PriorityLevel__cbx.DisplayMember = "priority";
            PriorityLevel__cbx.ValueMember = "service_id";

            /////Populate Service Type combo box
            ServiceType_cbx.DataSource = ds.Tables[0];
            ServiceType_cbx.DisplayMember = "title";
            ServiceType_cbx.ValueMember = "service_id";
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            int contractNumber = int.Parse(ContactNumber_txt.Text);
            string email = EmailAddress_txt.Text;
            string equipSerialNo = EquipmentSerialNumber_txt.Text;
            int selectedIndex = PriorityLevel__cbx.SelectedIndex;
            PriorityLevel__cbx.SelectedItem.ToString();
            int priority = (int)PriorityLevel__cbx.Items[selectedIndex];
            int ServiceTypeIndex = ServiceType_cbx.SelectedIndex;
            ServiceType_cbx.SelectedItem.ToString();
            int serviceType = (int)ServiceType_cbx.ValueMember[ServiceTypeIndex];
            string desc = "Equipment Serial Number: " + equipSerialNo + " " + Description_rbx.Text;
            callManagement.Create(job);

            MessageBox.Show("Service Request successfully created");

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            CallForm callForm = new CallForm();
            callForm.ShowDialog();
        }

        private void Submit_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
