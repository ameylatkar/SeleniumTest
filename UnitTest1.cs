using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver test_driver;
        [TestMethod]
        public void TestSite()
        {
            test_driver = new ChromeDriver();
            test_driver.Navigate().GoToUrl("https://www.wipro.com/");
            Assert.IsTrue(test_driver.Title.Contains("Technology"));
            test_driver.Quit();        
        }
    }
}
