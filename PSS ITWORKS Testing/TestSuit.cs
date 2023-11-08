using PSS_ITWORKS;
using System.Reflection.Emit;
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS_Testing
{
    public class TestSuit
    {
        [Fact]
        // BlackBox: Positive Scenario (Valid user login should return true)
        public void VerifyUserLogin_ValidCredentials_ShouldOpenDashboard()
        {
           
        }

        // BlackBox: Negative Scenario (Invalid user login should return false)
        [Fact]
        public void InvalidUserLogin_ShouldShowErrorMessage()
        {
            
        }
    }
}