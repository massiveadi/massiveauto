using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;



namespace massiveauto
{
    public static class SeleniumTestBase
    {
        public static IWebDriver driver;
        static String baseURL;


        //public void startBrowser(string url){

        //    baseURL = url;        

        //    driver = new InternetExplorerDriver(@"C:\Users\aditya.ganti\Documents\Visual Studio 2012\Projects\massivewebauto\mtf\libs\");

        //    driver.Navigate().GoToUrl(baseURL);


        //}

        public static void startFireFoxOnWindows()
        {


            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Firefox();
            capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));


            driver = new RemoteWebDriver(new Uri("http://localhost:5555/wd/hub"), capabilities);

            // return driver;

        }
        public static void startChromeOnWindows()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Chrome();
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            driver = new RemoteWebDriver(new Uri("http://localhost:5556/wd/hub"), capabilities);

        }

        public static void startIEOnWindows()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.InternetExplorer();
            capabilities.SetCapability(CapabilityType.BrowserName, "internet explorer");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            //capabilities.SetCapability(CapabilityType.Version, "8");


            driver = new RemoteWebDriver(new Uri("http://localhost:5555/wd/hub"), capabilities);

        }



        public static void  closeBrowser()
        {
            driver.Quit();
        }

    }
}
