using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.ConstantData;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class CallForm : Form
    {
        
        StrategyContextManager context;
        string conn = SystemData.GetConString();
        int employeeID;
        EntityClient client;
        Dashboard dashbord;
        LoginController.UserInfo userInfo;
        int clientID;
        int contractID;
        void PopulateContracts(int id)
        {
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect(conn);
            //IEntity c = context.Get(id);
            //EntityContract contract = c as EntityContract;
            //ContractOverview_dgv.ColumnCount = 5;
            //ContractOverview_dgv.Rows.Clear();

            //ContractOverview_dgv.Rows.Add(contract.GetId(), contract.GetTitle(), contract.GetPriority(), contract.GetCost(), contract.GetDuration());
            ContractOverview_dgv.ColumnCount = 5;
            List<IEntity> list = context.Get();
            DateTime date;
            int priority = 0 ;
            int duration = 0;
            foreach (IEntity entity in list)
            {
                EntityContract contract = entity as EntityContract;
                if (contract.GetId() == id)
                {
                    ContractOverview_dgv.Rows.Add(contract.GetId(), contract.GetTitle(), contract.GetPriority(), contract.GetCost(), contract.GetDuration());
                    contractID = contract.GetId();
                    priority = contract.GetPriority();
                    duration = contract.GetDuration();

                }
                
            }
            Priority_txt.Text = priority.ToString();
            ContractDuration_txt.Text = duration.ToString();
            
            

        }
        void PopulateContracts()
        {
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect(conn);
            //IEntity c = context.Get(id);
            //EntityContract contract = c as EntityContract;
            //ContractOverview_dgv.ColumnCount = 5;
            //ContractOverview_dgv.Rows.Clear();

            //ContractOverview_dgv.Rows.Add(contract.GetId(), contract.GetTitle(), contract.GetPriority(), contract.GetCost(), contract.GetDuration());
            ContractOverview_dgv.ColumnCount = 5;
            List<IEntity> list = context.Get();
            foreach (IEntity entity in list)
            {
                EntityContract contract = entity as EntityContract;
                ContractOverview_dgv.Rows.Add(contract.GetId(), contract.GetTitle(), contract.GetPriority(), contract.GetCost(), contract.GetDuration());
            }

        }

        public int getContractID(string Name)
        {
            int cID = GetClientID(Name);
            DateTime initiationDate;
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(conn);
            List<IEntity> entities = context.Get();
            foreach (IEntity ent in entities)
            {
                EntityClient c = ent as EntityClient;
                if (c.GetID() == cID)
                {
                    contractID = c.GetContractId();
                    initiationDate = c.GetContractInitiationDate();
                    PopulateContracts(contractID);
                }
            }
            MessageBox.Show("contractID in subclass found");
            return contractID;

        }
        public void PopulateDgvWithCalls()
        {
            context = new StrategyContextManager(new StrategyCallManagement());
            context.Connect(conn);

            List<IEntity> entities = (List<IEntity>)context.Get();
            List<EntityCall> listCalls = new List<EntityCall>();
            foreach (IEntity entity in entities)
            {
                EntityCall call = entity as EntityCall;
                if (call.GetEmployeeId() == employeeID)
                {
                    listCalls.Add(call);
                }
            }
            //Display Dashbord
                Dashboard_dgv.ColumnCount = 4;
                foreach(EntityCall call in listCalls)
                {
                    Dashboard_dgv.Rows.Add(call.GetClientId(), call.GetEmployeeId(), call.GetCallTime(), call.GetDescription());
                }

            //Display ServiceRequest
                PastRequests_dgv.RowCount = 4;
                foreach (EntityCall call in listCalls)
                {
                    PastRequests_dgv.Rows.Add(call.GetClientId(), call.GetEmployeeId(), call.GetCallTime(), call.GetDescription());
                    Dashboard_dgv.Rows.Add(call.GetClientId(), call.GetEmployeeId(), call.GetCallTime(), call.GetDescription());
                }
            //Display Client

            //context = new StrategyContextManager(new StrategyContractManager());
            //context.Connect(conn);
            PopulateContracts();
            //List<IEntity> c = context.Get();
            //    ContractOverview_dgv.ColumnCount = 5;
            //    foreach (IEntity entity in c)
            //    {
            //        EntityContract contract1 = entity as EntityContract;
            //        ContractOverview_dgv.Rows.Add(contract1.GetId(), contract1.GetTitle(), contract1.GetPriority(), contract1.GetCost(), contract1.GetDuration());
                    
            //    }
            //Display History
                context = new StrategyContextManager(new StrategyJobManager());
                context.Connect(conn);

                List<IEntity> ent1 = (List<IEntity>)context.Get();
                List<EntityJob> Jobs1 = new List<EntityJob>();
                PastRequests_dgv.ColumnCount = 7;
                foreach (IEntity entity in ent1)
                {
                    EntityJob job = entity as EntityJob;
                    PastServiceRequest_dgv.Rows.Add(job.GetID(), job.GetClientId(), job.GetServiceId(), job.GetTimeBegin(), job.GetTimeEnd(), job.GetStatus(), job.GetNotes());
                    

                }
            


        }

        public int GetClientID(string name)
        {
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(conn);

            List<IEntity> entities = context.Get();
            foreach (IEntity entity in entities)
            {
                EntityClient client = entity as EntityClient;
                MessageBox.Show(client.GetName());
                if (client.GetName() == name)
                {
                   clientID = client.GetID();
                    
                }
            }
            return clientID;
        }

        public void DislpayClientHistory(int clientID)
        {
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);
            PastRequests_dgv.Rows.Clear();
            PastServiceRequest_dgv.Rows.Clear();
            List<IEntity> entities = (List<IEntity>)context.Get();
            List<EntityJob> listJobs = new List<EntityJob>();
            Dashboard_dgv.ColumnCount = 7;
            foreach (IEntity entity in entities)
            {
                EntityJob job = entity as EntityJob;
                if (job.GetClientId() == clientID)
                {
                    PastRequests_dgv.Rows.Add(job.GetID(), job.GetClientId(), job.GetServiceId(), job.GetTimeBegin(), job.GetTimeEnd(), job.GetStatus(), job.GetNotes());
                    PastServiceRequest_dgv.Rows.Add(job.GetID(), job.GetClientId(), job.GetServiceId(), job.GetTimeBegin(), job.GetTimeEnd(), job.GetStatus(), job.GetNotes());
                    listJobs.Add(job);
                }
            }
              
        }
        public CallForm(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            InitializeComponent();
            this.dashbord = dashboard;
            this.userInfo = userInfo;
            PSS_lbl.Text = $"Welcome Back {userInfo.Name} {userInfo.Surname} <Call Employee>";
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Visible = true;
        }

        private void CallForm_Load(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            loginController.Connect();
            employeeID = userInfo.ID;
            PopulateDgvWithCalls();
            
        }
        ///Call form, History tab search
        private void Search_btn_Click(object sender, EventArgs e)
        {
            string clientName = SearchClientName_txt.Text;

            if (clientName == null)
            {
                MessageBox.Show("Please enter the client's name to search");
            }
            else
            {
               clientID = GetClientID(clientName);
                MessageBox.Show(clientID.ToString() + "client id");
            }
                //check if client exist
            if (clientID >0)
            {
                PastRequests_dgv.Rows.Clear();
                DislpayClientHistory(clientID);
            }
            else
            {
                MessageBox.Show($"Client {clientName} was  not found");
                SearchClientName_txt.Clear();   
                SearchClientName_txt.Focus();
            }
            
        }

        private void SearchClient_btn_Click(object sender, EventArgs e)
        {
            string clientName = ClientName_txt.Text;

            if (clientName == null)
            {
                MessageBox.Show("Please enter the client's name to search");
                SearchClientName_txt.Clear();
                SearchClientName_txt.Focus();
            }
            else
            {
                clientID = GetClientID(clientName);
                MessageBox.Show(clientID.ToString() + "client id");
            }
            //check if client exist
            if (clientID > 0)
            {
                context = new StrategyContextManager(new StrategyClientManager());
                context.Connect(conn);
                DateTime initiationDate = DateTime.Now;

                IEntity entity = context.Get(clientID);
                EntityClient client = entity as EntityClient;
                contractID = getContractID(clientName);

                int cID = GetClientID(Name);
                context = new StrategyContextManager(new StrategyClientManager());
                context.Connect(conn);
                List<IEntity> entities = context.Get();
                foreach (IEntity ent in entities)
                {
                    EntityClient c = ent as EntityClient;
                    if (c.GetID() == cID)
                    {
                        contractID = c.GetContractId();
                        initiationDate = c.GetContractInitiationDate();
                    }
                }
                int d = int.Parse( ContractDuration_txt.Text);
                DateTime date = initiationDate.AddMonths(d);
                ExperationDate_txt.Text = date.ToString();


                MessageBox.Show(contractID.ToString() + "contract id");
                
            }
            else
            {
                MessageBox.Show($"Client {clientName} was  not found");
                SearchClientName_txt.Clear();
                SearchClientName_txt.Focus();
            }
            

        }

        private void NewServiceRequest_btn_Click(object sender, EventArgs e)
        {
            string clientName = NewServiceClientName_txt.Text;
            if (clientName == null)
            {
                MessageBox.Show("Please enter the client's name to search");
                SearchClientName_txt.Clear();
                SearchClientName_txt.Focus();
            }
            else
            {
                clientID = GetClientID(clientName);
                MessageBox.Show(clientID.ToString() + "client id");
            }
            PastRequests_dgv.Rows.Clear();
            DislpayClientHistory(clientID);
            if (clientID > 0)
            {
                this.Hide();
                ServiceRequestForm form = new ServiceRequestForm(employeeID, clientID, this);
                form.Show();


            }
            else
            {
                NewServiceClientName_txt.Clear();
                NewServiceClientName_txt.Focus();
                MessageBox.Show("Client was not found");
            }

        }

        private void Title_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashbord.Show();
            this.Close();
        }

        private void NewServiceClientName_txt_TextChanged(object sender, EventArgs e)
        {
            
            //repopulate dgv
        }

        private void Logout_btn_Click_1(object sender, EventArgs e)
        {
            dashbord.Show();
            this.Close();
        }
    }
}
