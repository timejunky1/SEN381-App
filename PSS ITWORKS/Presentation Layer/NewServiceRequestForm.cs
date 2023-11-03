﻿using System;
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


        void LoadService()
        {
            int contractID = 0;
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(conn);
            //// Get contractId
            List<IEntity> entities = (List<IEntity>)context.Get();
            List<EntityClient> client = new List<EntityClient>();
            foreach (IEntity ent in entities)
            {
                EntityClient c = ent as EntityClient;
                if (c.GetID() == clientId)
                {
                    contractID = c.GetContractId();

                }
            }
            ///Get Services from ContractId
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect(conn);

            List<IEntity> entity = (List<IEntity>)context.Get();
            List<EntityService> services = new List<EntityService>();
            List<EntityContract> contract = new List<EntityContract>();

            if (contractID != 0)
            {
                foreach (IEntity ent in entities)
                {
                    EntityContract c = ent as EntityContract;
                    if (c.GetId() == contractID)
                    {
                        contract.Add(c);

                    }
                }
                foreach (EntityContract c in contract)
                {
                    EntityContract contract1 = c as EntityContract;
                    ServiceType_cbx.Items.Add(contract1.GetServices());
                    
                }

            }
            else
            {
                foreach(EntityContract c in contract)
                {
                    ServiceType_cbx.Items.Add(c.GetServices());

                }
                

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
            for (int i = 0; i>6; i++)
            {
                PriorityLevel__cbx.Items.Add(i.ToString());
            }
            /////Populate Service Type combo box
            LoadService();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            StrategyContextManager context = new StrategyContextManager(new StrategyCallManagement());
            context.Connect(conn);
            DateTime date = DateTime.Now;
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
            string status = "Pending";

            ///// add call log
            EntityCall call = new EntityCall(0, empId, clientId, date , desc);
            context.Create(call);

            ///add job
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);
            EntityJob job = new EntityJob(0, clientId, serviceType, DateTime.Now, DateTime.Now, status, "");
            context.Create(job);



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
