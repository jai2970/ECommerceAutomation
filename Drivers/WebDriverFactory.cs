using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Drivers
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return new ChromeDriver(options);
        }
    }
}
