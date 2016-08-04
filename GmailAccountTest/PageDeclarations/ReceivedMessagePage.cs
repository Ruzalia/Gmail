using GmailTest.Framework.Helpers;
using GmailTest.Framework.WebPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTest.PageDeclarations
{
    public class ReceivedMessagePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "h2.hP")]
        protected IWebElement SubjectText { get; set; }

        [FindsBy(How = How.ClassName, Using = "gD")]
        protected IWebElement SenderName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.a3s div[dir='ltr']")]
        protected IWebElement MessageText { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".iH .ar9")]
        protected IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "gb_3a")]
        protected IWebElement AvatarButton { get; set; }

        [FindsBy(How = How.Id, Using = "gb_71")]
        protected IWebElement SignOutButton { get; set; }

        public string GetSenderInformationText()
        {
            WaitHelper.WaitForLoadDynamicContent();
            WaitHelper.WaitForElementAccessable(SenderName, WaitHelper.DefaultTimeOutMilliseconds, "Text information about sender");
            return SenderName.Text;
        }

        public string GetSubjectText()
        {
            return SubjectText.Text;
        }

        public string GetMessageText()
        {
            return MessageText.Text;
        }

        public void DeleteMessage()
        {
            DeleteButton.Click();
        }

        public void ClickOnAvatarButton()
        {
            WaitHelper.WaitForElementAccessable(AvatarButton, WaitHelper.DefaultTimeOutMilliseconds);
            AvatarButton.Click();
        }

        public void ClickOnSignOutButton()
        {
            WaitHelper.WaitForElementAccessable(SignOutButton, WaitHelper.DefaultTimeOutMilliseconds);
            SignOutButton.Click();
        }

        public void SignOut()
        {
            ClickOnAvatarButton();
            ClickOnSignOutButton();
        }
    }
}
