using System;
using OpenQA.Selenium;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class ResetPasswordSteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");

        [Then(@"I should see the reset password page")]
        public void ThenIShouldSeeTheResetPasswordPage()
        {
            var p = new ResetPasswordPage(driver);
        }
    }
}
