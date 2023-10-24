using PSS_ITWORKS.Presentation_Layer;
using System.Windows.Forms;

namespace PSS_ITWORKS

{
    public class  FactoryCAdminDetails : FactoryIUser
    {
        private LoginController loginController;

        public FactoryCAdminDetails(LoginController loginController)
        {
            this.loginController = loginController;
        }
        public void ShowUserInterface(LogIn loginForm)
        {
            string name = loginController.Name;
            string surname = loginController.Surname;
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            loginForm.Close();
        }

    }
}