using System;
using OpenQA.Selenium;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class CreatePersonalAccountSteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");

        [Then(@"I should see the create personal account page")]
        public void ThenIShouldSeeTheCreatePersonalAccountPage()
        {
            var page  = new CreatePersonalAccountPage(driver);
        }
    }
}
