using PSS_ITWORKS.Presentation_Layer;
using PSS_ITWORKS.LogicLayer;
using System;
using PSS_ITWORKS;

namespace PSS_Testing
{
    public class UnitTest1
    {   

        [Fact]
        public void GetCalls_Positive()
        {
            //Arange
            StrategyCallManagement strategy = new StrategyCallManagement();
            //Act
            strategy.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS1; Integrated Security=True");
            bool result = strategy.Get().Count() > 0;

            Assert.True(result);    

        }

        [Fact]
        public void GetCalls_Negative()
        {
            //Arange
            StrategyCallManagement strategy = new StrategyCallManagement();
            //Act
            strategy.Connect(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PSS1; Integrated Security=True");
            bool result = strategy.Get().Count() == 0;

            Assert.True(result);

        }
    }
}