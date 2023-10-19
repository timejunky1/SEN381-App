using PSS_ITWORKS.Presentation_Layer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class FactoryCAdminDetails : FactoryIUser
    {
        
        public void ShowUserInterface(LogIn loginForm)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            loginForm.Close();
        }
    }
}