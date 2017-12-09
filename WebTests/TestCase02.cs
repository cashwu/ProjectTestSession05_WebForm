using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebSiteTests
{
    [TestClass]
    [DeploymentItem(@"chromedriver.exe")]
    public class TestCase02
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [TestInitialize]
        public void SetupTest()
        {
            this.driver = new ChromeDriver();
            baseURL = TestConfig.BaseWebAddress.ToString();
            verificationErrors = new StringBuilder();
        }
        
        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [TestMethod]
        public void TheCase02Test()
        {
            driver.Navigate().GoToUrl(baseURL + "/Product");
            driver.FindElement(By.Id("MainContent_txtProductName")).Clear();
            driver.FindElement(By.Id("MainContent_txtProductName")).SendKeys("book");

            driver.FindElement(By.Id("MainContent_txtProductWeight")).Clear();
            driver.FindElement(By.Id("MainContent_txtProductWeight")).SendKeys("100");

            driver.FindElement(By.Id("MainContent_txtProductLength")).Clear();
            driver.FindElement(By.Id("MainContent_txtProductLength")).SendKeys("10");

            driver.FindElement(By.Id("MainContent_txtProductWidth")).Clear();
            driver.FindElement(By.Id("MainContent_txtProductWidth")).SendKeys("20");

            driver.FindElement(By.Id("MainContent_txtProductHeight")).Clear();
            driver.FindElement(By.Id("MainContent_txtProductHeight")).SendKeys("30");

            new SelectElement(driver.FindElement(By.Id("MainContent_drpCompany"))).SelectByText("新竹貨運");
            driver.FindElement(By.Id("MainContent_btnCalculate")).Click();

            Assert.AreEqual("新竹貨運", driver.FindElement(By.Id("MainContent_lblCompany")).Text);
            Assert.AreEqual("254.16", driver.FindElement(By.Id("MainContent_lblCharge")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
