using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTAndroidAppAutomation.PageObjects
{
    class ListingPage 
    {
        private AndroidDriver<AndroidElement> _androidDriver;

        public ListingPage(AndroidDriver<AndroidElement> AndroidDriver)

        {
            PageFactory.InitElements(AndroidDriver, this);
            _androidDriver = AndroidDriver;
        }

        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout[1]/android.widget.RelativeLayout[1]/android.widget.ImageView[1]")]
        IWebElement imagelink { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@text='LIST']")]
        //IWebElement ListLabel { get; set; }

        


        public PropertyDetailPage ClickImageLink()
        {
            Thread.Sleep(1000);
            imagelink.Click();

            return new PropertyDetailPage();


        }

        public bool IsListImageExist()
        {
            Thread.Sleep(1000);
            return imagelink.Displayed;
        }


    }
}
