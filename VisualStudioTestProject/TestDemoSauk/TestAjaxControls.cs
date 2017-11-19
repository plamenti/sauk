using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestDemoSauk
{
    [TestClass]
    public class TestAjaxControls
    {
        private IWebDriver driver;
        private string baseURL;
        private const string PathToChromeDriver = @"D:\Drivers";

        [TestInitialize]
        public void TestInit()
        {
            this.driver = new ChromeDriver(PathToChromeDriver);
            baseURL = "https://www.telerik.com/";
        }
        
        [TestMethod]
        public void TheRadNumericTextBoxPageExistsTest()
        {
            this.driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.LinkText("Demos")).Click();
            driver.FindElement(By.LinkText("Launch ASP.NET AJAX demos")).Click();
            driver.FindElement(By.LinkText("NumericTextBox")).Click();

            Assert.AreEqual("ASP.NET AJAX NumericTextBox Examples | RadNumericTextBox component", driver.Title); 
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            this.driver.Close();
            this.driver.Dispose();
        }
    }
}
