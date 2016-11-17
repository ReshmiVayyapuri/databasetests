using OpenQA.Selenium;

namespace SpecFlowDemo.PageObjects
{
    public class DashboardRepositoryRow : BasePageObject
    {
        private readonly IWebElement _rowElement;

        public DashboardRepositoryRow(IWebDriver driver, IWebElement rowElement) 
            : base(driver)
        {
            _rowElement = rowElement;
        }

        public string Name => _rowElement.Text;
        public RepositoryPageCodeTab GoToRepository()
            => _rowElement.ClickAndContinueTo<RepositoryPageCodeTab>();
    }
}