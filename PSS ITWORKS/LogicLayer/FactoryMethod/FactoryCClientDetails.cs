using System;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCClientDetails : FactoryIUser
    {
        private LoginController loginController;

        public FactoryCClientDetails(LoginController loginController)
        {
            this.loginController = loginController;
        }
        public void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            ClientForm clientForm = new ClientForm(dashboard, userInfo);
            clientForm.Show();
            dashboard.Hide();
        }
    }
}
