@Login
Feature: Login success
	In order to access to my Github account
	As a user with existing account
	I want to be able to sign in to GitHub 


Scenario: User can login by email address
	Given I am in the login page
	When I fill the email address with "SpecFlowDemo@sharklasers.com"
	And I fill the password with "SpecFlowDemo@sharklasers.com"
	And I click Sign in
	Then I should see the dashboard


Scenario: User can login by username
	Given I am in the login page
	When I fill the username with "SpecFlowDemo"
	And I fill the password with "SpecFlowDemo@sharklasers.com"
	And I click Sign in
	Then I should see the dashboard