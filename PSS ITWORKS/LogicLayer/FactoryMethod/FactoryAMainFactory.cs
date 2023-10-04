namespace PSS_ITWORKS
{
    public abstract class FactoryAMainFactory
    {
        //Factory class, Contains all methods associated with factories
        protected abstract FactoryIUser CreateUser(string userType);
    }
}

