using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.LogicLayer.StrategyMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class Technician : Form
    {
        StrategyContextManager context;
        int technicianId = 2;
        public Technician()
        {
            InitializeComponent();
            
        }

        private void Technician_Load(object sender, EventArgs e)
        {
            context = new StrategyContextManager(new StratagyTechnician());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            taskList_dgv.DataSource = context.Get(technicianId);
            serviceOverview_dgv.DataSource = context.GetSpecific1("");
            clientDetails_dgv.DataSource = context.GetSpecific2("");
            status_cbx.Items.Clear();
            status_cbx.Items.Add("Finished");
            status_cbx.Items.Add("Canceled");
            Schedule_dgv.ColumnCount = 16;
            Schedule_dgv.RowCount = 7;
            Schedule_dgv.Columns[0].HeaderText = "8:00";
            Schedule_dgv.Columns[1].HeaderText = "8:30";
            Schedule_dgv.Columns[2].HeaderText = "9:00";
            Schedule_dgv.Columns[3].HeaderText = "9:30";
            Schedule_dgv.Columns[4].HeaderText = "10:00";
            Schedule_dgv.Columns[5].HeaderText = "10:30";
            Schedule_dgv.Columns[6].HeaderText = "11:00";
            Schedule_dgv.Columns[7].HeaderText = "11:30";
            Schedule_dgv.Columns[8].HeaderText = "12:00";
            Schedule_dgv.Columns[9].HeaderText = "12:30";
            Schedule_dgv.Columns[10].HeaderText = "13:00";
            Schedule_dgv.Columns[11].HeaderText = "13:30";
            Schedule_dgv.Columns[12].HeaderText = "14:00";
            Schedule_dgv.Columns[13].HeaderText = "14:30";
            Schedule_dgv.Columns[14].HeaderText = "15:00";
            Schedule_dgv.Columns[15].HeaderText = "15:30";
            LoadSchedule();
        }

        void LoadSchedule()
        {
            int nr = 0;
            int s = 800;
            int e = 1600;
            int n = 0;
            int r = 0;
            int maxDay = 7;
            BindingSource bs = context.GetSpecific1(technicianId);
            foreach (IDataRecord dr in bs.List)
            {
                n = 0;
                TimeSpan ts = DateTime.Parse(dr[5].ToString()) - (DateTime.Now.Add(new TimeSpan(-(DateTime.Now.Hour-8),0,0)));
                r = ts.Days;
                if (r > maxDay)
                {
                    continue;
                }
                int timeStart = DateTime.Parse(dr[5].ToString()).Hour * 100 + (int)(DateTime.Parse(dr[5].ToString()).Minute/60 *100);
                int timeEnd = DateTime.Parse(dr[6].ToString()).Hour * 100 + (int)(DateTime.Parse(dr[6].ToString()).Minute / 60 * 100);
                MessageBox.Show(r.ToString());
                for (int i = s; i < e; i+=50)
                {
                    if(timeEnd < i)
                    {
                        break;
                    }
                    if (timeStart < i+50)
                    {
                        Schedule_dgv.Rows[r].Cells[n].Value = dr[0].ToString()+","+dr[2].ToString()+","+dr[4].ToString();
                        Schedule_dgv.Rows[r].Cells[n].Style.ForeColor = Color.White;
                        Schedule_dgv.Rows[r].Cells[n].Style.BackColor = Color.Green;
                    }
                    n++;
                }
            }
        }
        private void submitUpdate_btn_Click(object sender, EventArgs e)
        {
            context.Update(new EntityJob(int.Parse(jobID_txt.Text), jobNotes_rtb.Text, status_cbx.Text));
        }

        private void Schedule_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Schedule_dgv[e.ColumnIndex, e.RowIndex].Value == null)
            {
                return;
            }
            LoadDetails(Schedule_dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        void LoadDetails(string s)
        {
           string[] details =  s.Split(',');
            jobID_txt.Text = details[0];
            clientDetails_dgv.DataSource = context.GetSpecific1(details[1]);
            serviceOverview_dgv.DataSource = context.GetSpecific2(details[2]);
        }
    }
}
