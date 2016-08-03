using GmailTest.Framework.Helpers;
using GmailTest.Framework.WebPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTest.PageDeclarations
{
    public class InboxPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".z0 div")]
        protected IWebElement NewMessageButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "vh")]
        protected IWebElement MessageSentConfirmation { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'mail/#inbox')]")]
        protected IWebElement InboxMessageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='UI'])[1]")]
        protected IWebElement FirstInboxMessage { get; set; }

        public void ClickOnNewMessageButton()
        {
            NewMessageButton.Click();
        }

        public IWebElement GetMessageSentConfirmation()
        {
            return MessageSentConfirmation;
        }

        public string GetConfirmationText()
        {
            return MessageSentConfirmation.GetAttribute("value");
        }

        public void ClickOnInboxLink()
        {
            WaitHelper.WaitForElementAccessable(InboxMessageLink, WaitHelper.DefaultTimeOutMilliseconds, "Inbox messages link");
            InboxMessageLink.Click();
        }

        public void ClickOnFirstMessage()
        {
            WaitHelper.WaitForElementAccessable(FirstInboxMessage, WaitHelper.DefaultTimeOutMilliseconds, "First message");
            FirstInboxMessage.Click();
        }
    }
}
