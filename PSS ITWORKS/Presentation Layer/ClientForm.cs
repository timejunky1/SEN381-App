using PSS_ITWORKS.ConstantData;
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
        LoginController.UserInfo userInfo;
        string connString = SystemData.GetConString();

        public ClientForm(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.userInfo = userInfo;

        }



        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // ClientForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "ClientForm";
        //    this.Load += new System.EventHandler(this.ClientForm_Load);
        //    this.ResumeLayout(false);

        //}

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
