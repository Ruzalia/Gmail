using GmailTest.Framework.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTest.Framework.WebPages
{
    public class BasePage
    {
        public IWebDriver Driver { get { return DriverContext.Instance; } }

        protected BasePage()
        {
            PageFactory.InitElements(Driver, this);
        }
    }
}
