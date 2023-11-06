using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static LoginController;

namespace PSS_ITWORKS.Testing
{
    public class TestSuite3
    {

        //White box decision coverage for each type of user
        [Fact]
        public void Test_Show_Technician()
        {
            //Arange
            FactoryUserFactory factory = new FactoryUserFactory(null);
            FactoryIUser userPortal = factory.CreateUser("Technician");
            //Act
            userPortal.ShowUserInterface(null);
            bool result = userPortal != null;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Show_Client()
        {
            //Arange
            FactoryUserFactory factory = new FactoryUserFactory(null);
            FactoryIUser userPortal = factory.CreateUser("Client");
            //Act
            userPortal.ShowUserInterface(null);
            bool result = userPortal != null;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Show_Admin()
        {
            //Arange
            FactoryUserFactory factory = new FactoryUserFactory(null);
            FactoryIUser userPortal = factory.CreateUser("Admin");
            //Act
            userPortal.ShowUserInterface(null);
            bool result = userPortal != null;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Show_ServiceManager()
        {
            //Arange
            FactoryUserFactory factory = new FactoryUserFactory(null);
            FactoryIUser userPortal = factory.CreateUser("Service Manager");
            //Act
            userPortal.ShowUserInterface(null);
            bool result = userPortal != null;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Show_ContractManager()
        {
            //Arange
            FactoryUserFactory factory = new FactoryUserFactory(null);
            FactoryIUser userPortal = factory.CreateUser("Contract Manager");
            //Act
            userPortal.ShowUserInterface(null);
            bool result = userPortal != null;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Show_ClientManager()
        {
            //Arange
            FactoryUserFactory factory = new FactoryUserFactory(null);
            FactoryIUser userPortal = factory.CreateUser("Client Manager");
            //Act
            userPortal.ShowUserInterface(null);
            bool result = userPortal != null;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Show_CallEmployee()
        {
            //Arange
            FactoryUserFactory factory = new FactoryUserFactory(null);
            FactoryIUser userPortal = factory.CreateUser("Call Employee");
            //Act
            userPortal.ShowUserInterface(null);
            bool result = userPortal != null;
            //Assert
            Assert.True(result);

        }
    }
}
