
using PSS_ITWORKS.Presentation_Layer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class FactoryCTechnicianDetails : FactoryIUser
    {

        private LoginController loginController;

        public FactoryCTechnicianDetails(LoginController loginController)
        {
            this.loginController = loginController;
        }
        public void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            Technician technicianForm = new Technician(dashboard, userInfo);
            technicianForm.Show();
            dashboard.Hide();
        }
    }
}