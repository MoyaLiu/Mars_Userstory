Feature: ProfileDetails_Languages
        The functionalities of Languages

@profile_language
Scenario Outline: Verify the user is able to add new languages
	Given Click Languages Tab
	And Click Add New button
	And Enter the "<Language>" and "<Level>"
	When Click Add
	#Then The "<Language>" and "<Level>" should be displayed
	Then The alert dialog "<Notification>" should be displayed
	
	Examples: 
	| Language | Level            | Notification                                          |
	| English  | Basic            | has been added to your languages                      |
	| Korean   | Conversational   | has been added to your languages                      |
	|          | Native/Bilingual | Please enter language and level                       |
	| Chinese  |                  | Please enter language and level                       |
	| English  | Basic            | This language is already exist in your language list. |
	| English  | Fluent           | Duplicated data                                       |

Scenario Outline: Verify the user is able to cancel adding the language item
	Given Click Add New button
	And Enter the "<Language>" and "<Level>"
	When Click Cancel add button
	Then The alert dialog should not be displayed

	Examples: 
	| Language | Level  |
	| Chinese  | Fluent |

Scenario Outline: Verify the user is able to edit the language item
	Given Click the language item edit button
	And Enter the "<Language>" and "<Level>"
	When Click update
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Language | Level  | Notification                       |
	| Chinese  | Fluent | has been updated to your languages |

Scenario Outline: Verify the user is able to cancel edit the language item
	Given Click the language item edit button
	And Enter the "<Language>" and "<Level>"
	When Click Cancel update button
	Then The alert dialog should not be displayed

	Examples: 
	| Language | Level  |
	| Chinese  | Fluent |

Scenario Outline: Verify the user is able to delete the language item
	Given Click the language item delete button
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Notification                         |
	| has been deleted from your languages |




