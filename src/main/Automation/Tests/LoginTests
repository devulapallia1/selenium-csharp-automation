using Automation.Drivers;
using Automation.Pages;
using NUnit.Framework;

namespace Automation.Tests
{
    public class LoginTests
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverSetup.InitializeDriver();
            _driver.Navigate().GoToUrl("https://example.com/login");
            _loginPage = new LoginPage(_driver);
        }

        [Test]
        public void SuccessfulLoginTest()
        {
            _loginPage.Login("testuser", "password123");
            Assert.IsTrue(_driver.Url.Contains("dashboard"));
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}
