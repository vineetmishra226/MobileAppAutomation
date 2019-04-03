using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BTAndroidAppAutomation.Main
{
    public class Base
    {
        public AndroidDriver<AndroidElement> AndroidContext;
        public AppiumLocalService AppiumServiceContext;

        public Utilities Utilities => new Utilities(AppiumServiceContext, AndroidContext);


        public AndroidDriver<AndroidElement> StartAppiumServerForNative()
        {
            //Appium Local service
            AppiumServiceContext = Utilities.StartAppiumLocalService(4723);

            AndroidContext = Utilities.InitializeAndroidApp();
            return AndroidContext;
        }


    }
}