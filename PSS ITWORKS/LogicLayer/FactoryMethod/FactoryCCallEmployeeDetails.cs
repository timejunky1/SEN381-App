
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCCallEmployeeDetails : FactoryIUser
    {
        private LoginController loginController;

        public FactoryCCallEmployeeDetails(LoginController loginController)
        {
            this.loginController = loginController;
        }
        public void ShowUserInterface(LogIn loginForm)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            CallForm callForm = new CallForm();
            callForm.Show();
            loginForm.Close();
        }
    }
}