
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
        public void ShowUserInterface(Dashboard dashboard)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            ServiceManagerForm managerForm = new ServiceManagerForm(dashboard);
            managerForm.Show();
            dashboard.Hide();
        }
    }
}