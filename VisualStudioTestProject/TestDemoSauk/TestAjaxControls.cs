using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestDemoSauk.Pages;

namespace TestDemoSauk
{
    [TestClass]
    public class TestAjaxControls
    {
        private IWebDriver driver;
        private const string PathToChromeDriver = @"D:\Drivers";
        RadNumericTextBoxPage numericTextBoxPage; 

        [TestInitialize]
        public void TestInit()
        {
            this.driver = new ChromeDriver(PathToChromeDriver);
            driver.Manage().Window.Maximize();
            numericTextBoxPage = new RadNumericTextBoxPage(driver);
        }
        
        [TestMethod]
        public void TheRadNumericTextBoxPageExistsTest()
        {
            numericTextBoxPage.Navigate();

            Assert.AreEqual("ASP.NET AJAX NumericTextBox Examples | RadNumericTextBox component", driver.Title); 
        }

        [TestMethod]
        public void TheRadNumericTextBoxCalculationsTest()
        {
            numericTextBoxPage.Navigate();

            string unitCount = "2";
            string ammount = "30";
            string discountAmmount = "50";

            numericTextBoxPage.FillUnit(unitCount.ToString());
            numericTextBoxPage.FillPrice(ammount);
            numericTextBoxPage.FillDiscount(discountAmmount);

            string actual = numericTextBoxPage.GetTotal();

            Assert.AreEqual("$30.00", actual);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            this.driver.Close();
            this.driver.Dispose();
        }
    }
}
