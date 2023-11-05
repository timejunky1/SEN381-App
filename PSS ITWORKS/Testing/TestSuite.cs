using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using PSS_ITWORKS;
using PSS_ITWORKS.Presentation_Layer;
using Xunit;
using System.Windows.Forms;

namespace PSS_ITWORKS.Testing
{
    public class TestSuite
    {
        // BlackBox: Positive Scenario (Valid user login should return true)
        [Fact]
        public void VerifyUserLogin_ValidCredentials_ShouldOpenDashboard()
        {
            // Arrange
            var mockDatabaseAPI = new Mock<DatabaseAPI>();
            mockDatabaseAPI.Setup(api => api.AuthenticateUser("validUsername", "validPassword")).Returns(true);

            var loginForm = new LogIn();
            var welcomeLabel = new Label();

            // Act
            var loginController = new LoginController();
            loginController.HandleLoginButtonClick("validUsername", "validPassword", loginForm, welcomeLabel);

            // Assert
            Assert.False(loginForm.Visible);
            Assert.True(welcomeLabel.Visible);
        }

        // BlackBox: Negative Scenario (Invalid user login should return false)
        [Fact]
        public void InvalidUserLogin_ShouldShowErrorMessage()
        {
            // Arrange
            var mockDatabaseAPI = new Mock<DatabaseAPI>();
            mockDatabaseAPI.Setup(api => api.AuthenticateUser(It.IsAny<string>(), It.IsAny<string>())).Returns(false);

            var loginForm = new Mock<LogIn>();
            var welcomeLabel = new Mock<Label>();

            string errorMessage = null;
            LoginController loginController = new LoginController();
            loginController.AuthenticationFailed += (sender, e) => errorMessage = e;

            // Act
            loginController.HandleLoginButtonClick("invalidUsername", "invalidPassword", loginForm.Object, welcomeLabel.Object);

            // Assert
            Assert.Equal("Invalid username or password. Please try again.", errorMessage);
        }
    }
}
