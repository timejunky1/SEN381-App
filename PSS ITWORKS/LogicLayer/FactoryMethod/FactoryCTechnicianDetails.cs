
using PSS_ITWORKS.Presentation_Layer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class FactoryCTechnicianDetails : FactoryIUser
    {
        
        public void ShowUserInterface(LogIn loginForm)
        {
            TechnicianForm technicianForm = new TechnicianForm();
            technicianForm.Show();
            loginForm.Close();
        }
    }
}