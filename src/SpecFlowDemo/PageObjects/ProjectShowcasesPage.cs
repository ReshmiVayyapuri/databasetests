using System;
using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class ProjectShowcasesPage : BasePageObject
    {
        public ProjectShowcasesPage(IWebDriver driver) : base(driver)
        {
            if(!driver.Url.EndsWith("explore"))
                throw new InvalidOperationException("Page not loaded");
        }
    }
}
