// FactoryAMainFactory.cs
namespace PSS_ITWORKS
{
    public abstract class FactoryAMainFactory
    {
        protected abstract FactoryIUser CreateUser(string userType);
    }
}