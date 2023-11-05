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
        string conn = @"Data Source=DESKTOP-TBBSO02\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True";

        public int GetTechID(string Name)
        {
            int ID = 0;
            context = new StrategyContextManager(new StratagyEmployeeManagement());
            context.Connect(conn);

            List<IEntity> entities = context.Get();
            foreach (IEntity entity in entities)
            {
                EntityEmployee employee = entity as EntityEmployee;
                if (employee.GetName() == Name)
                {
                    ID = employee.GetID();
                }
            }
            return ID;
        }

        void SearchJobByTechLoad(string techName)
        {
            int techId = GetTechID(techName); 

            context = new StrategyContextManager(new StrategyJobManager());
            context.Connect(conn);

            List<IEntity> entities = context.Get();
            List<EntityJob> jobs = new List<EntityJob>();
            foreach (IEntity entity in entities)
            {
                EntityJob job = entity as EntityJob;
                List<EntityEmployee> emp = job.GetEmployees();

                foreach (EntityEmployee employee in emp)
                {
                    if (employee.GetID() == techId)
                    {
                        jobs.Add(job);
                    }
                }
            }
            Technician_dgv.DataSource = jobs;
        }
        private Dashboard dashboard;
        StrategyContextManager cm;
        AssignmentForm af = new AssignmentForm();
        public ServiceManagerForm(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            ModifyJobs_pnl.Visible = false;

            cm = new StrategyContextManager(new StrategyJobManager());
            cm.Connect(@"Data Source=DESKTOP-TBBSO02\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            Request_dgv.DataSource = cm.GetSpecific();
            AssignmentSchedule_dgv.DataSource = cm.Get();
            //List<IEntity> list = cm.Get();
            List<IEntity> list = new List<IEntity>();
            AssignmentSchedule_dgv.DataSource = list;
            IEntity entity = cm.Get(3);
            EntityJob job = entity as EntityJob;
            BindingSource bs = new BindingSource();
            List<EntityJob> jobs = new List<EntityJob>();

            foreach (IEntity ent in list)
            {
                EntityJob j = ent as EntityJob;
                if (j.GetStatus() == "In Process")
                {
                    jobs.Add(j);
                }
            }
        }

        private void Filter_txt_TextChanged(object sender, EventArgs e)
        {

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

        private void Jobs_tp_Click(object sender, EventArgs e)
        {

        }

        private void AssignmentFilter_btn_Click(object sender, EventArgs e)
        {

        }

        private void TechFilter_btn_Click(object sender, EventArgs e)
        {
            //// Figure uit wat hier display word en wat moet gesearch word

        }

        private void JobsFilter_btn_Click(object sender, EventArgs e)
        {
            ModifyJobs_pnl.Visible = false;
            string techName = TechFilter_txt.Text;

            SearchJobByTechLoad(techName);
        }

        private void ModifyJobs_btn_Click(object sender, EventArgs e)
        {
            context = new StrategyContextManager(new StrategyJobManager());
            EntityJob job = Technician_dgv.SelectedRows[0];

        }
    }
}
