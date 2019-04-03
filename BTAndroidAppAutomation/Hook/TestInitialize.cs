using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BTAndroidAppAutomation.TestCases
{
    [Binding]

    class TestInitialize : Main.Base
    {
        [BeforeScenario]
        public void InitializeTest()
        {
            AndroidContext = StartAppiumServerForNative();

            ScenarioContext.Current["androidContext"] = AndroidContext;
            
        }

        [TearDown]
        public void cleanUp()
        {
            Utilities.CloseAppiumServer();
      
        }
    }

}
