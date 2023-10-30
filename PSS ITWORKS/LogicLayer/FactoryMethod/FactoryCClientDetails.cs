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
        public void ShowUserInterface(Dashboard dashboard)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            ClientForm clientForm = new ClientForm(dashboard);
            clientForm.Show();
            dashboard.Hide();
        }
    }
}
