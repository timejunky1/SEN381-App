
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
        public void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            ServiceManagerForm managerForm = new ServiceManagerForm(dashboard, userInfo);
            managerForm.Show();
            dashboard.Hide();
        }
    }
}