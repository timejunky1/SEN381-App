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

        public override FactoryIUser GetUserRole(string usernam, string password)
        {
            //encrypt password
            //connect to database and get user type
            string userType = "Manager";
            return this.CreateUser(userType);
        }

        //this implements MainFactory
    }
}
