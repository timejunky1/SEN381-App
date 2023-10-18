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
        protected StrategyContextManager cm = new StrategyContextManager(new StrategyUserManager());
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cm.Get();
            cm = new StrategyContextManager(new StrategyClientManager());
            cm.Get();
        }

        
    }
}
