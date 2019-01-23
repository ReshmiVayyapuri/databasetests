using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowDemo.PageObjects
{
    public class DashboardPage : BasePageObject
    {
        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'dashboard-sidebar')]//*[contains(@class,'js-repos-container')]//a[normalize-space()='New']")]
        private IWebElement newRepositoryButton;

        [FindsBy(How = How.LinkText, Using = "Explore GitHub")]
        private IWebElement exploreGitHubButton;

        [FindsBy(How = How.CssSelector, Using = ".dashboard-sidebar .js-repos-container [data-hovercard-type=repository]")]
        private IList<IWebElement> yourRepositories;


        [FindsBy(How = How.Id, Using = "your-repos-filter")]
        private IWebElement yourRepositoriesFilterTextField;

        public DashboardPage(IWebDriver driver) : base(driver)
        {
            VerifyPageLoaded(By.CssSelector("body.page-dashboard.logged-in"));
        }

        public CreateNewRepositoryPage ClickCreateRepository() 
            => newRepositoryButton.ClickAndContinueTo<CreateNewRepositoryPage>();

        public ProjectShowcasesPage ClickExploreGitHub() => exploreGitHubButton.ClickAndContinueTo<ProjectShowcasesPage>();

        public List<DashboardRepositoryRow> YourRepositories
        {
            get
            {
                var c = yourRepositories.Count;
                var repositories = yourRepositories;
                var webElements = repositories.Where(a => a.Displayed);
                return webElements.Select(a => new DashboardRepositoryRow(driver, a))
                    .ToList();
            }
        }


        public DashboardPage SearchForRepository(string repository)
        {
            yourRepositoriesFilterTextField.Clear();
            yourRepositoriesFilterTextField.SendKeys(repository);
            System.Threading.Thread.Sleep(500);//wait for rendering the results
            return this;
        }
    }
}
