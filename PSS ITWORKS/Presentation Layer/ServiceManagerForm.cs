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

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ServiceManagerForm : Form
    {
        StrategyContextManager context;
        string conn = SystemData.GetConString();
        public int jobID;
        public int clientID;
        public int techID;
        List<EntityCall> CallList = new List<EntityCall>();
        


        private Dashboard dashboard;
        StrategyContextManager cm;
        AssignmentForm af = new AssignmentForm();
        LoginController.UserInfo userInfo;
        public ServiceManagerForm(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.userInfo = userInfo;
            welcome_lbl.Text = $"Welcome Back {userInfo.Name} {userInfo.Surname} <Service Manager>";
            Assignement_dtp.Value = DateTime.Now;
        }
        public int GetTechID(string Name)
        {
            
            context = new StrategyContextManager(new StratagyEmployeeManagement());
            context.Connect(conn);

            List<IEntity> entities = context.Get();
            foreach (IEntity entity in entities)
            {
               // MessageBox.Show(Name + " techname in GetTechID class");
                EntityEmployee employee = entity as EntityEmployee;
                if (employee.GetName() == Name)
                {
                    techID = employee.GetID();
                    
                }
            }
            MessageBox.Show(techID.ToString() + " techID in GetTechID class");
            return techID;
        }

        public List<IEntity>SearchJobByTechLoad(string techName)
        {
            int techId = GetTechID(techName);
            MessageBox.Show(techId.ToString() + " techID");

            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);

            List<IEntity> entities = context.Get();
            List<IEntity> jobs = new List<IEntity>();
            foreach (IEntity entity in entities)
            {
                EntityJob job = entity as EntityJob;
                List<EntityEmployee> emp = job.GetEmployees();
                //MessageBox.Show("emp list count = " + emp.Count.ToString());
                foreach (EntityEmployee employee in emp)
                {
                    if (employee.GetID() == techId)
                    {
                        jobs.Add(job);
                    }
                }
            }
            MessageBox.Show("SearchJobByTechLoad list count = " + jobs.Count.ToString());
            return jobs;
        }
        public List<IEntity> GetJobsByID(int serviceID)
        {
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);

            List<IEntity> entities = context.Get();
            List<IEntity> jobs = new List<IEntity>();

            foreach(IEntity entity in entities)
            {
                EntityJob job = entity as EntityJob;
                if (job.GetServiceId() == serviceID)
                {
                    jobs.Add(job);
                }
            }
            return jobs;
        }
        public List<IEntity> GetServices()
        {
            context = new StrategyContextManager(new StrategyServiceManager());
            context.Connect(conn);

            List<IEntity> services = context.Get();

            return services;

        }

        public int GetServiceID(string serviceTitle)
        {
            List<IEntity> services = GetServices();
            int serviceID = 0;
            foreach (IEntity service in services)
            {
                EntityService serviceService = service as EntityService;
                if (serviceService.GetTitle() == serviceTitle)
                {
                    serviceID = serviceService.GetId();
                }
            }
            return serviceID;
        }

        public string GetServiceTitle(int ServiceID)
        {
            string title = "";
            List<IEntity> services = GetServices();
            foreach (IEntity service in services)
            {
                EntityService s = service as EntityService;
                if (s.GetId() == ServiceID)
                {
                    title = s.GetTitle();
                }
            }
            return title;

        }
        void LoadJobID(string techName)
        {
            List<IEntity> jobs = SearchJobByTechLoad(techName);
            foreach (IEntity job in jobs)
            {
                EntityJob j = job as EntityJob;
                UpdateJobID_cbx.Items.Add(j.GetID());
            }

        }
        void LoadServices()
        {
            List<IEntity> services = GetServices();
            foreach(IEntity service in services)
            {
                EntityService s = service as EntityService;
                Service_cbx.Items.Add(s.GetTitle());
            }    

        }
        void LoadStatus()
        {
            status_cbx.Items.Add("Pending");
            status_cbx.Items.Add("In Process");
            status_cbx.Items.Add("Finished");
            status_cbx.Items.Add("Cancelled");
        }
        void LoadTechListBox( int JobId)
        {
            context = new StrategyContextManager(new StratagyEmployeeManagement());
            context.Connect(conn);
            List<IEntity> emp = context.Get();
            List<EntityEmployee> e = new List<EntityEmployee>();
            foreach (IEntity entity in emp)
            {
                EntityEmployee employee = entity as EntityEmployee;
                
                    if(employee.GetRole() == "Technician")
                    {
                        e.Add(employee);
                        ChangeTech_lbx.Items.Add(employee.GetName());
                    }
                
            }

        }

        void SelectTechsInList(int JobId)
        {
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);

            List<IEntity> jobs = context.Get();
            List<EntityEmployee> techs = new List<EntityEmployee>();
            foreach (IEntity entity in jobs)
            {
                EntityJob j = entity as EntityJob;
                if (j.GetId() == JobId)
                {
                    techs = j.GetEmployees();
                }
            }
            for (int i = 0; i < ChangeTech_lbx.Items.Count; i++)
            {
                foreach (IEntity entity in techs)
                    {
                        EntityEmployee emp = entity as EntityEmployee;
                        if (ChangeTech_lbx.Items[5].ToString() == emp.GetName())
                        {
                            ChangeTech_lbx.SetSelected(i,true);
                        }
                    }

            }

        }

        public IEntity GetEmployee(int ID)
        {
            context = new StrategyContextManager(new StratagyEmployeeManagement());
            context.Connect(conn);
            List<IEntity> emp = context.Get();
            IEntity techs = null;

            foreach (IEntity entity in emp)
            {
                EntityEmployee employee = entity as EntityEmployee;
                if (employee.GetID() == ID)
                {
                    techs = employee;
                }
            }
            return techs;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            


            ModifyJobs_pnl.Visible = false;
            ChangeTech_lbx.SelectionMode = SelectionMode.MultiSimple;
            DateTime date = Assignement_dtp.Value;
            Request_dgv.ColumnCount = 6;
            AssignmentSchedule_dgv.ColumnCount=6;

            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);
            List<IEntity> entities = context.Get();

            MessageBox.Show(entities.Count.ToString() + "Entities list count");
            List<EntityJob> jobList = new List<EntityJob>();
            List<EntityJob> pending = new List<EntityJob>();
            foreach (IEntity ent in entities)
            {
                EntityJob jobEntity = ent as EntityJob;
                    jobList.Add(jobEntity);
                    AssignmentSchedule_dgv.Rows.Add(jobEntity.GetID(), jobEntity.GetClientId(), jobEntity.GetServiceId(), jobEntity.GetPriotity(), jobEntity.GetStatus(), jobEntity.GetNotes());
                
                    pending.Add(jobEntity);
                    Request_dgv.Rows.Add(jobEntity.GetID(), jobEntity.GetClientId(), jobEntity.GetServiceId(), jobEntity.GetPriotity(), jobEntity.GetStatus(), jobEntity.GetNotes());
                
            }
            MessageBox.Show(jobList.Count.ToString() + " jobListCount");
            MessageBox.Show(pending.Count.ToString() + " pendingListCount");
            //AssignmentSchedule_dgv.DataSource = jobList;
            //Request_dgv.DataSource = pending;
            //Request_dgv.DataSource = context.Get();
            //AssignmentSchedule_dgv.DataSource = context.Get();
            //List<IEntity> list = context.Get();
            //AssignmentSchedule_dgv.DataSource = list;
            //IEntity entity = context.Get(3);
            //EntityJob job = entity as EntityJob;
            //BindingSource bs = new BindingSource();
            //List<EntityJob> jobs = new List<EntityJob>();

            //foreach (IEntity ent in list)
            //{
            //    EntityJob j = ent as EntityJob;
            //    if (j.GetStatus() == "In Process")
            //    {
            //        jobs.Add(j);
            //    }
            //}
        }

        private void assign_btn_Click(object sender, EventArgs e)
        {
            
            af.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();

        }

        private void AssignmentFilter_btn_Click(object sender, EventArgs e)
        {
            string name = Filter_txt.Text;
            Schedule_dgv.ColumnCount = 5;
            if (name == null)
            {
                MessageBox.Show("Please enter name");
                Filter_txt.Focus();
            }
            List<IEntity> list = SearchJobByTechLoad(name);
            foreach (IEntity entity in list)
            {
                EntityJob job = entity as EntityJob;
                Schedule_dgv.Rows.Add(job.GetID(), job.GetServiceId(),job.GetTimeBegin() ,job.GetStatus(), job.GetNotes());
            }

        }

        private void TechFilter_btn_Click(object sender, EventArgs e)
        {
            string serviceTitle = TechFilter_txt.Text;
            Technician_dgv.ColumnCount=5;
            int ServiceId = GetServiceID(serviceTitle);
            if (ServiceId == 0)
            {
                MessageBox.Show("ServiceTitle was not found, please enter correct service title.");
                TechFilter_txt.Clear();
                TechFilter_txt.Focus();
            }
            List<IEntity> job= GetJobsByID(ServiceId);
            foreach (IEntity entity in job)
            {
                EntityJob j = entity as EntityJob;
                Technician_dgv.Rows.Add(j.GetID(), j.GetServiceId(),j.GetTimeBegin(), j.GetTimeEnd(),j.GetStatus(), j.GetNotes());
            }
        }

        private void JobsFilter_btn_Click(object sender, EventArgs e)
        {
            ModifyJobs_pnl.Visible = false;
            string techName = JobsFilter_txt.Text;
            JobsByTech_dgv.ColumnCount = 5;

            List<IEntity> list = SearchJobByTechLoad(techName);
            foreach (IEntity entity in list)
            {
                EntityJob job = entity as EntityJob;
                jobID = job.GetID();
                JobsByTech_dgv.Rows.Add(job.GetID(), job.GetServiceId(), job.GetTimeBegin(), job.GetStatus(), job.GetNotes());
            }
            
        }

        private void ModifyJobs_btn_Click(object sender, EventArgs e)
        {
            string techName = JobsFilter_txt.Text;
            LoadJobID(techName);

            ModifyJobs_pnl.Visible = true;
            UpdateJobID_cbx.SelectedIndex = 0;
            int jID = int.Parse(UpdateJobID_cbx.SelectedItem.ToString());
            string title = "";
            int ServiceID = 1;
            List<IEntity> jobs = GetJobsByID(jID);
            foreach (IEntity entity in jobs)
            {
                EntityJob j = entity as EntityJob;
                CallList = j.GetCalls();
                jobID = j.GetId();
                clientID = j.GetClientId();
                TimeBegin_dtp.Value = j.GetTimeBegin();
                TimeEnd_dtp.Value = j.GetTimeEnd();
                status_cbx.SelectedItem = j.GetStatus();
                ServiceID = j.GetServiceId();
                title = GetServiceTitle(ServiceID);
                Notes_rtb.Text = j.GetNotes();

            }
            
            LoadServices();
            LoadStatus();
            for (int x = 0; x < Service_cbx.Items.Count; x++)
            {
                if (Service_cbx.Items[x].ToString() == title)
                {
                    Service_cbx.SelectedIndex = x;
                }
            }
            
            LoadTechListBox(jobID);

        }

        private void SubmitChanges_btn_Click(object sender, EventArgs e)
        {
            List<IEntity> list = new List<IEntity>();
            List<EntityEmployee> employees = new List<EntityEmployee>();
            string ServiceTitle = Service_cbx.SelectedItem.ToString();
            int serviceID = GetServiceID(ServiceTitle);
            DateTime begin = TimeBegin_dtp.Value;
            DateTime end = TimeEnd_dtp.Value;
            string status = status_cbx.SelectedItem.ToString();
            string notes = Notes_rtb.Text;
           List<string> tech = new List<string>();
            //int selectedI = ChangeTech_lbx
            foreach (int i in ChangeTech_lbx.SelectedIndices)
            {
                tech.Add(ChangeTech_lbx.Items[i].ToString());
            }
            List<int> techID = new List<int>();
            for (int i = 0; i < tech.Count; i++)
            {
                techID.Add(GetTechID(tech[i]));
            }

            for (int k = 0; k< techID.Count; k++)
            {
                list.Add(GetEmployee(techID[k]));
            }

            foreach (IEntity i in list)
            {
                EntityEmployee emp = i as EntityEmployee;
                employees.Add(emp);

            }
            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);
            EntityJob UpdateJob = new EntityJob(jobID, clientID, serviceID, begin, end, status, notes);
            UpdateJob.SetEmployees(employees);
            context.Update(UpdateJob);
            /// 

            ModifyJobs_pnl.Visible = false;

        }

        private void Assignement_dtp_VisibleChanged(object sender, EventArgs e)
        {
            //DateTime date = Assignement_dtp.Value;
            //Request_dgv.ColumnCount = 6;
            //AssignmentSchedule_dgv.ColumnCount = 6;

            //context = new StrategyContextManager(new StrategyJobManager());
            //context.Connect(conn);
            //List<IEntity> entities = context.Get();

            //MessageBox.Show(entities.Count.ToString() + "Entities list count");
            //List<EntityJob> jobList = new List<EntityJob>();
            //List<EntityJob> pending = new List<EntityJob>();
            //foreach (IEntity ent in entities)
            //{
            //    EntityJob jobEntity = ent as EntityJob;
            //    if (jobEntity.GetTimeBegin() == date)
            //    {
            //        jobList.Add(jobEntity);
            //        AssignmentSchedule_dgv.Rows.Add(jobEntity.GetID(), jobEntity.GetClientId(), jobEntity.GetServiceId(), jobEntity.GetPriotity(), jobEntity.GetStatus(), jobEntity.GetNotes());
            //    }
                
            //}
        }

        private void Assignement_dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = Assignement_dtp.Value;
            Request_dgv.ColumnCount = 6;
            AssignmentSchedule_dgv.ColumnCount = 6;

            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);
            List<IEntity> entities = context.Get();

            MessageBox.Show(entities.Count.ToString() + "Entities list count");
            List<EntityJob> jobList = new List<EntityJob>();
            List<EntityJob> pending = new List<EntityJob>();
            foreach (IEntity ent in entities)
            {
                EntityJob jobEntity = ent as EntityJob;
                if (jobEntity.GetTimeBegin() == date)
                {
                    jobList.Add(jobEntity);
                    AssignmentSchedule_dgv.Rows.Add(jobEntity.GetID(), jobEntity.GetClientId(), jobEntity.GetServiceId(), jobEntity.GetPriotity(), jobEntity.GetStatus(), jobEntity.GetNotes());
                }

            }

        }
    }
}
