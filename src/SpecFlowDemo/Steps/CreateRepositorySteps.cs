using System;
using OpenQA.Selenium;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class CreateRepositorySteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");

        [Then(@"I should see the create a new repository page")]
        public void ThenIShouldSeeTheCreateANewRepositoryPage()
        {
            var p  = new CreateNewRepositoryPage(driver);
        }

    }
}
