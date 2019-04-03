using BTAndroidAppAutomation.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BTAndroidAppAutomation.Steps
{
    [Binding]
    class AppLaunchSteps
    {
        ListingPage ListingPage = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I press allow on welcome splash page")]
        public void WhenIPressAllowOnWelcomeSplashPage()
        {
            SplashPage splashpage = new SplashPage((AndroidDriver<AndroidElement>)ScenarioContext.Current["androidContext"]);
            ListingPage = splashpage.AllowAppFeature();
        }

        [Then(@"I see the ListView page")]
        public void ThenISeeTheListViewPage()
        {
            
            Assert.That(ListingPage.IsListImageExist(), Is.True);
        }


    }
}
