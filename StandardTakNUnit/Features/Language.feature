Feature: Language
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag

Scenario:Check if user could signin Homepage
          Given:I enter url
		  When:I enter EmailID and Password
		  Then: I should be on the HomePage

Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

	Scenario Outline: TC2 Check if user could able to add  maximum of 4 languages 
	Given I clicked on the Language tab under Profile page
	When  I add four new Languages <Language> and <Level> with <expected> languages added
	Then  should be able to add four languages only
	Examples:
	| Language | Level | Expected |
	| English  | Basic | English  |
	| Telugu   | Basic | Telugu   |
	| Hindi    | Basic | Hindi    |
	| French   | Basic | French   |
	
	
Scenario Outline: TC3 Check if the user gets a message to enter all details if missed Field while adding a language
		Given I clicked on the Language tab under Profile page
		#When I add a new language by not entering one of the fields <Language> and <Level>  
			When I add new Languages <Language> and <Level>
		Then there should be a pop up Please enter language and level <Expected>
Examples: 

		| Language | Level | Expected                        |
		| English  |       | Please enter language and level |
		|          | Basic | Please enter language and level |


	

Scenario: Check if the user could able to edit a Language 
		Given I clicked on the Language tab under Profile page
		When I add a new Language
		And Try to Edit the Language and update
		Then that new Language should be displayed on my listings

Scenario: Check if the user could able to cancel editing a Language
		Given I clicked on the Language tab under Profile page
		When I add a new Language
		And I try to click on Edit and click on cancel button
		Then that same Language details should be displayed on my listing

Scenario: Check if the user could able to get a message when trying to update a Language without modifing any input
		Given I clicked on the Language tab under Profile page
		When I add a new Language
		And Try not to Edit anything and click on update
		Then I should able to get an error message "This Information is already exist"

Scenario: Check if the user could able to delete a Language
		Given I clicked on the Language tab under Profile page
		When I add a new Language
		And Try to Delete the Language
		Then that Language should not be displayed on my listings

Scenario: Check if the user could able to cancel adding a Language
		Given I clicked on the Language tab under Profile page
		When I cancel adding a new Language
		Then that Language should not be displayed on my listings

Scenario: Check if the user is able to get a pop up if entered same Language details which already exist
		Given I clicked on the Language tab under Profile page
		When I add a new Language
		And I add the same Language details again
		Then I should able to get an error message "This Information is already exist"
