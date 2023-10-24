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
        public void ShowUserInterface(LogIn loginForm)
        {
            string name = loginController.Name;
            string surname = loginController.Surname;
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
            loginForm.Close();
        }
    }
}
