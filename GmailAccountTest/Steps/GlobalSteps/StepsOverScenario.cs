using GmailTest.Framework.WebDriver;
using GmailTest.PageDeclarations;
using TechTalk.SpecFlow;

namespace eFormsTA.StepDefinitions.GlobalSteps
{
    [Binding]
    public sealed class StepsOverScenario
    {
        private ReceivedMessagePage _receivedMessagePage;
        private DriverContext _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new DriverContext();
            _driver.StartDriver();
        }

        [AfterScenario(Order = 0)]
        public void DeleteTestData()
        {
            _receivedMessagePage = new ReceivedMessagePage();
            _receivedMessagePage.DeleteMessage();
            _receivedMessagePage.SignOut();
        }

        [AfterScenario(Order = 10)]
        public void TearDown()
        {
            _driver.CloseDriver();
        }
    }
}
