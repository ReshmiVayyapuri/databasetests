using System;
using OpenQA.Selenium;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class RepositorySteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");

        [Then(@"I should see the repository code page")]
        public void ThenIShouldSeeTheRepositoryCodePage()
        {
            var p = new RepositoryPageCodeTab(driver);
        }

    }
}
