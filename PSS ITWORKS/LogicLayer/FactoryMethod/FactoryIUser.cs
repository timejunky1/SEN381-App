using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS
{
    public interface FactoryIUser
    {
        void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userInfo);
         
    }
}