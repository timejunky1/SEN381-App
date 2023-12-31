﻿using System;
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
        void PopulateContracts(int id)
        {
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect("conn string");
            List<IEntity> entities = context.Get();
            List<EntityContract> contracts = new List<EntityContract>();
            foreach (IEntity ent in entities)
            {
                EntityContract c = ent as EntityContract;
                if (c.GetId() == id)
                {
                    contracts.Add(c);
                }
            }
            ContractOverview_dgv.ColumnCount = 5;
            ContractOverview_dgv.Rows.Clear();
            foreach (EntityContract contract in contracts)
            {
                ContractOverview_dgv.Rows.Add(contract.GetId(), contract.GetTitle(), contract.GetPriority(), contract.GetCost(), contract.GetDuration());
            }
        }
        void getContractInfo(DateTime InitiationDate)
        {
            int contractID = int.Parse(ContractOverview_dgv.SelectedRows[0].Cells[0].Value.ToString());

            int priority = 0;
            int duration = 0;
            DateTime date;
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect("conn string");
            List<IEntity> entities = context.Get();
            List<EntityContract> contracts = new List<EntityContract>();
            foreach (IEntity ent in entities)
            {
                EntityContract c = ent as EntityContract;
                if (c.GetId() == contractID)
                {
                    priority = c.GetPriority();
                    duration = c.GetDuration();
                }
            }
            Priority_txt.Text = priority.ToString();
            ContractDuration_txt.Text = duration.ToString();
            date = InitiationDate.AddMonths(duration);
            ExperationDate_txt.Text = date.ToString();

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

            ///display data in data grid view according to to active tabs
            if (CallEmployee_tc.SelectedTab == CallEmployee_tc.TabPages["Dashboard_tp"])
            {
                Dashboard_dgv.ColumnCount = 4;
                Dashboard_dgv.Rows.Clear();
                foreach(EntityCall call in listCalls)
                {
                    Dashboard_dgv.Rows.Add(call.GetClientId(), call.GetEmployeeId(), call.GetCallTime(), call.GetDescription());
                }

                //This will assign the datasource. All the columns you listed will show up, and every row
                //of data in the list will populate into the DataGridView.
            }
            else if (CallEmployee_tc.SelectedTab == CallEmployee_tc.TabPages["ServiceRequest_tp"])
            {
                PastRequests_dgv.RowCount = 4;
                PastRequests_dgv.Rows.Clear();
                foreach (EntityCall call in listCalls)
                {
                    PastRequests_dgv.Rows.Add(call.GetClientId(), call.GetEmployeeId(), call.GetCallTime(), call.GetDescription());
                }
            }

        }

        public int GetClientID(string name)
        {
            int clientID = 0;
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(conn);

            List<IEntity> entities = context.Get();
            foreach (IEntity entity in entities)
            {
                EntityClient client = entity as EntityClient;
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

            List<IEntity> entities = (List<IEntity>)context.Get();
            List<EntityJob> listJobs = new List<EntityJob>();
            foreach (IEntity entity in entities)
            {
                EntityJob job = entity as EntityJob;
                if (job.GetClientId() == clientID)
                {
                    listJobs.Add(job);
                }
            }
            PastServiceRequest_dgv.DataSource=listJobs;   
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
            int clientID = 0;
            if (clientName == null)
            {
                MessageBox.Show("Please enter the client's name to search");
            }
            else
            {
               clientID = GetClientID(clientName);
            }
                //check if client exist
            if (clientID >0)
            {
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
            string clientName = SearchClientName_txt.Text;
            MessageBox.Show($"Search client name: {clientName}");
            context = new StrategyContextManager(new StrategyClientManager());
            int contractId = 0;
            DateTime initiationDate = DateTime.Now;
            int clientID = 0;
            if (clientName == null)
            {
                MessageBox.Show("Please enter the client's name to search");
            }
            else
            {
                clientID = GetClientID(clientName);
            }
            //check if client exist
            if (clientID > 0)
            {
                context = new StrategyContextManager(new StrategyClientManager());
                context.Connect(conn);

                List<IEntity> entities = context.Get();
                foreach (IEntity entity in entities)
                {
                    EntityClient client = entity as EntityClient;
                    if (client.GetID() == clientID)
                    {
                        contractId = client.GetContractId();
                        initiationDate = client.GetContractInitiationDate();
                    }
                }
                PopulateContracts(contractId);
                getContractInfo(initiationDate);
            }
            else
            {
                MessageBox.Show($"Client {clientName} was not found");
                ClientName_txt.Clear();
                ClientName_txt.Focus();
            }
                
        }

        private void NewServiceRequest_btn_Click(object sender, EventArgs e)
        {
            string clientName = NewServiceClientName_txt.Text;
            int clientID = 0;
            clientID = GetClientID(clientName);
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
    }
}
