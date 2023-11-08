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
        public void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            AdminForm adminForm = new AdminForm(dashboard, userInfo);
            adminForm.Show();
            dashboard.Hide();
        }

    }
}