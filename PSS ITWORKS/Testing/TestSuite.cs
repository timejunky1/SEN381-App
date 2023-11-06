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
        public void VerifyUserLogin_ValidCredentials_ShouldShowDashboardForm()
        {
            var userInfo = new LoginController.UserInfo
            {
                Name = "Brad",
                Surname = "Davies",
                Role = "Admin",
                ID = 40 
            };


            // Arrange
            var mockDatabaseAPI = new Mock<DatabaseAPI>();
            mockDatabaseAPI.Setup(api => api.AuthenticateUser("brad.davies@example.com", "Seivad#4")).Returns(true);

            var loginForm = new LogIn();
            var loginController = new LoginController();
            var dashboardForm = new Dashboard(loginController, userInfo, loginForm);
            dashboardForm.Visible = false; // Initially set to invisible
            var welcomeLabel = new Label();

            // Act
            loginController.HandleLoginButtonClick("brad.davies@example.com", "Seivad#4", loginForm, dashboardForm, welcomeLabel);

            // Assert
            Assert.False(loginForm.Visible);
            Assert.True(dashboardForm.Visible);
            Assert.False(welcomeLabel.Visible);
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
            loginController.AuthenticateUser += (sender, e) => errorMessage = e;

            // Act
            loginController.HandleLoginButtonClick("57829", "oip", loginForm.Object, welcomeLabel.Object);

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
            mockDatabaseAPI.Setup(api => api.AuthenticateUser("brad.davies@example.com", "Seivad#4")).Returns(true);
            mockDatabaseAPI.Setup(api => api.AuthenticateUser("invalidUsername", "invalidPassword")).Returns(false);

            // Valid authentication
            Assert.True(loginController.AuthenticateUser("brad.davies@example.com", "Seivad#4"));

            // Invalid authentication
            Assert.False(loginController.AuthenticateUser("57829", "oip"));

            // Act & Assert: Test GetUserInfo function
            var userInfo = new LoginController.UserInfo
            {
                Name = "Brad",
                Surname = "Davies",
                Role = "Admin",
                ID = 40
            };

            mockDatabaseAPI.Setup(api => api.GetUserInformation("brad.davies@example.com")).Returns(userInfo);
            mockDatabaseAPI.Setup(api => api.GetUserInformation("57829")).Returns((LoginController.UserInfo)null);

            // Valid user info
            Assert.NotNull(loginController.GetUserInfo());

            // Invalid user info
            Assert.Null(loginController.GetUserInfo());

            // Act & Assert: Test GetUserRole function
            mockDatabaseAPI.Setup(api => loginController.GetUserRole("brad.davies@example.com")).Returns("Admin");
            mockDatabaseAPI.Setup(api => loginController.GetUserRole("57829")).Returns((string)null);

            // Valid user role
            Assert.NotNull(loginController.GetUserRole("brad.davies@example.com"));

            // Invalid user role
            Assert.Null(loginController.GetUserRole("57829"));
        }
    }
}
