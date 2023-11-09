using PSS_ITWORKS.ConstantData;
using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ClientManagerForm : Form
    {
        private Dashboard dashboard;
        LoginController.UserInfo userInfo;
        string connString = SystemData.GetConString();
        int clientId;
        StrategyContextManager context;
        public ClientManagerForm(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.userInfo = userInfo;
            welcome_lbl.Text = $"Welcome Back {userInfo.Name} {userInfo.Surname} <Client Manager>";
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }


        private void ClientManagerForm_Load(object sender, EventArgs e)
        {
            WelcomeClientManager_lbl.Text = $"Welcome {userInfo.Name} {userInfo.Surname} (Client Manager)";
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(connString);
            List<IEntity> entities = context.Get();
            clientDetail_dgv.DataSource = null;
            clientDetail_dgv.Rows.Clear();
            clientDetail_dgv.ColumnCount = 9;
            foreach(IEntity entity in entities)
            {
                EntityClient client  = entity as EntityClient;
                clientDetail_dgv.Rows.Add(client.GetID(), client.GetEmail(), client.GetName(), client.GetSurname(), client.GetContractInitiationDate(), client.GetStreetNumber(), client.GetStreetName(), client.GetCity(), client.GetProvince());
            }

        }

        private void clientDetail_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(connString);
            clientId = int.Parse(clientDetail_dgv.Rows[clientDetail_dgv.CurrentRow.Index].Cells[0].Value.ToString());
            EntityClient client = context.Get(clientId) as EntityClient;
            clientContract_dgv.DataSource = null;
            clientContract_dgv.Rows.Clear();
            clientContract_dgv.ColumnCount = 4;
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect(connString);
            EntityContract contract = context.Get(client.GetContractId()) as EntityContract;
            clientContract_dgv.Rows.Add(contract.GetTitle(), contract.GetCost(), contract.GetDuration(), contract.GetAvailability());
            clientJobs_dgv.DataSource = null;
            clientJobs_dgv.Rows.Clear();
            clientJobs_dgv.ColumnCount = 4;
            foreach(EntityJob job in client.GetJobs())
            {
                clientJobs_dgv.Rows.Add(job.GetServiceId(), job.GetTimeBegin(), job.GetTimeEnd(), job.GetStatus());
            }
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            int contractId = int.Parse(clientContract_txt.Text);
            int clientId = int.Parse(clientContactDetail_txt.Text);
            string clientName = clientContactDetail_txt.Text;
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(connString);
            List<IEntity> entities = context.Get();
            clientDetail_dgv.DataSource = null;
            clientDetail_dgv.Rows.Clear();
            clientDetail_dgv.ColumnCount = 9;
            foreach (IEntity entity in entities)
            {
                EntityClient client = entity as EntityClient;
                if (client.GetContractId() == contractId || client.GetName() == clientName || client.GetID() == clientId)
                {
                    clientDetail_dgv.Rows.Add(client.GetID(), client.GetEmail(), client.GetName(), client.GetSurname(), client.GetContractInitiationDate(), client.GetStreetNumber(), client.GetStreetName(), client.GetCity(), client.GetProvince());
                }
            }
            
        }
    }
}
