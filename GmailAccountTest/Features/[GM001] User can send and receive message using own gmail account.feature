@SendReceiveMessage
Feature: Base Functionality - [GM001] User can send and receive message using own gmail account
	In order to be in touch with people via electronic mail
	As an authorized user with active account
	I want to be able to send message to definite receiver and to receive message
	from other authorized user with correct sender name and message text

	Background: 
 	Given I log in as user with active acount in Gmail

Scenario Outline: Base Functionality - [GM001] User can send and receive message using own gmail account
	When I click New Message Button within Inbox page
	And I enter Email address "<ReceiverAddress>" into Receiver Address field on New Message modal window within Inbox page
	And I enter Subject "<Subject>" into Subject field on New Message modal window within Inbox page
	And I enter Message Text "<Text>" into Message Text textarea on New Message modal window within Inbox page
	And I click Send button on New Message modal window within Inbox page
	And I wait for confirmation that message was sent within Inbox page
	And I click on Inbox link within Inbox page to refresh inbox messages
	And I click on first message within Inbox page
	Then I verify that Sender information contains sender first name "<SenderName>" and last name "<SenderSurname>"
	And I verify that Subject is the same as "<Subject>"
	And I verify that Message Text is the same as "<Text>"
	
	Examples: 
	| ReceiverAddress            | Subject   | Text                                | SenderName | SenderSurname |
	| ruzaliia.preprod@gmail.com | Cheer Up! | Hi! You are cool! Have a great day! | Ruzaliia   | Yakunina      |
