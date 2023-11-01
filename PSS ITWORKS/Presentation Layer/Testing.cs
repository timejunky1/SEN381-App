using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.LogicLayer.StrategyMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class Testing : Form
    {
        StrategyContextManager context;
        IEntity entity;
        int id1 = 0;
        int id2 = 0;
        string filter1 = "";
        string filter2 = "";
        BindingSource bindingSource;
        List<EntityService> services;
        List<EntityEmployee> employees;
        public Testing()
        {
            InitializeComponent();
            Method_cmb.Items.Add("Create");
            Method_cmb.Items.Add("Get");
            Method_cmb.Items.Add("Update");
            Method_cmb.Items.Add("Delete");
            Method_cmb.Items.Add("GetSpecific");
            Method_cmb.Items.Add("GetByID");

            Strategy_cmb.Items.Add("Client");
            Strategy_cmb.Items.Add("CallManaagement");
            Strategy_cmb.Items.Add("ClientManagement");
            Strategy_cmb.Items.Add("ContractManagement");
            Strategy_cmb.Items.Add("ServiceManagement");
            Strategy_cmb.Items.Add("JobManagement");
            Strategy_cmb.Items.Add("UserManagement");
            Strategy_cmb.Items.Add("Technician");

        }

        public void SetStrategy(int option)
        {
            switch (option)
            {
                case 0:
                    context = new StrategyContextManager(new StrategyClient());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new EntityUser(id1, "test", "test", "test", 1, 1, "test", "test", "test", "test", "test", "test", DateTime.Now, "Client");
                    break;
                case 1:
                    context = new StrategyContextManager(new StrategyCallManagement());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new EntityJob(id1, 1, 1, DateTime.Now, DateTime.Now, "test", "test", employees);
                    break;
                case 2:
                    context = new StrategyContextManager(new StrategyClientManager());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new EntityUser(id1, "test", "test", "test", 1, 1, "test", "test", "test", "test", "test", "test", DateTime.Now, "Client");
                    break;
                case 3:
                    context = new StrategyContextManager(new StrategyContractManager());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new EntityContract(id1, "SLA", 1, 200, 1, "test", services);
                    break;
                case 4:
                    context = new StrategyContextManager(new StrategyServiceManager());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new EntityService(id1, "test", 1, 1, 1, "test");
                    break;
                case 5:
                    context = new StrategyContextManager(new StrategyJobManager());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new  EntityJob(id1,1,1,DateTime.Now,DateTime.Now,"test", "test", employees);
                    break;
                case 6:
                    context = new StrategyContextManager(new StratagyEmployeeManagement());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new EntityUser(id1, "test", "test", "test", 1, 1, "test", "test", "test", "test", "test", "testEmail", DateTime.Now, "Technician");
                    break;
                case 7:
                    context = new StrategyContextManager(new StrategyTechnician());
                    context.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
                    entity = new EntityJob(id1, 1, 1, DateTime.Now, DateTime.Now, "test", "test");
                    break;
                default:
                    MessageBox.Show("No Selected index");
                    break;


            }
        }

        public void ExecuteMethod(int option)
        {
            switch(option)
            {
                case 0:
                    context.Create(entity);
                    break;
                case 1:
                    bindingSource = context.Get();
                    break;  
                case 2:
                    context.Update(entity);
                    break;
                case 3:
                    context.Delete(id1,filter1);
                    break;
                case 4:
                    bindingSource = context.GetSpecific(id1, id2, filter1, filter2);
                    break;
                case 5:
                    bindingSource = context.Get(id1);
                    break;
                default:
                    MessageBox.Show("No Selected index");
                    break;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int strategy = Strategy_cmb.SelectedIndex;
            int method = Method_cmb.SelectedIndex;
            id1 = (int)id1_num.Value;
            id2 = (int)id2_num.Value;
            services = new List<EntityService> {
                new EntityService(id2, "test", 1, 1, 1, "test"),
                new EntityService(id2+1, "test", 1, 1, 1, "test"),
                new EntityService(id2+2, "test", 1, 1, 1, "test"),
                new EntityService(id2+3, "test", 1, 1, 1, "test")
            };
            employees = new List<EntityEmployee> {
                new EntityUser(id2, "test", "test", "test","test","0123456789"),
                new EntityUser(id2+1, "test", "test", "test","test","0123456789"),
                new EntityUser(id2+2, "test", "test", "test","test","0123456789"),
                new EntityUser(id2+3, "test", "test", "test","test","0123456789")
            };
            filter1 = filter_txt.Text;
            filter2 = dateTimePicker1.Text;
            SetStrategy(strategy);
            ExecuteMethod(method);
            Test_dgv.DataSource = bindingSource;
        }
    }
}
