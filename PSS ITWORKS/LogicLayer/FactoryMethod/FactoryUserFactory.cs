using System;
using System.Windows.Forms;
using PSS_ITWORKS.LogicLayer.FactoryMethod;

namespace PSS_ITWORKS
{
    class FactoryUserFactory : FactoryAMainFactory
    {
        private LoginController loginController;

        public FactoryUserFactory(LoginController loginController)
        {
            this.loginController = loginController;
        }


        protected internal override FactoryIUser CreateUser(string userType)
        {
            FactoryIUser user = null;
            switch (userType)
            {
                case "Admin":
                    user = new FactoryCAdminDetails(loginController);
                    break;
                case "Call Employee":
                    user = new FactoryCCallEmployeeDetails(loginController);
                    break;
                case "Service Manager":
                    user = new FactoryCServiceManagerDetails(loginController);
                    break;
                case "Technician":
                    user = new FactoryCTechnicianDetails(loginController);
                    break;
                case "Client Manager":
                    user = new FactoryCClientManagerDetails(loginController);
                    break;
                case "Contract Manager":
                    user = new FactoryCContractManagerDetails(loginController);
                    break;
                case "Client":
                    MessageBox.Show("Client");
                    break;
                default:
                    throw new Exception("Invalid user role.");
            }

            return user;
        }
    }
}