using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class CreateNewRepositoryPage : BasePageObject
    {
        public CreateNewRepositoryPage(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.CssSelector("body.page-new-repo.logged-in"));
        }
    }
}