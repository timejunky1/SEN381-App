
using System.Windows.Forms;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCServiceManagerDetails : FactoryIUser
    {
        private LoginController loginController;

        public FactoryCServiceManagerDetails(LoginController loginController)
        {
            this.loginController = loginController;

        }
        public void ShowUserInterface(LogIn loginForm)
        {
            string name = loginController.Name;
            string surname = loginController.Surname;
            ServiceManagerForm managerForm = new ServiceManagerForm();
            managerForm.Show();
            loginForm.Close();
        }
    }
}