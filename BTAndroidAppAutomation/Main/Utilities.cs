using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;

namespace BTAndroidAppAutomation.Main
{
    public class Utilities : Base
    {
        private AppiumLocalService _appiumLocalService;
        private AndroidDriver<AndroidElement> _androiddriver;

        public Utilities(AppiumLocalService AppiumLocalService, AndroidDriver<AndroidElement> AndroidContext)
        {
            _appiumLocalService = AppiumLocalService;
            _androiddriver = AndroidContext;
        }
        public AndroidDriver<AndroidElement> InitializeAndroidApp()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("deviceName", "OnePlus 6");
            //desiredCapabilities.SetCapability("udid", "245969A15CA56CE5");
            desiredCapabilities.SetCapability("appPackage", "nz.co.barfoot.property");
            desiredCapabilities.SetCapability("appActivity", "nz.co.barfoot.property.ui.BARSplashActivity");
            desiredCapabilities.SetCapability("platformVersion", "9");
            desiredCapabilities.SetCapability("platformName", "Android");

            //Launch the Android driver
            AndroidDriver<AndroidElement> _androiddriver = new AndroidDriver<AndroidElement>(_appiumLocalService, desiredCapabilities);

            return _androiddriver;
        }



        public AppiumLocalService StartAppiumLocalService()
        {

            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();

            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }

        public AppiumLocalService StartAppiumLocalService(int portNumber)
        {

            _appiumLocalService = new AppiumServiceBuilder().WithAppiumJS(new FileInfo("/Program Files/Appium/resources/app/node_modules/appium/build/lib/main.js")).WithIPAddress("192.168.209.2").UsingPort(portNumber).Build();

            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }


        public void CloseAppiumServer()
        {
            // _appiumLocalService.Dispose();

            _androiddriver.CloseApp();
        }

               
    }
}
