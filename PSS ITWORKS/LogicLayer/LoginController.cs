using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class LoginController
    {
        private DatabaseAPI api;
        private FactoryUserFactory factory;
        public FactoryIUser Login(string Username, string Password)
        {
            //This Method will:
            //set connection for api
            //check credentials
            //get authorization type of that user
            //create user with factory
            //Create a Login and add the login to the database
            //return an instance of a user with the associated authorization
            throw new NotImplementedException();
        }

        public void LogOut(string Username)
        {
            throw new NotImplementedException();
        }
    }
}
