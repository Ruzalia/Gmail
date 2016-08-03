using GmailTest.PageDeclarations;
using TechTalk.SpecFlow;

namespace GmailAccountTest.FeatureSteps
{
    [Binding]
    public sealed class NewMessagePageSteps
    {
        private readonly NewMessagePage _newMessagePage;

        public NewMessagePageSteps()
        {
            _newMessagePage = new NewMessagePage();
        }

        [When(@"I enter Email address ""(.*)"" into Receiver Address field on New Message modal window within Inbox page")]
        public void WhenIEnterEmailAddressIntoReceiverAddressFieldOnNewMessageModalWindowWithinInboxPage(string address)
        {
            _newMessagePage.EnterReceiverAddress(address);
        }

        [When(@"I enter Subject ""(.*)"" into Subject field on New Message modal window within Inbox page")]
        public void WhenIEnterSubjectIntoSubjectFieldOnNewMessageModalWindowWithinInboxPage(string subject)
        {
            _newMessagePage.EnterSubject(subject);
        }

        [When(@"I enter Message Text ""(.*)"" into Message Text textarea on New Message modal window within Inbox page")]
        public void WhenIEnterMessageTextIntoMessageTextTextareaOnNewMessageModalWindowWithinInboxPage(string text)
        {
            _newMessagePage.EnterMessageText(text);
        }

        [When(@"I click Send button on New Message modal window within Inbox page")]
        public void WhenIClickSendButtonOnNewMessageModalWindowWithinInboxPage()
        {
            _newMessagePage.ClickOnSendMessageButton();
        }

    }
}
