using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTAndroidAppAutomation.PageObjects
{
    class PropertyDetailPage
    {
        
        [FindsBy(How = How.XPath, Using = "//*[@text='SAVE']")]
        private IWebElement btnSave { get; set; }

        internal void CheckProperty()
        {
            Thread.Sleep(1000);
        }

        public bool IsPropertyDetailPage()
        {
            return btnSave.Displayed;
        }
    }
}
