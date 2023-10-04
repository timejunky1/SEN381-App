using PSS_ITWORKS.Presentation_Layer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class FactoryCAdminDetails : FactoryIUser
    {
        AdminForm adminForm;
        public void ShowUserInterface()
        {
            adminForm.Show();
        }
    }
}
