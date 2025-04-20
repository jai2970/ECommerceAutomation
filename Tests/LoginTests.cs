using NUnit.Framework;
using OpenQA.Selenium;
using Pages;
using Drivers;

namespace Tests
{
    public class LoginTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverFactory.CreateChromeDriver();
        }

        [Test]
public void Login_WithValidCredentials_ShouldSucceed()
{
    _driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");

    var loginPage = new LoginPage(_driver);
    loginPage.Login("student", "Password123");

    Assert.That(_driver.Url, Does.Contain("practicetestautomation.com/logged-in-successfully"));
}

[Test]
public void InvalidLogin_ShouldShowError()
{
    _driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
    var loginPage = new LoginPage(_driver);
    loginPage.Login("wronguser", "wrongpass");

    Assert.That(loginPage.ErrorMessage.Text, Is.EqualTo("Your username is invalid!"));
}



        [TearDown]
        public void TearDown()
        {
              if (_driver != null)
    {
        _driver.Quit();      // Closes the browser
        _driver.Dispose();   // Releases resources
    }
        }
    }
}
