Feature: ProfileDescription
         The functionalities of description 

#Background: 	
#	Given Click description edit icon
##	And Enter the description "<description>"
##	When Click save button
##Examples: 
##	| description    |
##	| I am a learner |
##	|                |
##	| $^$#%$@&^%&^   |
#
#@profile_description
#Scenario: Verify the user is able to save the description with valid values
#	And Enter the description
#	| description    |
#	| I am a learner |
#	When Click save button
#	Then The save successed dialog should be displayed
#
#Scenario: Verify the user is not able to save the description with empty values
#	And Enter the description
#	| description |
#	||
#	When Click save button
#	Then The empty alert dialog should be displayed
#
#Scenario: Verify the user is not able to save the description with invalid values
#	And Enter the description
#	| description   |
#	| %^$%^%$^^#^%$ |
#	When Click save button
#	Then The invalid alert dialog should be displayed

@profile_description
Scenario Outline: Verify the user is able to save the description with valid values
	Given Click description edit icon
	And Enter the description "<Description>"
	When Click save button
	Then The dialog "<Display>"should be displayed
	Examples: 
	| Description    | Display                                      |
	| I am a learner | Description has been saved successfully      |
	|                | Please, a description is required            |
	| $#%$#^$        | First character can only be digit or letters |