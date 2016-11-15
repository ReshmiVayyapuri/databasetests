@Dashboard
Feature: Links from the dashboard
	In order to navigate to other pages
	As a logged in user in the dashboard
	I want have some links in the dashboard

	
Scenario: User can explore GitHub from the dashboard
	Given I am in the dashboard
	When I click Explore GitHub
	Then I should see the Project showcases page