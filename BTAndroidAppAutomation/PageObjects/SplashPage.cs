using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTAndroidAppAutomation.PageObjects
{
    class SplashPage 
    {

        private AndroidDriver<AndroidElement> _androidDriver;
        public SplashPage(AndroidDriver<AndroidElement> AndroidDriver)
        {
            PageFactory.InitElements(AndroidDriver, this);
            _androidDriver = AndroidDriver;
        }


        [FindsBy(How = How.XPath, Using = "//*[@text='ALLOW']")]
        private IWebElement AllowApp { get; set; } 


        public ListingPage AllowAppFeature()
        {
            AllowApp.Click();

            return new ListingPage(_androidDriver);
        }

    }
}
