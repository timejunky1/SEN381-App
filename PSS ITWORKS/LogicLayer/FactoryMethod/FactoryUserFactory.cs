using System;

namespace PSS_ITWORKS
{
    class FactoryUserFactory : FactoryAMainFactory
    {
        protected internal override FactoryIUser CreateUser(string userType)
        {
            FactoryIUser user = null; // Initialize the user variable here

            switch (userType)
            {
                case "Admin":
                    user = new FactoryCAdminDetails();
                    break;
                case "Call Employee":
                    user = new FactoryCCallEmployeeDetails();
                    break;
                case "Manager":
                    user = new FactoryCServiceManagerDetails();
                    break;
                case "Technician":
                    user = new FactoryCTechnicianDetails();
                    break;
                default:
                    throw new Exception("Invalid user role.");
            }

            return user;
        }
    }
}