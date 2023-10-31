using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SMSAPI sms = new SMSAPI();
            string number = "+27";
            number = number + textBox1.Text.Substring(1, 9);
            MessageBox.Show(number);
            sms.SendSMS("This is an example SMS from a Twilio account through a C# application", number);
            this.Close();
        }
    }
}
