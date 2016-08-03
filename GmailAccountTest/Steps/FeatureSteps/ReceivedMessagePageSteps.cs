using GmailTest.Framework.Helpers;
using GmailTest.PageDeclarations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GmailAccountTest.FeatureSteps
{
    [Binding]
    public sealed class ReceivedMessagePageSteps
    {
        private readonly ReceivedMessagePage _receivedMessagePage;

        public ReceivedMessagePageSteps()
        {
            _receivedMessagePage = new ReceivedMessagePage();
        }

        [Then(@"I verify that Sender information contains sender first name ""(.*)"" and last name ""(.*)""")]
        public void ThenIVerifyThatSenderInformationContainsSenderFirstNameAndLastName(string firstName, string lastName)
        {
            Assert.IsTrue(_receivedMessagePage.GetSenderInformationText().Contains(firstName) && _receivedMessagePage.GetSenderInformationText().Contains(lastName));
        }

        [Then(@"I verify that Subject is the same as ""(.*)""")]
        public void ThenIVerifyThatSubjectIsTheSameAs(string subject)
        {
            Assert.AreEqual(subject, _receivedMessagePage.GetSubjectText());
        }

        [Then(@"I verify that Message Text is the same as ""(.*)""")]
        public void ThenIVerifyThatMessageTextIsTheSameAs(string text)
        {
            Assert.AreEqual(text, _receivedMessagePage.GetMessageText());
        }
    }
}
