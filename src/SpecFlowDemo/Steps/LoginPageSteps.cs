using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class LoginPageSteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");

        private LoginPage loginPage;

        [Given(@"I am in the login page")]
        public void GivenIAmInTheLoginPage()
        {
            loginPage = LoginPage.GoToPage(driver);
        }


        [When(@"I click Forgot password\?")]
        public void WhenIClickForgotPassword()
        {
            loginPage.ClickForgotPassword();
        }

        [When(@"I click create an account")]
        public void WhenIClickCreateAnAccount()
        {
            loginPage.ClickCreateAnAccount();
        }

        [When(@"I fill the (?:email address|username) with ""(.*)""")]
        public void WhenIFillTheEmailOrUsernameWith(string emailOrUsername)
        {
            loginPage.UsernameOrEmail = emailOrUsername;
        }

        [When(@"I fill the password with ""(.*)""")]
        public void WhenIFillThePasswordWith(string password)
        {
            loginPage.Password = password;
        }

        [When(@"I click Sign in")]
        public void WhenIClickSignIn()
        {
            loginPage.ClickSignIn();
        }

        [Then(@"I should see an error message ""(.*)""")]
        public void ThenIShouldSeeAnErrorMessage(string errorMessage)
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.CssSelector("body"), errorMessage));
        }

    }
}
