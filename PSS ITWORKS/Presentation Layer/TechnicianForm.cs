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
        Dashboard dashboard;
        int technicianId = 2;
        int jobId = 0;
        public Technician(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void Technician_Load(object sender, EventArgs e)
        {
            context = new StrategyContextManager(new StrategyTechnician());
            context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            BindingSource bs = context.GetSpecific2(jobId);
            LoadDetails(bs);
            jobID_txt.Text = "0";
            status_cbx.Items.Clear();
            status_cbx.Items.Add("Finished");
            status_cbx.Items.Add("Canceled");
            Schedule_dgv.ColumnCount = 17;
            Schedule_dgv.Columns[1].HeaderText = "8:00";
            Schedule_dgv.Columns[2].HeaderText = "8:30";
            Schedule_dgv.Columns[3].HeaderText = "9:00";
            Schedule_dgv.Columns[4].HeaderText = "9:30";
            Schedule_dgv.Columns[5].HeaderText = "10:00";
            Schedule_dgv.Columns[6].HeaderText = "10:30";
            Schedule_dgv.Columns[7].HeaderText = "11:00";
            Schedule_dgv.Columns[8].HeaderText = "11:30";
            Schedule_dgv.Columns[9].HeaderText = "12:00";
            Schedule_dgv.Columns[10].HeaderText = "12:30";
            Schedule_dgv.Columns[11].HeaderText = "13:00";
            Schedule_dgv.Columns[12].HeaderText = "13:30";
            Schedule_dgv.Columns[13].HeaderText = "14:00";
            Schedule_dgv.Columns[14].HeaderText = "14:30";
            Schedule_dgv.Columns[15].HeaderText = "15:00";
            Schedule_dgv.Columns[16].HeaderText = "15:30";

            taskList_dgv.ColumnCount = 16;
            taskList_dgv.Columns[0].HeaderText = "8:00";
            taskList_dgv.Columns[1].HeaderText = "8:30";
            taskList_dgv.Columns[2].HeaderText = "9:00";
            taskList_dgv.Columns[3].HeaderText = "9:30";
            taskList_dgv.Columns[4].HeaderText = "10:00";
            taskList_dgv.Columns[5].HeaderText = "10:30";
            taskList_dgv.Columns[6].HeaderText = "11:00";
            taskList_dgv.Columns[7].HeaderText = "11:30";
            taskList_dgv.Columns[8].HeaderText = "12:00";
            taskList_dgv.Columns[9].HeaderText = "12:30";
            taskList_dgv.Columns[10].HeaderText = "13:00";
            taskList_dgv.Columns[11].HeaderText = "13:30";
            taskList_dgv.Columns[12].HeaderText = "14:00";
            taskList_dgv.Columns[13].HeaderText = "14:30";
            taskList_dgv.Columns[14].HeaderText = "15:00";
            taskList_dgv.Columns[15].HeaderText = "15:30";

            LoadSchedule(21,14, context.Get(technicianId), taskList_dgv);
            LoadSchedule(7,0, context.GetSpecific1(technicianId), Schedule_dgv);
        }
       
        void LoadSchedule(int maxDay, int Offset, BindingSource bs, DataGridView dgv)
        {
            dgv.RowCount = maxDay;
            int nr = 0;
            int s = 800;
            int e = 1600;
            int n = 0;
            int r = 0;
            foreach (IDataRecord dr in bs.List)
            {
                try
                {
                    n = 0;
                    TimeSpan ts = DateTime.Parse(dr[5].ToString()) - (DateTime.Now.Add(new TimeSpan(-(DateTime.Now.Hour - 8), 0, 0)));
                    r = ts.Days + Offset;
                    if (r > maxDay || r<0)
                    {
                        continue;
                    }
                    int timeStart = DateTime.Parse(dr[5].ToString()).Hour * 100 + (int)(DateTime.Parse(dr[5].ToString()).Minute / 60 * 100);
                    int timeEnd = DateTime.Parse(dr[6].ToString()).Hour * 100 + (int)(DateTime.Parse(dr[6].ToString()).Minute / 60 * 100);
                    MessageBox.Show(r.ToString());
                    for (int i = s; i < e; i += 50)
                    {
                        if (timeEnd < i)
                        {
                            break;
                        }
                        if (timeStart < i + 50)
                        {
                            dgv.Rows[r].Cells[0].Value = DateTime.Parse(dr[5].ToString()).DayOfWeek;
                            dgv.Rows[r].Cells[0].Style.BackColor = Color.Blue;
                            dgv.Rows[r].Cells[0].Style.ForeColor = Color.White;
                            dgv.Rows[r].Cells[n].Value = dr[0].ToString();
                            dgv.Rows[r].Cells[n].Style.ForeColor = Color.White;
                            dgv.Rows[r].Cells[n].Style.BackColor = Color.Green;
                        }
                        n++;
                    }
                }
                catch(Exception ex)
                {
                    ErrorHandler.DisplayError(ex);
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
            try
            {
                jobId = int.Parse(Schedule_dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
                BindingSource bs = context.GetSpecific2(jobId);
                LoadDetails(bs);
            }
            catch
            {
                ErrorHandler.DisplayError("Please double Click on an Appropriate Slot");
            }
        }

        void LoadDetails(BindingSource bs)
        {
            jobID_txt.Text = jobId.ToString();
            foreach (IDataRecord dr in bs.List)
            {
                MessageBox.Show(dr[0].ToString() + ", " + dr[1].ToString() + ", " + dr[2].ToString());
                clientDetails_dgv.DataSource = context.GetSpecific(int.Parse(dr[1].ToString()));
                serviceOverview_dgv.DataSource = context.GetSpecific1(dr[2].ToString());
                status_cbx.Text = dr[5].ToString();
                jobNotes_rtb.Text = dr[6].ToString();
            }
            Technical_tc.SelectedIndex = 2;
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }
    }
}
