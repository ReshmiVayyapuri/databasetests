using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class DashboardSteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");
        private DashboardPage dashboardPage;

        [Then(@"I should see the dashboard")]
        public void ThenIShouldSeeTheDashboard()
        {
            var p = new DashboardPage(driver);
        }

        [Given(@"I am in the dashboard")]
        public void GivenIAmInTheDashboard()
        {
            dashboardPage = 
                LoginPage.GoToPage(driver).LoginSuccess("SpecFlowDemo@sharklasers.com", "SpecFlowDemo@sharklasers.com");
        }

        [When(@"I click New repository")]
        public void WhenIClickNewRepository()
        {
            dashboardPage.ClickCreateRepository();
        }

        [Then(@"I should see my repositories")]
        public void ThenIShouldSeeMyRepositories()
        {
            Assert.IsTrue(dashboardPage.YourRepositories.Any());
        }


        [When(@"I click Explore GitHub")]
        public void WhenIClickExploreGitHub()
        {
            dashboardPage.ClickExploreGitHub();
        }

        [When(@"I click the first repository")]
        public void WhenIClickTheFirstRepository()
        {
            dashboardPage.YourRepositories.First().GoToRepository();
        }




    }
}












//[Given(@"I have a repository named ""(.*)""")]
//public void GivenIHaveARepositoryNamed(string repository)
//{
//    Assert.IsTrue(dashboardPage.YourRepositories.Any(a=>a.Name==repository));
//}

//[When(@"I search for repository ""(.*)""")]
//public void WhenISearchForRepository(string repository)
//{
//    dashboardPage.SearchForRepository(repository);
//}

//[Then(@"I should see only the ""(.*)"" repository")]
//public void ThenIShouldSeeOnlyTheRepository(string repository)
//{
//    Assert.AreEqual(1,dashboardPage.YourRepositories.Count);
//    Assert.AreEqual(repository, dashboardPage.YourRepositories.First().Name);
//}