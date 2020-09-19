Feature: ProfileDetails_Certifications
        The functionalities of Certifications

@profile_Certifications
Scenario Outline: Verify the user is able to add new certification
	Given Click Certifications Tab
	Given Click Add New certification button
	And Enter the "<Certificate>", "<From>" and "<Year>"
	When Click Add
	#Then The <Certificate>", "<From>" and "<Year>" should be displayed
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Certificate     | From  | Year | Notification                                                               |
	| Sdf             | Adobe | 2017 | has been added to your certification                                       |
	| ISTQB Fundation |       |      | Please enter Certification Name, Certification From and Certification Year |
	|                 | ISTQB |      | Please enter Certification Name, Certification From and Certification Year |
	|                 |       | 2010 | Please enter Certification Name, Certification From and Certification Year |
	| Sdf             | Adobe | 2017 | This information is already exist.                                         |
	| Sdf             | Adobe | 2020 | Duplicated data                                                            |

Scenario Outline: Verify the user is able to cancel adding the certification item
	Given Click Add New certificate button
	And Enter the certification values"<Certificate>","<From>" and "<Year>"
	When Click Cancel add certificate button
	Then The alert dialog should not be displayed

	Examples: 
	| Certificate     | From  | Year |
	| Sde             | Adobe | 2017 |

Scenario Outline: Verify the user is able to edit the certification item
	Given Click the certification item edit button
	And Enter the certification values"<Certificate>","<From>" and "<Year>"
	When Click update certificate button
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Certificate | Level  | Notification                           |
	| Chinese     | Fluent | has been updated to your certification |

Scenario Outline: Verify the user is able to cancel edit the certification item
	Given Click the certification item edit button
	And Enter the certification values"<Certificate>","<From>" and "<Year>"
	When Click Cancel update certificate button
	Then The alert dialog should not be displayed

	Examples: 
	| Certificate | Level  |
	| Chinese  | Fluent |

Scenario Outline: Verify the user is able to delete the certification item
	Given Click the certification item delete button
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Notification                             |
	| has been deleted from your certification |

