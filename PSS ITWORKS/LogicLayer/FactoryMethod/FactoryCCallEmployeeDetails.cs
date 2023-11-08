
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
        public void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userinfo)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            CallForm callForm = new CallForm(dashboard, userinfo);
            callForm.Show();
            dashboard.Hide();
        }
    }
}