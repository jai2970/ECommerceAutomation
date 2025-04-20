using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

public IWebElement UsernameInput => _driver.FindElement(By.Id("username"));
public IWebElement PasswordInput => _driver.FindElement(By.Id("password"));
public IWebElement LoginButton => _driver.FindElement(By.Id("submit"));
public IWebElement ErrorMessage => _driver.FindElement(By.Id("error"));



        public void Login(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        

        try
    {
        var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        wait.Until(driver => ErrorMessage.Displayed);
    }
    catch (WebDriverTimeoutException)
    {
        // Ignore if login is successful
    }
        }
    }
}
