﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GmailAccountTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class BaseFunctionality_GM001UserCanSendAndReceiveMessageUsingOwnGmailAccountFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "[GM001] User can send and receive message using own gmail account.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Base Functionality - [GM001] User can send and receive message using own gmail ac" +
                    "count", "\tIn order to be in touch with people via electronic mail\r\n\tAs an authorized user " +
                    "with active account\r\n\tI want to be able to send message to definite receiver and" +
                    " to receive message\r\n\tfrom other authorized user with correct sender name and me" +
                    "ssage text", ProgrammingLanguage.CSharp, new string[] {
                        "SendReceiveMessage"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Base Functionality - [GM001] User can send and receive message using own gmail ac" +
                            "count")))
            {
                GmailAccountTest.Features.BaseFunctionality_GM001UserCanSendAndReceiveMessageUsingOwnGmailAccountFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
 #line 9
  testRunner.Given("I log in as user with active acount in Gmail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void BaseFunctionality_GM001UserCanSendAndReceiveMessageUsingOwnGmailAccount(string receiverAddress, string subject, string text, string senderName, string senderSurname, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Base Functionality - [GM001] User can send and receive message using own gmail ac" +
                    "count", exampleTags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 8
 this.FeatureBackground();
#line 12
 testRunner.When("I click New Message Button within Inbox page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And(string.Format("I enter Email address \"{0}\" into Receiver Address field on New Message modal wind" +
                        "ow within Inbox page", receiverAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And(string.Format("I enter Subject \"{0}\" into Subject field on New Message modal window within Inbox" +
                        " page", subject), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And(string.Format("I enter Message Text \"{0}\" into Message Text textarea on New Message modal window" +
                        " within Inbox page", text), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("I click Send button on New Message modal window within Inbox page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("I wait for confirmation that message was sent within Inbox page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I click on Inbox link within Inbox page to refresh inbox messages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I click on first message within Inbox page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then(string.Format("I verify that Sender information contains sender first name \"{0}\" and last name \"" +
                        "{1}\"", senderName, senderSurname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And(string.Format("I verify that Subject is the same as \"{0}\"", subject), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And(string.Format("I verify that Message Text is the same as \"{0}\"", text), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Base Functionality - [GM001] User can send and receive message using own gmail ac" +
            "count: ruzaliia.preprod@gmail.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Base Functionality - [GM001] User can send and receive message using own gmail ac" +
            "count")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SendReceiveMessage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "ruzaliia.preprod@gmail.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ReceiverAddress", "ruzaliia.preprod@gmail.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Subject", "Cheer Up!")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Text", "Hi! You are cool! Have a great day!")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SenderName", "Ruzaliia")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SenderSurname", "Yakunina")]
        public virtual void BaseFunctionality_GM001UserCanSendAndReceiveMessageUsingOwnGmailAccount_Ruzaliia_PreprodGmail_Com()
        {
            this.BaseFunctionality_GM001UserCanSendAndReceiveMessageUsingOwnGmailAccount("ruzaliia.preprod@gmail.com", "Cheer Up!", "Hi! You are cool! Have a great day!", "Ruzaliia", "Yakunina", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion