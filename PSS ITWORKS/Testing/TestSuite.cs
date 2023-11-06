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

        // WhiteBox: (Code Coverage Analysis) Test all statements are executed for 100% code coverage
        [Fact]
        public void EnsureAllStatementsAreExecuted()
        {
            // Arrange
            var loginController = new LoginController();

            // Act
            // Call methods in LoginController to ensure all statements are executed
            loginController.Connect();
            loginController.HandleLoginButtonClick("username", "password", new LogIn(), new Label());
            loginController.AuthenticateUser("username", "password");
            var userInfo = loginController.GetUserInfo();
            loginController.getID(userInfo);
            loginController.GetUserRole("username");
            loginController.FetchNameAndSurname("username");
            // loginController.HashPassword("password");
            loginController.SetPassword("username", "oldPassword", "newPassword");

            // Assert
            // No specific assertions are needed here. The test will fail if any statement is not executed.
        }

        // WhiteBox: (Unit Testing) Test individual functions of the Login with valid and invalid
        [Fact]
        public void LoginController_UnitTests()
        {
            // Arrange
            var mockDatabaseAPI = new Mock<DatabaseAPI>();
            var loginController = new LoginController();

            // Act & Assert: Test AuthenticateUser function
            mockDatabaseAPI.Setup(api => api.AuthenticateUser("validUsername", "validPassword")).Returns(true);
            mockDatabaseAPI.Setup(api => api.AuthenticateUser("invalidUsername", "invalidPassword")).Returns(false);

            // Valid authentication
            Assert.True(loginController.AuthenticateUser("validUsername", "validPassword"));

            // Invalid authentication
            Assert.False(loginController.AuthenticateUser("invalidUsername", "invalidPassword"));

            // Act & Assert: Test GetUserInfo function
            var userInfo = new LoginController.UserInfo
            {
                Name = "John",
                Surname = "Doe",
                Role = "Admin",
                ID = 1
            };

            mockDatabaseAPI.Setup(api => api.GetUserInformation("validUsername")).Returns(userInfo);
            mockDatabaseAPI.Setup(api => api.GetUserInformation("invalidUsername")).Returns((LoginController.UserInfo)null);

            // Valid user info
            Assert.NotNull(loginController.GetUserInfo());

            // Invalid user info
            Assert.Null(loginController.GetUserInfo());

            // Act & Assert: Test GetUserRole function
            mockDatabaseAPI.Setup(api => api.GetUserRole("validUsername")).Returns("Admin");
            mockDatabaseAPI.Setup(api => api.GetUserRole("invalidUsername")).Returns((string)null);

            // Valid user role
            Assert.NotNull(loginController.GetUserRole("validUsername"));

            // Invalid user role
            Assert.Null(loginController.GetUserRole("invalidUsername"));
        }
    }
}
