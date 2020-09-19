Feature: ProfileDetails_Skills
        The functionalities of Skills

@profile_skills
Scenario Outline: Verify the user is able to add new skills
	Given Click Skills Tab
	Given Click Add New skill button
	And Enter the values of "<Skill>" and "<Level>"
	When Click Add skill
	#Then The "<skills>" and "<Level>" should be displayed
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Skill    | Level        | Notification                                    |
	| Selenium | Beginner     | has been added to your skills                   |
	| c++      | Intermediate | has been added to your skills                   |
	|          | Intermediate | Please enter skill and experience level         |
	| c#       |              | Please enter skill and experience level         |
	| Selenium | Beginner     | This skill is already exist in your skill list. |
	| Selenium | Expert       | Duplicated data                                 |

Scenario Outline: Verify the user is able to cancel adding the skill item
	Given Click Add New skill button
	And Enter the values of "<Skill>" and "<Level>"
	When Click Skill Cancel add button
	Then The alert dialog should not be displayed

	Examples: 
	| Skill | Level    |
	| Java  | Beginner |

Scenario Outline: Verify the user is able to edit the skills item
	Given Click the skills item edit button
	And Enter the values of "<Skill>" and "<Level>"
	When Click Skill Update
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Skill | Level    | Notification                    |
	| Java  | Beginner | has been updated to your skills |

Scenario Outline: Verify the user is able to cancel edit the skill item
	Given Click the skill item edit button
	And Enter the values of "<Skill>" and "<Level>"
	When Click Skill Cancel edit
	Then The alert dialog should not be displayed

	Examples: 
	| Skill | Level    |
	| Java  | Beginner |

Scenario Outline: Verify the user is able to delete the skill item
	Given Click the skill item delete button
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Notification     |
	| has been deleted |