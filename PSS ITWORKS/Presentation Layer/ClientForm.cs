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
    public partial class ClientForm : Form
    {
        private Dashboard dashboard;

        public ClientForm(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }



        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }
    }
}
