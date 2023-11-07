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
            LogIn login = new LogIn();
            //login.Show();
            LoginController loginController= new LoginController();
            LoginController.UserInfo userInfo= new LoginController.UserInfo();
            Dashboard dashboard=new Dashboard(loginController, userInfo, login );
            AdminForm admin = new AdminForm(dashboard);
            admin.Show();


            //Testing testing = new Testing();
            //testing.Show();
            Application.Run();
            
            
        }
    }
}
