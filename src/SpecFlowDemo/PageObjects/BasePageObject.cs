using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowDemo.PageObjects
{
    public class BasePageObject
    {
        protected IWebDriver driver { get; set; }

        public BasePageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        protected void VerifyPageLoaded(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
