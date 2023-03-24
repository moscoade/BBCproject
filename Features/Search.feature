Feature: Search
In order to use BBC
I need to navigate to the website


Scenario: Search
	Given I navigate to BBc Website "https://www.bbc.co.uk/"
	And I click on search BBC
	And I enter "Sport" in search field
	When I click on search
	Then Sport should displayed


Scenario: New Search
	Given I navigate to BBc Website "https://www.bbc.co.uk/"
	And I click on search BBC
	And I enter "European news" in search field
	When I click on search
	Then European news should displayed
