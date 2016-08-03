using GmailTest.Framework.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace GmailTest.Framework.WebDriver
{
    public class DriverContext
    {
        private static readonly ThreadLocal<IWebDriver> DriverInstance = new ThreadLocal<IWebDriver>();
        private static readonly string BrowserType = ConfigManager.BrowserType;

        public void StartDriver()
        {
            if (SetDriver().Equals(null))
            {
                SetDriver();
            }
            DriverInstance.Value.Manage().Window.Maximize();
            DriverInstance.Value.Navigate().GoToUrl(ConfigManager.TestUrl);
        }

        public IWebDriver SetDriver()
        {
            if (DriverInstance.Value == null)
            {
                DriverInstance.Value = StartEmbededWebDriver(BrowserType);
            }
            return DriverInstance.Value;
        }

        public static IWebDriver Instance
        {
            get
            {
                return DriverInstance.Value;
            }
        }

        private static IWebDriver StartEmbededWebDriver(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    return StartFirefox();
                case "Chrome":
                    return StartChrome();
                case "InternetExplorer":
                    return StartInternetExplorer();
                default:
                    throw new ArgumentException(String.Format(@"<{0}> was not recognized as supported browser.", browserName));
            }
        }

        private static InternetExplorerDriver StartInternetExplorer()
        {
            var internetExplorerOptions = new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnableNativeEvents = false,
                UnexpectedAlertBehavior = InternetExplorerUnexpectedAlertBehavior.Ignore,
                EnsureCleanSession = true
            };
            return new InternetExplorerDriver(InternetExplorerDriverService.CreateDefaultService(), internetExplorerOptions);
        }

        private static FirefoxDriver StartFirefox()
        {
            var firefoxProfile = new FirefoxProfile
            {
                AcceptUntrustedCertificates = true,
                EnableNativeEvents = false
            };
            return new FirefoxDriver(firefoxProfile);
        }

        private static ChromeDriver StartChrome()
        {
            var chromeOptions = new ChromeOptions();
            return new ChromeDriver(ChromeDriverService.CreateDefaultService(), chromeOptions);
        }

        public void CloseDriver()
        {
            if (DriverInstance.Value != null)
            {
                DriverInstance.Value.Quit();
                DriverInstance.Value = null;
            }
        }
    }
}
