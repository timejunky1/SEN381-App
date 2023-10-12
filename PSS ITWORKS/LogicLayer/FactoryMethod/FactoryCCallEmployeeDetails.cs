// FactoryCCallEmployeeDetails.cs
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCCallEmployeeDetails : FactoryIUser
    {
        CallForm form;
        public void ShowUserInterface(LogIn loginForm)
        {
            form.Show();
        }
    }
}