using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class RepositoryPageCodeTab : BasePageObject
    {
        public RepositoryPageCodeTab(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.CssSelector("a[aria-selected='true'][data-selected-links*='repo_source']"));
        }
    }
}
