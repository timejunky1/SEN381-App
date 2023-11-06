﻿using PSS_ITWORKS.LogicLayer;
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
            cm = new StrategyContextManager(new StrategyJobManager());
            cm.Connect(@"Data Source=DESKTOP-TBBSO02\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            
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
    }
}
