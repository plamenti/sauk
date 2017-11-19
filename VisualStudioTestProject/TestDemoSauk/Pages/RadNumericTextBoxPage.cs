using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestDemoSauk.Pages
{
    public class RadNumericTextBoxPage
    {
        private const string baseURL = "https://www.telerik.com/";
        private IWebDriver driver;

        public RadNumericTextBoxPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.LinkText("Demos")).Click();
            driver.FindElement(By.LinkText("Launch ASP.NET AJAX demos")).Click();
            driver.FindElement(By.LinkText("NumericTextBox")).Click();
        }

        public void FillUnit(string unitCount)
        {
            IWebElement units = driver.FindElement(By.Id("ctl00_ContentPlaceholder1_RadNumericTextBox1"));
            units.Click();
            units.Clear();
            units.SendKeys(unitCount);
        }

        public void FillPrice(string ammount)
        {
            IWebElement price = driver.FindElement(By.Id("ctl00_ContentPlaceholder1_RadNumericTextBox2"));
            price.Click();
            price.Clear();
            price.SendKeys(ammount);
        }

        public void FillDiscount(string discountAmmount)
        {
            IWebElement discount = driver.FindElement(By.Id("ctl00_ContentPlaceholder1_RadNumericTextBox3"));
            discount.Click();
            discount.Clear();
            discount.SendKeys(discountAmmount);
        }

        public string GetTotal()
        {
            IWebElement discountLabel = driver.FindElement(By.Id("ctl00_ContentPlaceholder1_Label3"));
            discountLabel.Click();
            IWebElement total = driver.FindElement(By.Id("ctl00_ContentPlaceholder1_resultTextBox"));

            return total.GetAttribute("value");
        }
    }
}
