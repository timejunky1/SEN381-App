
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
        public void ShowUserInterface(LogIn loginForm)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            TechnicianForm technicianForm = new TechnicianForm();
            technicianForm.Show();
            loginForm.Close();
        }
    }
}