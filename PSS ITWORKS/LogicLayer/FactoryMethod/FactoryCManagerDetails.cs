
using System.Windows.Forms;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCManagerDetails : FactoryIUser
    {
        

        
        public void ShowUserInterface(LogIn loginForm)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
            loginForm.Close();
        }
    }
}