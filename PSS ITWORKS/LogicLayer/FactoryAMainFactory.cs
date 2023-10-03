namespace PSS_ITWORKS
{
    public abstract class FactoryAMainFactory
    {
        //Factory class, Contains all methods associated with factories
        protected abstract FactoryIUser CreateUser(string userType);

        public abstract FactoryIUser GetUserRole(string usernam, string password);
    }
}

