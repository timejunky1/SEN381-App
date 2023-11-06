using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class CallForm : Form
    {
        private Dashboard dashboard;
        public CallForm(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void CallForm_Load(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();

        }

        private void PSS_img_Click(object sender, EventArgs e)
        {

        }
    }
}
