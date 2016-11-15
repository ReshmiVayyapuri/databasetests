using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class ResetPasswordPage : BasePageObject
    {
        public ResetPasswordPage(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.CssSelector("form[action='/password_reset']"));
        }
    }
}
