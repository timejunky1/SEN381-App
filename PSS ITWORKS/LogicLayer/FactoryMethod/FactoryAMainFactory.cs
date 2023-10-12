namespace PSS_ITWORKS
{
    public abstract class FactoryAMainFactory
    {
        protected internal abstract FactoryIUser CreateUser(string userType);
    }
}