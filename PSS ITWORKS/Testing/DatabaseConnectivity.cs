using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.LogicLayer.StrategyMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PSS_ITWORKS.Testing
{
    public class DatabaseConnectivity
    {
        //Black Box: Boundry testing to ensure for return of data from database IDs of technicians are between 1 and 20
        [Theory]
        [InlineData(0,false)]
        [InlineData(1, false)]
        [InlineData(20, false)]
        [InlineData(21, false)]
        public void GetTechnicianInfo(int ID, bool expectedResult)
        {
            //Arange
            StrategyTechnician strategy = new StrategyTechnician();
            //Act
            strategy.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS1; Integrated Security=True");
            IEntity technician = strategy.Get(ID);
            bool result = technician != null;
            //Assert
            Assert.Equal(expectedResult, result);

        }


        [Fact]
        public void GetCalls_Positive()
        {
            //Arange
            StrategyCallManagement strategy = new StrategyCallManagement();
            //Act
            strategy.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS1; Integrated Security=True");
            bool result = strategy.Get().Count() > 0;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void GetCalls_Negative()
        {
            //Arange
            StrategyCallManagement strategy = new StrategyCallManagement();
            //Act
            strategy.Connect("Wrong connection string");
            bool result = strategy.Get().Count() == 0;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void GetClients_Positive()
        {
            //Arange
            StrategyClientManager strategy = new StrategyClientManager();
            //Act
            strategy.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS1; Integrated Security=True");
            bool result = strategy.Get().Count() > 0;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void GetClients_Negative()
        {
            //Arange
            StrategyClientManager strategy = new StrategyClientManager();
            //Act
            strategy.Connect("Wrong connection string");
            bool result = strategy.Get().Count() == 0;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void GetEmployees_Positive()
        {
            //Arange
            StratagyEmployeeManagement strategy = new StratagyEmployeeManagement();
            //Act
            strategy.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS1; Integrated Security=True");
            bool result = strategy.Get().Count() > 0;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void GetEmployees_Negative()
        {
            //Arange
            StratagyEmployeeManagement strategy = new StratagyEmployeeManagement();
            //Act
            strategy.Connect("Wrong connection string");
            bool result = strategy.Get().Count() == 0;
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void GetJobs_Positive()
        {
            //Arange
            StrategyJobManager strategy = new StrategyJobManager();
            //Act
            strategy.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS1; Integrated Security=True");
            bool result = strategy.Get().Count() > 0;
            //Assert
            Assert.True(result);

        }

        [Fact]
        public void GetJobsEmployees_Negative()
        {
            //Arange
            StrategyJobManager strategy = new StrategyJobManager();
            //Act
            strategy.Connect("Wrong connection string");
            bool result = strategy.Get().Count() == 0;
            //Assert
            Assert.True(result);
        }
    }
}
