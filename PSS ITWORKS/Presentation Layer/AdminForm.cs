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
    public partial class AdminForm : Form
    {
        protected StrategyContextManager cm;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cm = new StrategyContextManager(new StrategyClientManager());
            cm.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS; Integrated Security=True");
            Users_dgv.DataSource = cm.Get();
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
