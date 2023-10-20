
using System.Windows.Forms;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCServiceManagerDetails : FactoryIUser
    {
                
        public void ShowUserInterface(LogIn loginForm)
        {
            ServiceManagerForm managerForm = new ServiceManagerForm();
            managerForm.Show();
            loginForm.Close();
        }
    }
}