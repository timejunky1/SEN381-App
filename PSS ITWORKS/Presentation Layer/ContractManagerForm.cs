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
        BindingSource bs;
        int serviceId;
        int contractId;
        string availability = "Available";
        string availabilityC = "Available";
        public ContractManagerForm(Dashboard dashbord)
        {
            this.dashbord = dashbord;
            InitializeComponent();
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisY.Interval = 1;
            chart2.ChartAreas[0].AxisX.Interval = 1;
        }

        Series GetValues(int m, BindingSource bs, string name)
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
            foreach (IDataRecord dr in bs.List)
            {
                series.Points[int.Parse(dr[3].ToString()) - start - 1].SetValueY(int.Parse(dr[1].ToString()));
            }
            series.LegendText = name;
            return series;
        }

        void SetService()
        {
            if (Services_dgv.SelectedRows.Count > 0)
            {
                BindingSource bs = context.Get(int.Parse(Services_dgv.SelectedRows[0].Cells[0].Value.ToString()));
                foreach (IDataRecord dr in bs.List)
                {
                    ServiceType_cbx.Text = dr[1].ToString();
                    title_txt.Text = dr[1].ToString();
                    duration_num.Value = int.Parse(dr[2].ToString());
                    priority_num.Value = int.Parse(dr[3].ToString());
                    try
                    {
                        price_num.Value = int.Parse(dr[4].ToString());
                    }
                    catch
                    {
                        priceC_num.Value = 0;
                    }
                    setAvailability(dr[5].ToString());
                    ContractCount_txt.Text = dr[6].ToString();
                }
            }
            else
            {
                BindingSource bs = context.Get(serviceId);
                foreach(IDataRecord dr in bs.List)
                {
                    ServiceType_cbx.Text = dr[1].ToString();
                    title_txt.Text = dr[1].ToString();
                    duration_num.Value = int.Parse(dr[2].ToString());
                    priority_num.Value = int.Parse(dr[3].ToString());
                    try
                    {
                        price_num.Value = int.Parse(dr[4].ToString());
                    }
                    catch
                    {
                        priceC_num.Value = 0;
                    }
                    setAvailability(dr[5].ToString());
                    ContractCount_txt.Text = dr[6].ToString();
                }
                serviceId = 0;
            }
        }

        void SetContract()
        {
            if (contractId > 0)
            {
                BindingSource bs = context.GetSpecific1(contractId);
                foreach(IDataRecord dr in bs.List)
                {
                    sla_txt.Text = dr[1].ToString();
                    durationC_num.Value = int.Parse(dr[2].ToString());
                    priorityC_num.Value = int.Parse(dr[3].ToString());
                    try
                    {
                        priceC_num.Value = int.Parse(dr[4].ToString());
                    }
                    catch
                    {
                        priceC_num.Value = 0;
                    }
                    MessageBox.Show(dr[4].ToString());
                    setAvailability(dr[5].ToString());
                    clientCount_txt.Text = dr[6].ToString();
                }
                contract_services_dgv.DataSource = context.Get(contractId);
                
            }
            else
            {
                contractId = 1;
                SetContract();
            }
            ContractType1_cbx.Text = contractId.ToString();
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

        void setContractStats()
        {
            ContractType1_cbx.SelectedIndex = 0;
            ContractType1_cbx.SelectedIndex = 1;
            chart1.Legends.Clear();
            chart1.Series.Clear();
            chart1.Legends.Add(new Legend());
            chart1.Series.Add(GetValues(12, context.GetSpecific(ContractType1_cbx.SelectedIndex + 1, 12, "Finished"), "Finished"));
            chart1.Legends.Add(new Legend());
            chart1.Series.Add(GetValues(12, context.GetSpecific(ContractType1_cbx.SelectedIndex + 1, 12, "Canceled"), "Canceled"));
            chart2.Legends.Clear();
            chart2.Series.Clear();
            chart2.Legends.Add(new Legend());
            chart2.Series.Add(GetValues(12, context.GetSpecific(2, 12, "Finished"), "Finished"));
            chart2.Legends.Add(new Legend());
            chart2.Series.Add(GetValues(12, context.GetSpecific(2, 12, "Canceled"), "Canceled"));
        }
        private void ContractManagerForm_Load(object sender, EventArgs e)
        {
            context = new StrategyContextManager(new StrategyServiceManager());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            bs = context.Get();
            foreach (IDataRecord dr in bs.List)
            {
                ServiceType_cbx.Items.Add(dr[0]);
            }
            Services_dgv.DataSource = bs;
            SetService();
            context = new StrategyContextManager(new StrategyContractManager());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            bs = context.Get();
            foreach (IDataRecord dr in bs.List)
            {
                ContractType1_cbx.Items.Add(dr[0]);
                ContractType2_cbx.Items.Add(dr[0]);
                contractType_cbx.Items.Add(dr[0]);
            }
            setContractStats();
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
            chart2.Series.Clear();
            chart2.Series.Add(GetValues(int.Parse(Months2_num.Value.ToString()), context.GetSpecific(ContractType2_cbx.SelectedIndex + 1, int.Parse(Months2_num.Value.ToString()), "Finished"), "Finished"));
            chart2.Series.Add(GetValues(int.Parse(Months2_num.Value.ToString()), context.GetSpecific(ContractType2_cbx.SelectedIndex + 1, int.Parse(Months2_num.Value.ToString()), "Canceled"), "Canceled"));
        }

        private void months1_num_ValueChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add(GetValues(int.Parse(months1_num.Value.ToString()), context.GetSpecific(ContractType1_cbx.SelectedIndex+1, int.Parse(months1_num.Value.ToString()), "Finished"), "Finished"));
            chart1.Series.Add(GetValues(int.Parse(months1_num.Value.ToString()), context.GetSpecific(ContractType1_cbx.SelectedIndex+1, int.Parse(months1_num.Value.ToString()), "Canceled"), "Canceled"));
        }

        private void ContractType2_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart2.Series.Add(GetValues(int.Parse(Months2_num.Value.ToString()), context.GetSpecific(ContractType2_cbx.SelectedIndex+1, int.Parse(Months2_num.Value.ToString()), "Finished"), "Finished"));
            chart2.Series.Add(GetValues(int.Parse(Months2_num.Value.ToString()), context.GetSpecific(ContractType2_cbx.SelectedIndex+1, int.Parse(Months2_num.Value.ToString()), "Canceled"), "Canceled"));
        }

        private void ContractType1_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add(GetValues(int.Parse(months1_num.Value.ToString()), context.GetSpecific(ContractType1_cbx.SelectedIndex + 1, int.Parse(months1_num.Value.ToString()), "Finished"),"Finished"));
            chart1.Series.Add(GetValues(int.Parse(months1_num.Value.ToString()), context.GetSpecific(ContractType1_cbx.SelectedIndex + 1, int.Parse(months1_num.Value.ToString()), "Canceled"), "Canceled"));
        }

        private void ContractManagement_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(ContractManagement_tc.SelectedIndex.ToString());
            if(ContractManagement_tc.SelectedIndex == 1)
            {
                context = new StrategyContextManager(new StrategyServiceManager());
                context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                SetService();
            }
            else if(ContractManagement_tc.SelectedIndex == 2)
            {
                context = new StrategyContextManager(new StrategyContractManager());
                context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                SetContract();
            }
            else
            {
                context = new StrategyContextManager(new StrategyContractManager());
                context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                setContractStats();
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
            List<EntityService> services = new List<EntityService>();
            foreach(DataGridViewRow r in contract_services_dgv.Rows)
            {
                services.Add(new EntityService(int.Parse(r.Cells[1].Value.ToString()), r.Cells[0].Value.ToString()));
            }
            context.Update(new EntityContract(contractId, sla_txt.Text, (int)durationC_num.Value, (float)priceC_num.Value, (int)priorityC_num.Value, availability, services));
        }

        private void crateC_btn_Click(object sender, EventArgs e)
        {
            List<EntityService> services = new List<EntityService>();
            foreach (DataGridViewRow r in contract_services_dgv.Rows)
            {
                services.Add(new EntityService(int.Parse(r.Cells[1].Value.ToString()), r.Cells[0].Value.ToString()));
            }
            context.Create(new EntityContract(contractId, sla_txt.Text, (int)durationC_num.Value, (float)priceC_num.Value, (int)priorityC_num.Value, availability, services));
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
    }
}
