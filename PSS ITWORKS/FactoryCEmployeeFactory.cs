namespace PSS_ITWORKS
{
    class FactoryCEmployeeFactory : FactoryAMainFactory
    {
        protected override FactoryIUser CreateIUser()
        {
            FactoryIUser _Details = new FactoryCEmployeeDetails();
            return _Details;
        }
    }
}
