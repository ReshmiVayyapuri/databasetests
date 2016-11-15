using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class ProjectShowcasesPage : BasePageObject
    {
        public ProjectShowcasesPage(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.Id("explore-featured"));
        }
    }
}
