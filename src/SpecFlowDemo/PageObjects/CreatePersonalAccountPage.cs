using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class CreatePersonalAccountPage : BasePageObject
    {
        public CreatePersonalAccountPage(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.Id("signup-form"));
        }
    }
}
