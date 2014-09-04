using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using mtf;
using System.Collections.Generic;


namespace massivewebauto
{
    [TestClass]
    public class UnitTest1
    {
        
        
        //[TestInitialize]

        //public void startNodes()
        //{
        //    //List<int> browserList = new List<int>();
        //    //browserList.Add(0);
        //    //browserList.Add(1);
        //    //browserList.Add(2);
        //    //browserList.Add(3);

        //   var objdriver = new mtf.SeleniumTestBase();
        //   for (int i = 0; i < 3; i++)
        //   {
        //       //objdriver.selectBrowser(0);
        //       objdriver.driver.Navigate().GoToUrl("http://test.massivision.com");  
        //   }
           

        //}

        [TestMethod]
        public void TestMethod1()
        {
            var objdriver = new mtf.SeleniumTestBase();
            objdriver.startFireFoxOnWindows();

            objdriver.driver.Navigate().GoToUrl("http://test.massivision.com");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var objdriver = new mtf.SeleniumTestBase();
            objdriver.startChromeOnWindows();
            objdriver.driver.Navigate().GoToUrl("http://test.massivision.com");
        }

        [TestMethod]
        public void TestMethod3()
        {
            var objdriver = new mtf.SeleniumTestBase();
            objdriver.startIEOnWindows();
            objdriver.driver.Navigate().GoToUrl("http://test.massivision.com");
        }
    }
}
