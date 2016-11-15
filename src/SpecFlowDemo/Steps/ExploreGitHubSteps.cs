using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class ExploreGitHubSteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");

        [Then(@"I should see the Project showcases page")]
        public void ThenIShouldSeeTheProjectShowcasesPage()
        {
            var p = new ProjectShowcasesPage(driver);
        }


    }
}
