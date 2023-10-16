
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCCallEmployeeDetails : FactoryIUser
    {
        
        public void ShowUserInterface(LogIn loginForm)
        {
            CallForm callForm = new CallForm();
            callForm.Show();
            loginForm.Close();
        }
    }
}