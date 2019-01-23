using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class RepositoryPageCodeTab : BasePageObject
    {
        public RepositoryPageCodeTab(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.CssSelector("nav.reponav"));
        }
    }
}
