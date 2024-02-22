Feature: Profile

A short summary of the feature

@tag1

 Scenario Outline: Outline: Edit Availability
	Given I click on edit for Availability
	When select <availabilitytype>
	Then that <availabilitytype> should be displayed
	Examples:
	| availabilitytype |
	| Full Time        |
	| Part Time        |


	 Scenario Outline: Outline: Edit AvailabilityHours
	Given I click on edit for AvailabilityHours
	When selectAvailabilityHours <AvailabilityHours>
	Then <AvailabilityHours>should display with updated hours
	
	Examples:
	| AvailabilityHours        |
	| Less than 30hours a week |
	| More than 30hours a wee  |
	| As needed                |

		 Scenario Outline: Outline: Edit EarnTarget
	Given I click on edit for EarnTarget
	When selectEarnTarget <EarnTarget>
	Then <EarnTarget>should display with updated EarnTarget
	
	Examples:
	| EarnTarget                |
	| Less than $500 per month  |
	| Between $500 and 1000 per month |
	| More than $1000 per month |