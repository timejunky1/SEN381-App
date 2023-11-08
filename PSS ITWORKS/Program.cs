using PSS_ITWORKS.Presentation_Layer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LogIn login = new LogIn();
            //login.Show();
            LoginController.UserInfo info = new LoginController.UserInfo();
            info.ID = 1;
            info.Name = "Test";
            info.Surname = "Test";
            ContractManagerForm testing = new ContractManagerForm(null, info);
            testing.Show();
            Application.Run();
        }
    }
}
