namespace PSS_ITWORKS
{
    class FactoryUserFactory : FactoryAMainFactory
    {
        protected override FactoryIUser CreateUser(string userType)
        {
            //Create new user instance based on user type
            FactoryIUser user = new FactoryCManagerDetails();
            return user;
        }
        //this implements MainFactory
    }
}
