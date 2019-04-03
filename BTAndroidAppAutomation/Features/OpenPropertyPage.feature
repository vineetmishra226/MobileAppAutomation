Feature: OpenPropertyPage
	Open a property within Native based application 

@smoke
Scenario: Open property from Auto Complete Search functionality
	Given I launch the application
	And I skip the welcome splash screen
	Then I see the ListView page
	And I click the first property image
	Then I see the Property Detail page

@smoke
Scenario: Open property from Sold Lob Listings
	Given I launch the application
	When I press allow on welcome splash page 
	Then I see the ListView page
	And I click the [NavigateUp] button
	Then I see the Search View page
	And I click the LoB Spinner button 
	Then I see the LoB Option
	Given I select Sold as LoB
	Then I click [Show Result] button
	Then I see the ListView page
	And I click the first property image
	Then I see the Property Detail page