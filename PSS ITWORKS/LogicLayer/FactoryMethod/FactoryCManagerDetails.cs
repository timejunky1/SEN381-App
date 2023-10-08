// FactoryCManagerDetails.cs
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    class FactoryCManagerDetails : FactoryIUser
    {
        ManagerForm managerForm;
        public void ShowUserInterface()
        {
            managerForm.Show();
        }
    }
}