using GmailTest.Framework.Helpers;
using GmailTest.Framework.WebPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTest.PageDeclarations
{
    public class NewMessagePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div[role='dialog']")]
        protected IWebElement NewMessageWindow { get; set; }

        public IWebElement ReceiverName
        {
            get
            {
                return NewMessageWindow.FindElement(By.CssSelector(".nr.l1 textarea"));
            }
        }

        public IWebElement Subject
        {
            get
            {
                return NewMessageWindow.FindElement(By.ClassName("aoT"));
            }
        }

        public IWebElement MessageBody
        {
            get
            {
                return NewMessageWindow.FindElement(By.ClassName("editable"));
            }
        }

        public IWebElement SendButton
        {
            get
            {
                return NewMessageWindow.FindElement(By.ClassName("aoO"));
            }
        }

        public void EnterReceiverAddress(string address)
        {
            WaitHelper.WaitForElementAccessable(ReceiverName, WaitHelper.DefaultTimeOutMilliseconds, "Input field for receiver name");
            ReceiverName.Clear();
            ReceiverName.SendKeys(address);
        }

        public void EnterSubject(string subject)
        {
            Subject.Clear();
            Subject.SendKeys(subject);
        }

        public void EnterMessageText(string text)
        {
            MessageBody.Clear();
            MessageBody.SendKeys(text);
        }

        public void ClickOnSendMessageButton()
        {
            SendButton.Click();
        }
    }
}
