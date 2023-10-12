// FactoryCTechnicianDetails.cs
using PSS_ITWORKS.Presentation_Layer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class FactoryCTechnicianDetails : FactoryIUser
    {
        TechnicianForm form;
        public void ShowUserInterface(LogIn loginForm)
        {
            form.Show();
        }
    }
}