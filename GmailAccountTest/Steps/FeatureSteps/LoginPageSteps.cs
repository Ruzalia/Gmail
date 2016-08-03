using GmailTest.Framework.Configuration;
using GmailTest.PageDeclarations;
using TechTalk.SpecFlow;

namespace GmailAccountTest.FeatureSteps
{
    [Binding]
    public sealed class LoginPageSteps
    {
        private readonly LoginPage _loginPage;

        public LoginPageSteps()
        {
            _loginPage = new LoginPage();
        }

        [Given(@"I log in as user with active acount in Gmail")]
        public void GivenILogInAsUserWithActiveAcountInGmail()
        {
            _loginPage.Login(ConfigManager.Username, ConfigManager.Password);
        }

    }
}
