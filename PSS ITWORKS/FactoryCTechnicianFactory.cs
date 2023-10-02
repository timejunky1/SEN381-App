namespace PSS_ITWORKS
{
    class FactoryCTechnicianFactory : FactoryAMainFactory
    {
        protected override FactoryIUser CreateIUser()
        {
            FactoryIUser _Details = new FactoryCTechnicianDetails();
            return _Details;
        }
    }
}
