Feature: Customer
	In order to manage Customers
	As a Turn Up portal admin
	I would like to create, edit, view and delete Customer records

@mytag
Scenario: I'd like to add customer using valid details
	Given I log in to TurnUp portal
	And I navigate to Customer page
	Then I should be able to create customer record with valid information

Scenario: I'd like to update an existing time record with update information
	Given I log in to TurnUp portal
	And I navigate to Customer page
	Then I should be able to edit customer record with updated information