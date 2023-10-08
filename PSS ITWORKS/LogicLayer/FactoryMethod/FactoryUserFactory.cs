// FactoryUserFactory.cs
namespace PSS_ITWORKS
{
    class FactoryUserFactory : FactoryAMainFactory
    {
        protected override FactoryIUser CreateUser(string userType)
        {
            FactoryIUser user = new FactoryCManagerDetails();
            return user;
        }
    }
}