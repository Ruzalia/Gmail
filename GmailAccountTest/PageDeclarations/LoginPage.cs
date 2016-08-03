using GmailTest.Framework.Helpers;
using GmailTest.Framework.WebPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTest.PageDeclarations
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "Email")]
        protected IWebElement EmailInput { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        protected IWebElement NextButton { get; set; }

        [FindsBy(How = How.Id, Using = "Passwd")]
        protected IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "PersistentCookie")]
        protected IWebElement RememberMeCheckbox { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        protected IWebElement SignInButton { get; set; }

        public void enterEmail(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);
        }

        public void enterPassword(string password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }

        public void Login(string email, string password)
        {
            enterEmail(email);
            NextButton.Click();
            WaitHelper.WaitForElementAccessable(PasswordInput, WaitHelper.DefaultTimeStep, "Password Input");
            enterPassword(password);
            if (RememberMeCheckbox.Selected)
            {
                RememberMeCheckbox.Click();
            }
            SignInButton.Click();
        }
    }
}
