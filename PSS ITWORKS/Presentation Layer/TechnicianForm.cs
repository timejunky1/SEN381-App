using PSS_ITWORKS.ConstantData;
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.LogicLayer.StrategyMethod;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PSS_ITWORKS.ConstantData;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class Technician : Form
    {
        Scheduler scheduler = new Scheduler();
        StrategyContextManager context;
        Dashboard dashboard;
        EntityEmployee technician;
        private EntityJob job;
        int technicianId;
        int jobId;
        LoginController.UserInfo userInfo;
        string connString = SystemData.GetConString();
        public Technician(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.userInfo = userInfo;
            technicianId = userInfo.ID;
        }

        void LoadJobId()
        {
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(connString);
            List<IEntity> list = context.Get();
            List<int> ids = new List<int>();
            foreach (IEntity entity in list)
            {
                EntityJob job = entity as EntityJob;
                List<EntityEmployee> emp = job.GetEmployees();
                foreach (EntityEmployee employee in emp)
                {
                    if(employee.GetID() == technicianId)
                    {
                        ids.Add(job.GetID());
                    }
                }
            }
            for (int i = 0; i < ids.Count; i++)
            {
                JobSearch_cbx.Items.Add(ids[i]);
            }
        }

        private void Technician_Load(object sender, EventArgs e)
        {
            LoadJobId();
            context = new StrategyContextManager(new StrategyTechnician());
            context.Connect(connString);
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
            technician = context.Get(technicianId) as EntityEmployee;
            MessageBox.Show($"job count = {technician.GetJobs().Count}");
            scheduler.SetJobs(technician.GetJobs());
            DateTime date = DateTime.Now.AddDays(1);
            scheduler.addJob(new EntityJob(1, 1, 1, date, date.AddHours(2), "In Process", "Notes"));
            scheduler.GetSchedule(21,14, taskList_dgv);
            scheduler.GetSchedule(7,0, Schedule_dgv);

            foreach (EntityJob job in technician.GetJobs())
            {
                if (job.GetStatus() == "In Process")
                {
                    JobId_cmb.Items.Add(job.GetId());
                }
                
            }
        }
       
        
        private void submitUpdate_btn_Click(object sender, EventArgs e)
        {
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(connString);
            if (status_cbx.Text != null && jobNotes_rtb.Text.Length <= 255)
            {
                context.Update(new EntityJob(int.Parse(JobSearch_cbx.SelectedItem.ToString()), job.GetClientId() ,job.GetServiceId() ,job.GetTimeBegin() ,job.GetTimeEnd(), status_cbx.Text ,jobNotes_rtb.Text));
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

        void LoadDetails(EntityJob job)
        {
            this.job = job;
            //jobID_txt.Text = jobId.ToString();
            //Change stratagy to clientManagement
            context = new StrategyContextManager(new StrategyClientManager());
            context.Connect(connString);
            clientDetails_dgv.DataSource = context.Get(job.GetClientId());
            //Change stratagy to ServiceManagement
            
            context = new StrategyContextManager(new StrategyServiceManager());
            context.Connect(connString);
            serviceOverview_dgv.DataSource = context.Get(job.GetServiceId());
            status_cbx.Text = job.GetStatus();
            jobNotes_rtb.Text = job.GetNotes();
            Technical_tc.SelectedIndex = 2;
            
            
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
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
            int jID = int.Parse(JobSearch_cbx.SelectedItem.ToString());
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(connString);
            IEntity job = context.Get(jID);
            EntityJob j = job as EntityJob;
            string notes = j.GetNotes();
            jobNotes_rtb.Text = notes;
        }
    }
}
