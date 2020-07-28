Feature: Add new employee timesheet
	In order to keep track employees working hours per week
	As an accountant
	I want to be able to create new employee timesheet


Scenario: Trigger field validation message when incorrect data provided
	Given the user is on the timesheet home page
	And the user clicks on Create New button
	When the user completes the form with invalid data
	And click on the Save button
	Then day field validation message should be triggered notifying the user

Scenario: User navigates to new timesheet page
	Given the user is on the timesheet home page
	When the user clicks on Create New button
	Then the user should be redirected to new timesheet page