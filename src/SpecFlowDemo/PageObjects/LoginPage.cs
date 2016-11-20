using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowDemo.PageObjects
{
    public class LoginPage :BasePageObject
    {
        [FindsBy(How = How.LinkText,Using = "Forgot password?")]
        private IWebElement forgotPasswordLink;

        [FindsBy(How = How.LinkText, Using = "Create an account")]
        private IWebElement createAnAccountLink;

        [FindsBy(How = How.Id, Using = "login_field")]
        private IWebElement usernameOrEmailAddressTextField;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordTextField;


        [FindsBy(How = How.CssSelector, Using = "input[value='Sign in']")]
        private IWebElement SignInButton;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.CssSelector("form[action='/session']"));
        }

        public static LoginPage GoToPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://github.com/login");
            return new LoginPage(driver);
        }

        public ResetPasswordPage ClickForgotPassword() 
            => forgotPasswordLink.ClickAndContinueTo<ResetPasswordPage>();

        public CreatePersonalAccountPage ClickCreateAnAccount() 
            => createAnAccountLink.ClickAndContinueTo<CreatePersonalAccountPage>();

        public string UsernameOrEmail
        {
            get { return usernameOrEmailAddressTextField.Text; }
            set
            {
                usernameOrEmailAddressTextField.Clear();
                usernameOrEmailAddressTextField.SendKeys(value);
            }
        }

        public string Password
        {
            get { return passwordTextField.Text; }
            set
            {
                passwordTextField.Clear();
                passwordTextField.SendKeys(value);
            }
        }

        public DashboardPage ClickSignInSuccess() 
            => SignInButton.ClickAndContinueTo<DashboardPage>();


        public void ClickSignIn()
        {
            SignInButton.Click();
        }

        public LoginPage ClickSignInFailure() 
            => SignInButton.ClickAndContinueTo<LoginPage>();

        public DashboardPage LoginSuccess(string username, string password)
        {
            UsernameOrEmail = username;
            Password = password;
            return ClickSignInSuccess();
        }
    }
}
