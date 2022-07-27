@Login
Feature: Database Testing

Scenario: Sample Scenario

	Given I connect to First DB 
	When I fetch first results and save
	And I connect to Second DB 
	When I fetch second results and save
	Then  compare boths results
