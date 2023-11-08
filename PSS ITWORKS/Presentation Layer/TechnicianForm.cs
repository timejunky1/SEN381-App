using PSS_ITWORKS.ConstantData;
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.LogicLayer.StrategyMethod;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class Technician : Form
    {
        Scheduler scheduler;
        StrategyContextManager context;
        Dashboard dashboard;
        EntityEmployee technician;
        EntityJob job;
        int technicianId;
        int jobId = 0;
        LoginController.UserInfo userInfo;
        string connString = SystemData.GetConString();
        public Technician(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.userInfo = userInfo;
            technicianId = userInfo.ID;
            welcome_lbl.Text = $"Welcome Back {userInfo.Name} {userInfo.Surname} <Technician>";
        }

        private void Technician_Load(object sender, EventArgs e)
        {
            scheduler = new Scheduler();
            context = new StrategyContextManager(new StrategyTechnician());
            context.Connect(connString);
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

            taskList_dgv.ColumnCount = 17;
            taskList_dgv.Columns[1].HeaderText = "8:00";
            taskList_dgv.Columns[2].HeaderText = "8:30";
            taskList_dgv.Columns[3].HeaderText = "9:00";
            taskList_dgv.Columns[4].HeaderText = "9:30";
            taskList_dgv.Columns[5].HeaderText = "10:00";
            taskList_dgv.Columns[6].HeaderText = "10:30";
            taskList_dgv.Columns[7].HeaderText = "11:00";
            taskList_dgv.Columns[8].HeaderText = "11:30";
            taskList_dgv.Columns[9].HeaderText = "12:00";
            taskList_dgv.Columns[10].HeaderText = "12:30";
            taskList_dgv.Columns[11].HeaderText = "13:00";
            taskList_dgv.Columns[12].HeaderText = "13:30";
            taskList_dgv.Columns[13].HeaderText = "14:00";
            taskList_dgv.Columns[14].HeaderText = "14:30";
            taskList_dgv.Columns[15].HeaderText = "15:00";
            taskList_dgv.Columns[16].HeaderText = "15:30";
            technician = context.Get(technicianId) as EntityEmployee;
            scheduler.SetJobs(technician.GetJobs());
            DateTime date = DateTime.Now;
            scheduler.addJob(new EntityJob(0,1,1,date, date.AddHours(1), "In Process", "Notes"));
            date = DateTime.Now.AddDays(-2);
            scheduler.addJob(new EntityJob(0, 1, 1, date, date.AddHours(1), "In Process", "Notes"));
            date = DateTime.Now.AddDays(+2);
            scheduler.addJob(new EntityJob(0,1,1,date, date.AddHours(1), "In Process", "Notes"));
            scheduler.GetSchedule(21,14, taskList_dgv);
            scheduler.SetJobs(technician.GetJobs());
            scheduler.GetSchedule(7,0, Schedule_dgv);

            foreach (EntityJob job in technician.GetJobs())
            {
                if (job.GetStatus() == "In Process")
                {
                    JobId_cmb.Items.Add(job.GetId());
                }    
            }
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(connString);
            LoadDetails(context.Get(20) as EntityJob);
        }
       
        private void submitUpdate_btn_Click(object sender, EventArgs e)
        {
            if (status_cbx.Text != null && jobNotes_rtb.Text.Length <= 255)
            {
                context.Update(new EntityJob(int.Parse(jobID_txt.Text), job.GetClientId() ,job.GetServiceId() ,job.GetTimeBegin() ,job.GetTimeEnd(), status_cbx.Text ,jobNotes_rtb.Text));
            }
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
                foreach(EntityJob job in technician.GetJobs())
                {
                    if(job.GetId() == jobId)
                    {
                        LoadDetails(job);
                    }
                }
            }
            catch
            {
                ErrorHandler.DisplayError("Please double Click on an Appropriate Slot");
            }
        }

        void LoadDetails(EntityJob j)
        {
            this.job = j;
            jobID_txt.Text = jobId.ToString();
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(connString);
            EntityClient client = context.Get(job.GetClientId()) as EntityClient;
            name_txt.Text = client.GetName();
            surname_txt.Text = client.GetSurname();
            number_txt.Text = client.GetStreetNumber().ToString();
            street_txt.Text = client.GetStreetName();
            city_txt.Text = client.GetCity();
            phone_txt.Text = client.GetPhone();
            context = new StrategyContextManager(new StrategyServiceManager());
            context.Connect(connString);
            EntityService service = context.Get(job.GetServiceId()) as EntityService;
            title_txt.Text = service.GetTitle();
            cost_txt.Text = service.GetCost().ToString();
            duration_txt.Text = service.GetDuration().ToString();
            status_cbx.Text = job.GetStatus();
            jobNotes_rtb.Text = job.GetNotes();
            Technical_tc.SelectedIndex = 2; 
        }

        private void filterDetails_btn_Click(object sender, EventArgs e)
        {
            foreach (EntityJob job in technician.GetJobs())
            {
                if (job.GetId() == int.Parse(JobId_cmb.Text.ToString()))
                {
                    LoadDetails(job);
                }
            }
        }

        private void searchJob_btn_Click(object sender, EventArgs e)
        {
            foreach (EntityJob job in technician.GetJobs())
            {
                if (job.GetId() == int.Parse(jobID_txt.Text.ToString()))
                {
                    LoadDetails(job);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }
    }
}
