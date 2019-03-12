Feature: GoogleSearch
Feature to search Google search functionality

@SmokeTest
Scenario: Google Search for Execute Automation
	Given I have navigated to Google page
	And I see the google page fully loaded
	When I type search keyword as
	| Keyword            |
	| execute automation |
	Then I should see the result for keyword
	| Keyword            |
	| Execute Automation |
