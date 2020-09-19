Feature: ProfileDescription
         The functionalities of description 

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