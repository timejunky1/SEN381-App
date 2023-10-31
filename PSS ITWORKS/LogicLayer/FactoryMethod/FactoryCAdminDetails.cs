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
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            loginForm.Close();
        }

    }
}