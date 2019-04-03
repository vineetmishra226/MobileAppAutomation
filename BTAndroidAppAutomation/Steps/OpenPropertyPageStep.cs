using BTAndroidAppAutomation.PageObjects;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BTAndroidAppAutomation.Steps
{
    [Binding]

    class OpenPropertyPageStep
    {
        PropertyDetailPage PropertyDetailPage = null;

        [Then(@"I click the first property image")]
        public void ThenIClickTheFirstPropertyImage()
        {
            ListingPage listingPage = new ListingPage((AndroidDriver<AndroidElement>)ScenarioContext.Current["androidContext"]);

            PropertyDetailPage = listingPage.ClickImageLink();
        }

        [Then(@"I see the Property Detail page")]
        public void ThenISeeThePropertyDetailPage()
        {
           // ScenarioContext.Current.Pending();
        }


    }
}
