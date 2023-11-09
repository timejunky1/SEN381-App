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
using PSS_ITWORKS.ConstantData;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ServiceRequestForm : Form
    {
        StrategyContextManager context;
        string conn = SystemData.GetConString();

        public int clientId = 0;
        public int empId = 0;
        List<EntityService> services;
        CallForm callForm;


        void LoadService()
        {
            int contractID = 0;
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(conn);
            string[] services = new string[1000];
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
            ///List<EntityService> services = new List<EntityService>();
            List<EntityContract> contract = new List<EntityContract>();

            if (contractID != 0)
            {
                foreach (IEntity ent in entities)
                {
                    EntityContract c = ent as EntityContract;
                    for (int i = 0; i < entities.Count; i++)
                    {
                        if (c.GetId() == contractID)
                        {
                            contract.Add(c);
                            services[i] = c.GetTitle();

                        }
                    }
                    
                }

            }
            else
            {
                context = new StrategyContextManager(new StrategyServiceManager());
                context.Connect(conn);

                List<IEntity> ser = (List<IEntity>)context.Get();
                List<EntityService> ser1 = new List<EntityService>();
                foreach(IEntity s in ser)
                {
                    EntityService ser2 = s as EntityService;
                    for (int i = 0; i < entities.Count; i++)
                    {
                        if (ser2.GetId() == contractID)
                        {
                            services[i] = ser2.GetTitle();

                        }
                    }

                }
                

            }
            for (int x = 0; x < services.Count(); x++)
            {
                ServiceType_cbx.Items.Add(services[x]);
            }
            
        }
        
        public ServiceRequestForm(int employeeid, int customerId, CallForm callForm)
        {
            empId = employeeid;
            clientId = customerId;
            this.callForm = callForm;
            InitializeComponent();
        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            
            /////Populate Priority combo box
            for (int i = 0; i>6; i++)
            {
                PriorityLevel_cbx.Items.Add(i.ToString());
            }
            /////Populate Service Type combo box
            LoadService();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            callForm.Show();
        }

        private void Submit_btn_Click_1(object sender, EventArgs e)
        {
            StrategyContextManager context = new StrategyContextManager(new StrategyServiceManager());
            context.Connect(conn);
            DateTime date = DateTime.Now;
            int contractNumber = int.Parse(ContactNumber_txt.Text);
            string email = EmailAddress_txt.Text;
            string equipSerialNo = EquipmentSerialNumber_txt.Text;
            int priority = int.Parse(PriorityLevel_cbx.SelectedItem.ToString());
            string serviceType = ServiceType_cbx.SelectedItem.ToString();
            int serviceID = 0;
            List<IEntity> ent = context.Get();

            foreach (EntityService entity in ent)
            {
                EntityService service = entity as EntityService;
                if (service.GetTitle() == serviceType)
                {
                    serviceID = service.GetId();
                }


            }
            MessageBox.Show(serviceID.ToString() + " serviceID"); 


            string desc = "Equipment Serial Number: " + equipSerialNo + " " + Description_rbx.Text;
            string status = "Pending";

            context = new StrategyContextManager(new StrategyCallManagement());
            context.Connect(conn);

            ///// add call log
            EntityCall call = new EntityCall(0, empId, clientId, date, desc);
            context.Create(call);

            ///add job
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);
            EntityJob job = new EntityJob(0, clientId, serviceID, DateTime.Now, DateTime.Now, status, "");
            context.Create(job);



            MessageBox.Show("Service Request successfully created");
            this.Close();

        }

        private void Close_btn_Click_1(object sender, EventArgs e)
        {
            callForm.Show();
            this.Close();
        }
    }
}
