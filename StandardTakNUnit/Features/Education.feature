Feature: Education

In order to update my profile 
	As a skill trader
	I want to add the Education that I know


@mytag

Scenario:Check if user could signin Homepage
          Given:I enter url
		  When:I enter EmailID and Password
		  Then: I should be on the HomePage

		  @Education
Scenario Outline: 1-Add education
	Given I clicked on the Education tab under Profile page
	When  I add my education including <Country>, <University>, <Title>, <Degree>, <Graduation Year>
	Then I am able to see my education details including <Country>, <University>, <Title>, <Degree>, <Graduation Year>
	Examples:
	| Country     | University                      | Title  | Degree  | Graduation Year |
	| New Zealand | Whitireia Community Polytechnic | M.Tech | Diploma | 2021            |
	| Venezuela   | Hhutech University              | B.A    | Diploma | 2011            |


Scenario: Check if user could able to add  education
	Given I clicked on the Education tab under Profile page
	When I add a new Education
	Then that Education should be displayed on my listings

	Scenario: Check if the user gets a message to enter all details if missed any field while adding a education
		Given I clicked on the Education tab under Profile page
		When I add a new education by missing one field
		Then there should be a pop up Please enter all the fields

Scenario: Check if the user could able to edit a Education 
		Given I clicked on the Education tab under Profile page
		When I add a new Education
		And Try to Edit the Education and update
		Then that new Education should be displayed on my listings

Scenario: Check if the user could able to cancel editing a Education
		Given I clicked on the Education tab under Profile page
		When I add a new Education
		And I try to click on Edit and click on cancel button
		Then that same Education details should be displayed on my listing

Scenario: Check if the user could able to get a message when trying to update a Education without modifing any input
		Given I clicked on the Education tab under Profile page
		When I add a new Education
		And Try not to Edit anything and click on update
		#Then I should able to get an error message "This Information is already exist"

Scenario: Check if the user could able to delete a Education
		Given I clicked on the Education tab under Profile page
		When I add a new Education
		And Try to Delete the Education
		Then that Education should not be displayed on my listings

Scenario: Check if the user could able to cancel adding a Education
		Given I clicked on the Education tab under Profile page
		When I cancel adding a new Education
		Then that Education should not be displayed on my listings

Scenario: Check if the user is able to get a pop up if entered same Education details which already exist
		Given I clicked on the Education tab under Profile page
		When I add the same Education details again
		Then I should able to get an error message This information is already exist.
