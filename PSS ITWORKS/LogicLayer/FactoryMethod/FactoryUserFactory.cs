namespace PSS_ITWORKS
{
    class FactoryUserFactory : FactoryAMainFactory
    {
        protected internal override FactoryIUser CreateUser(string userType)
        {
            FactoryIUser user = new FactoryCManagerDetails();
            return user;
        }
    }
}