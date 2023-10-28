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

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ContractManagerForm : Form
    {
        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Des" };
        StrategyContextManager context;
        public ContractManagerForm()
        {
            InitializeComponent();
            context = new StrategyContextManager(new StrategyContractManager());
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
        private void ContractManagerForm_Load(object sender, EventArgs e)
        {
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            BindingSource bs = context.Get();
            foreach(IDataRecord dr in bs.List)
            {
                ContractType1_cbx.Items.Add(dr[0]);
                ContractType2_cbx.Items.Add(dr[0]);
            }
            ContractType1_cbx.SelectedIndex = 0;
            ContractType1_cbx.SelectedIndex = 1;
            chart1.Legends.Clear();
            chart1.Series.Clear();
            chart1.Legends.Add(new Legend());
            chart1.Series.Add(GetValues(12, context.GetSpecific(ContractType1_cbx.SelectedIndex+1, 12, "Finished"), "Finished"));
            chart1.Legends.Add(new Legend());
            chart1.Series.Add(GetValues(12, context.GetSpecific(ContractType1_cbx.SelectedIndex+1, 12, "Canceled"), "Canceled"));
            chart2.Legends.Clear();
            chart2.Series.Clear();
            chart2.Legends.Add(new Legend());
            chart2.Series.Add(GetValues(12, context.GetSpecific(2, 12, "Finished"), "Finished"));
            chart2.Legends.Add(new Legend());
            chart2.Series.Add(GetValues(12, context.GetSpecific(2, 12, "Canceled"), "Canceled"));
        }

        private void ServiceType_lbl_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void UpdateService_btn_Click(object sender, EventArgs e)
        {

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
            if(ContractManagement_tc.SelectedIndex == 1)
            {
                context = new StrategyContextManager(new StrategyServiceManager());
                context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                Services_dgv.DataSource = context.Get();
            }
            else
            {
                context = new StrategyContextManager(new StrategyContractManager());
                context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            }
        }
    }
}
