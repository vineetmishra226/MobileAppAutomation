Feature: AppLaunch
Launch Barfoot App within Native based application

@smoke
Scenario: Launch the application
	Given I launch the application 
	When I press allow on welcome splash page 
	Then I see the ListView page