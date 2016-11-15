using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowDemo.PageObjects
{
    public class DashboardPage : BasePageObject
    {
        [FindsBy(How = How.PartialLinkText, Using = "New repository")]
        private IWebElement newRepositoryButton;

        [FindsBy(How = How.LinkText, Using = "Explore GitHub")]
        private IWebElement exploreGitHubButton;

        [FindsBy(How = How.CssSelector, Using = "#your_repos span.repo")]
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

        public List<RepositoryRow> YourRepositories
            => yourRepositories.Where(a=>a.Displayed).Select(a => new RepositoryRow(driver,a)).ToList();

        public class RepositoryRow : BasePageObject
        {
            private readonly IWebElement _rowElement;

            public RepositoryRow(IWebDriver driver,IWebElement rowElement) : base(driver)
            {
                _rowElement = rowElement;
            }

            public string Name => _rowElement.Text;
            public RepositoryPageCodeTab GoToRepository() 
                => _rowElement.ClickAndContinueTo<RepositoryPageCodeTab>();
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
