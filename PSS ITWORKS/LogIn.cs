using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public partial class LogIn : Form
    {
        StrategyContextManager context = new StrategyContextManager();
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FactoryUserFactory uf = new FactoryUserFactory();
            //FactoryIUser user = uf.GetUserRole("Billabong", "password");
            //this.Hide();
            //user.ShowUserInterface();

            context.SetStratagy(new StrategyCServiceManager());
            context.ExecuteStrategy("add");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.ExecuteStrategy("sort");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.ExecuteStrategy("webjfveaj");
        }
    }
}
