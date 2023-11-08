using PSS_ITWORKS.ConstantData;
using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Twilio.TwiML.Voice;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ContractManagerForm : Form
    {
        Dashboard dashbord;
        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Des" };
        StrategyContextManager context;
        List<EntityContract> contracts = new List<EntityContract>();
        List<EntityService> services = new List<EntityService>();
        List<EntityService> allServices = new List<EntityService>();
        LoginController.UserInfo userInfo;
        int serviceId;
        int contractId;
        string availability = "Available";
        string availabilityC = "Available";
        int id1;
        int id2;
        int m1;
        int m2;
        int serviceid;
        string connString = SystemData.GetConString();
        public ContractManagerForm(Dashboard dashbord, LoginController.UserInfo userInfo)
        {
            this.userInfo = userInfo;
            this.dashbord = dashbord;
            InitializeComponent();
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisY.Interval = 1;
            chart2.ChartAreas[0].AxisX.Interval = 1;
        }

        Series GetValues(int m, List<EntityJob> jobs, string status)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            int end = DateTime.Now.Month;
            int start = end - m;
            for (int i = start; i < end; i++)
            {
                if (i < 0)
                {
                    series.Points.AddXY(months[12 + i], 0);
                    continue;
                }
                series.Points.AddXY(months[i], 0);
            }
            foreach (EntityJob job in jobs)
            {
                if(job.GetStatus() == status)
                {
                    series.Points[job.GetTimeBegin().Month - start - 1].SetValueY(1);
                }
            }
            series.LegendText = status;
            return series;
        }

        void SetService()
        {
            context = new StrategyContextManager(new StrategyServiceManager());
            context.Connect(connString);
            EntityService service = context.Get(serviceid) as EntityService;
            ServiceType_cbx.Text = service.GetTitle();
            title_txt.Text = service.GetTitle();
            duration_num.Value = service.GetDuration();
            priority_num.Value = service.GetPriority();
            price_num.Value = service.GetCost();
            setAvailability(service.GetAvailability());
            ContractCount_txt.Text = service.GetContracts().Count().ToString();

        }

        void SetContract()
        {
            if (contractId > 0)
            {
                context = new StrategyContextManager(new StrategyContractManager());
                context.Connect(connString);
                EntityContract contract = context.Get(contractId) as EntityContract;
                sla_txt.Text = contract.GetSLA();
                durationC_num.Value = contract.GetDuration();
                priorityC_num.Value = contract.GetPriority();
                priceC_num.Value = (Decimal)contract.GetCost();
                setAvailability(contract.GetAvailability());
                clientCount_txt.Text = contract.GetClients().Count.ToString();
                contract_services_dgv.DataSource = context.Get(contractId);
                foreach (EntityService s in contract.GetServices())
                {
                    services.Add(s);
                }
                ContractType1_cbx.Text = contract.GetTitle();

            }
            else
            {
                contractId = 1;
                SetContract();
            }
        }

        void setAvailability(string a)
        {
            availability = a;
            if (availability == "Available")
            {
                Available_btn.Enabled = false;
                Unvailable_btn.Enabled = true;
            }
            else
            {
                Available_btn.Enabled = true;
                Unvailable_btn.Enabled = false;
            }
        }

        void setAvailabilityC(string a)
        {
            availabilityC = a;
            if (availabilityC == "Available")
            {
                availableC_btn.Enabled = false;
                unavailableC_btn.Enabled = true;
            }
            else
            {
                availableC_btn.Enabled = true;
                unavailableC_btn.Enabled = false;
            }
        }

        void SetContractStats()
        {

            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            List<IEntity> entities = context.Get();
            List<EntityJob> jobs1 = new List<EntityJob>();
            List<EntityJob> jobs2 = new List<EntityJob>();
            foreach (IEntity entity in entities)
            {
                EntityClient client = entity as EntityClient;
                if(client.GetContractId() == id1)
                {
                    foreach (EntityJob job in client.GetJobs())
                    {
                        jobs1.Add(job);
                    }
                }
                if (client.GetContractId() == id2)
                {
                    foreach(EntityJob job in client.GetJobs())
                    {
                        jobs2.Add(job);
                    }
                }
            }
            chart1.Legends.Clear();
            chart1.Series.Clear();
            chart1.Legends.Add(new Legend());
            chart1.Series.Add(GetValues(12, jobs1, "Finished"));
            chart1.Legends.Add(new Legend());
            chart1.Series.Add(GetValues(12, jobs1, "Canceled"));
            chart2.Legends.Clear();
            chart2.Series.Clear();
            chart2.Legends.Add(new Legend());
            chart2.Series.Add(GetValues(12, jobs2, "Finished"));
            chart2.Legends.Add(new Legend());
            chart2.Series.Add(GetValues(12, jobs2, "Canceled"));
        }
        private void ContractManagerForm_Load(object sender, EventArgs e)
        {
            m1 = 12;
            m2 = 12;
            id1 = 1;
            id2 = 2;
            context = new StrategyContextManager(new StrategyServiceManager());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            List<IEntity> entities = context.Get();
            foreach (IEntity entity in entities)
            {
                EntityService service = entity as EntityService;
                ServiceType_cbx.Items.Add(service.GetTitle());
            }
            SetService();
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            entities = context.Get();
            foreach (IEntity entity in entities)
            {
                EntityContract contract = entity as EntityContract;
                contracts.Add(contract);
                ContractType1_cbx.Items.Add(contract.GetTitle());
                ContractType2_cbx.Items.Add(contract.GetTitle());
                contractType_cbx.Items.Add(contract.GetTitle());
            }
            SetContractStats();
            SetContract();
        }

        private void ServiceType_lbl_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void UpdateService_btn_Click(object sender, EventArgs e)
        {
            context.Update(new EntityService(serviceId, title_txt.Text, (int)duration_num.Value, (int)priority_num.Value, price_num.Value, availability));
        }

        private void Months2_num_ValueChanged(object sender, EventArgs e)
        {
            m2 = (int)Months2_num.Value;
            SetContractStats();
        }

        private void months1_num_ValueChanged(object sender, EventArgs e)
        {
            m1 = (int)months1_num.Value;
            SetContractStats();
        }

        private void ContractType2_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            id2 = ContractType2_cbx.SelectedIndex + 1;
            SetContractStats();
        }

        private void ContractType1_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            id1 = ContractType1_cbx.SelectedIndex + 1;
            SetContractStats();
        }

        private void ContractManagement_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ContractManagement_tc.SelectedIndex == 1)
            {
                SetService();
            }
            else if(ContractManagement_tc.SelectedIndex == 2)
            {
                SetContract();
            }
            else
            {
                SetContractStats();
            }
        }

        private void Available_btn_Click(object sender, EventArgs e)
        {
            setAvailability("Available");

        }

        private void Unvailable_btn_Click(object sender, EventArgs e)
        {
            setAvailability("Unavailable");
        }

        private void Services_dgv_SelectionChanged(object sender, EventArgs e)
        {
            serviceId = int.Parse(Services_dgv.SelectedRows[0].Cells[0].Value.ToString());
            SetService();
        }

        private void CreateService_btn_Click(object sender, EventArgs e)
        {
            context.Create(new EntityService(serviceId, title_txt.Text, (int)duration_num.Value, (int)priority_num.Value, price_num.Value, availability));
        }

        private void availableC_btn_Click(object sender, EventArgs e)
        {
            setAvailabilityC("Available");
        }

        private void unavailableC_btn_Click(object sender, EventArgs e)
        {
            setAvailabilityC("Unavailable");
        }

        private void contractType_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            contractId = int.Parse(contractType_cbx.SelectedItem.ToString());
            SetContract();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            EntityContract contract = new EntityContract(contractId, contractType_cbx.Text, sla_txt.Text, (int)durationC_num.Value, priceC_num.Value, (int)priorityC_num.Value, availability);
            contract.SetServices(services);
        }

        private void crateC_btn_Click(object sender, EventArgs e)
        {
            EntityContract contract = new EntityContract(contractId, contractType_cbx.Text, sla_txt.Text, (int)durationC_num.Value, priceC_num.Value, (int)priorityC_num.Value, availability);
            contract.SetServices(services);
            context.Create(contract);
        }

        private void deleteC_btn_Click(object sender, EventArgs e)
        {
            context.Delete(contractId);
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashbord.Show();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            foreach(EntityService service in allServices)
            {
                if (service.GetTitle() == servicesC_cbx.Text)
                {
                    services.Add(service);
                }
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            foreach (EntityService service in allServices)
            {
                if (service.GetTitle() == servicesC_cbx.Text)
                {
                    services.Remove(service);
                }
            }
        }
    }
}
