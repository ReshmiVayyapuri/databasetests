# SpecFlowDemo
Demonstration of specification-by-example on GitHub pages using SpecFlow, NUnit 3 and Selenium Web-Driver

## Synopsis

The project is demonstration of Specification-By-Example (BDD) on GitHub login and dashboard pages. With Cucumber (Gherkin) features implemented by SpecFlow. The implementation of the steps is using Selenium WebDriver using best practices of Selenium (PageObjects,etc.) together with best practices of SpecFlow.

## Code Example
```Gherkin
@Login
Feature: Login success
	In order to access to my Github account
	As a user with existing account
	I want to be able to sign in to GitHub 
  
Scenario: Login with email and password
	Given I am in the login page
	When I login by email and password
	Then I should see the dashboard
```
##### The implementation
```C#
        [When(@"I login by email and password")]
        public void WhenILoginByEmailAndPassword()
        {
            var user = TestConfiguration.GitHubUser;
            loginPage.LoginSuccess(user.Email, user.Password);
        }
```

## Motivation

A short description of the motivation behind the creation and maintenance of the project. This should explain **why** the project exists.

## Installation

Provide code examples and explanations of how to get the project.

## API Reference

Depending on the size of the project, if it is small and simple enough the reference docs can be added to the README. For medium size to larger projects it is important to at least provide a link to where the API reference docs live.

## Tests

Describe and show how to run the tests with code examples.

## Contributors

Let people know how they can dive into the project, include important links to things like issue trackers, irc, twitter accounts if applicable.

## License

A short snippet describing the license (MIT, Apache, etc.)
