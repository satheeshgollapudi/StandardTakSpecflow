Feature: Certifications

In order to update my profile 
	As a skill trader
	I want to add the Certifications that I know


@tag1

Scenario:Check if user could signin Homepage
          Given:I enter url
		  When:I enter EmailID and Password
		  Then: I should be on the HomePage

Scenario: Check if user could able to add a Certification 
	Given I clicked on the Certifications tab under Profile page
	When I add a new certification
	Then that certification should be displayed on my listings
