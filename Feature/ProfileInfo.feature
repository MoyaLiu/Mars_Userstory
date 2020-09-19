Feature: ProfileInfo
	The functionalities in profile page left pad.

@profile_name
Scenario Outline: Verify the user is able to edit the name
	Given Click Name 
	And Enter values in "<First Name>" and "<Last Name>" 
	When Click Save
	Then The name is display as "<First Name>""<Last Name>"

Examples:
	| First Name | Last Name |
	| Moyaa      | Lii       |

@profile_timetype
Scenario Outline: Verify the user is able to edit the availability time type
	Given Click availability edit icon
	When Choose the availability "<Time Type>"
	Then The availability should be update as "<Time Type>"
Examples:
	| Time Type |
	| Part Time |
	| Full Time |

Scenario: Verify the user is able to cancel on time type
	Given Click availability edit icon
	When Click time type cancel icon
	Then The timetype should not change

@profile_hours
Scenario Outline: Verify the user is able to edit the availability hours
	Given Click hours edit icon
	When Choose the hours "<Hours>"
	Then The Hours should be update as "<Hours>"
Examples:
	| Hours                    |
	| Less than 30hours a week |
	| More than 30hours a week |
	| As needed                |

Scenario: Verify the user is able to cancel on hours
	Given Click hours edit icon
	When Click hours cancel icon
	Then The hours should not change

@profile_target
Scenario Outline: Verify the user is able to edit the availability earn target
	Given Click target edit icon
	When Choose the target "<Earn Target>"
	Then The Earn Target should be update as "<Earn Target>"
Examples:
	| Earn Target                      |
	| Less than $500 per month         |
	| Between $500 and $1000 per month |
	| More than $1000 per month        |

Scenario: Verify the user is able to cancel on earn target
	Given Click target edit icon
	When Click target cancel icon
	Then The target should not change




