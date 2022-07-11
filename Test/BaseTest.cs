using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using testAutoation_c_sharpe_nUnit.Base;

namespace testAutoation_c_sharpe_nUnit.Test
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver;
        private readonly string _baseUrl = Constants.BaseUrl;
        
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_baseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}