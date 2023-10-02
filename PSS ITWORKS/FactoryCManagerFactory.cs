namespace PSS_ITWORKS
{
    class FactoryCManagerFactory : FactoryAMainFactory
    {
        protected override FactoryIUser CreateIUser()
        {
            FactoryIUser _Details = new FactoryCManagerDetails();
            return _Details;
        }
    }
}
