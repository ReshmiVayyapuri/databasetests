@Dashboard
Feature: See my repositories in the dashboard
	In order to navigate to repository
	As a logged in user in the dashboard
	I want see my repositories in the dashboard

		
Scenario: User can create new repository from the dashboard
	Given I am in the dashboard	
	When I click New repository
	Then I should see the create a new repository page


Scenario: User will see his repositories in the dashboard
	Given I am in the dashboard
	Then I should see my repositories


Scenario: User will can go to repository from the dashboard
	Given I am in the dashboard
	When I click the first repository
	Then I should see the repository code page