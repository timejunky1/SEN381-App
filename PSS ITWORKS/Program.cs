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
            LoginController.UserInfo info = new LoginController.UserInfo();
            info.Name = "Test";
            info.Surname = "Test";
            info.ID = 1;
            ContractManagerForm test = new ContractManagerForm(null, info);
            Application.Run();
            
            
        }
    }
}
