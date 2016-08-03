using GmailTest.Framework.Helpers;
using GmailTest.PageDeclarations;
using TechTalk.SpecFlow;

namespace GmailAccountTest.FeatureSteps
{
    [Binding]
    public sealed class InboxPageSteps
    {
        private readonly InboxPage _inboxPage;

        public InboxPageSteps()
        {
            _inboxPage = new InboxPage();
        }

        [When(@"I click New Message Button within Inbox page")]
        public void WhenIClickNewMessageButtonWithinInboxPage()
        {
            _inboxPage.ClickOnNewMessageButton();
        }

        [When(@"I wait for confirmation that message was sent within Inbox page")]
        public void WhenIWaitForConfirmationThatMessageWasSentWithinInboxPage()
        {
            WaitHelper.WaitForElementAccessable(_inboxPage.GetMessageSentConfirmation(), WaitHelper.DefaultTimeOutMilliseconds, "Confirmation that Message was sent");
        }

        [When(@"I click on Inbox link within Inbox page to refresh inbox messages")]
        public void WhenIClickOnInboxLinkWithinInboxPageToRefreshInboxMessages()
        {
            _inboxPage.ClickOnInboxLink();
        }

        [When(@"I click on first message within Inbox page")]
        public void WhenIClickOnFirstMessageWithinInboxPage()
        {
            _inboxPage.ClickOnFirstMessage();
        }
    }
}
