@Login
Feature: Login expecting failure
	In order to access to my Github account only with valid credentials
	As a user with invalid credentials
	I want to not by able to sign to GitHub

	
Scenario: User should not login with invalid password
	Given I am in the login page
	When I fill the email address with "SpecFlowDemo"
	And I fill the password with "wrong password"
	And I click Sign in
	Then I should see an error message "Incorrect username or password."