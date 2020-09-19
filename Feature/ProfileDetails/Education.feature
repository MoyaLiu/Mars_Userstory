Feature: ProfileDetails_Education
        The functionalities of Education

@profile_Education
Scenario Outline: Verify the user is able to add new education
	Given Click Education Tab
	Given Click Add New education button
	And Enter the education values "<University>", "<Country>", "<Title>", "<Degree>" and "<Graduation Year>"
	When Click Add
	#Then The "<University>", "<Country>", "<Title>", "<Degree>" and "<Graduation Year>" should be displayed
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| University | Country | Title  | Degree | Graduation Year | Notification                       |
	| Sdf        | Canada  | B.Tech | 98     | 2018            | has been added                     |
	| IST        | Canada  | BFA    | sdf    | 2010            | has been added                     |
	|            | Albania |        | 108    | 2009            | Please enter all the fields        |
	| Sdf        | Canada  | B.Tech | 98     | 2018            | This information is already exist. |

Scenario Outline: Verify the user is able to cancel adding the education item
	Given Click Add New education button
	And Enter the education values "<University>", "<Country>", "<Title>", "<Degree>" and "<Graduation Year>"
	When Click education Cancel add button
	Then The alert dialog should not be displayed

	Examples: 
	| University | Country | Title  | Degree | Graduation Year |
	| Sdf        | China   | MFA    | 98     | 2012            |

Scenario Outline: Verify the user is able to edit the education item
	Given Click the education item edit button
	And Enter the education values "<University>", "<Country>", "<Title>", "<Degree>" and "<Graduation Year>"
	When Click education Update
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| University | Country | Title  | Degree | Graduation Year | Notification    |
	| Sdf        | China   | B.Tech | 98     | 2018            | as been updated |

Scenario Outline: Verify the user is able to cancel edit the education item
	Given Click the education item edit button
	And Enter the education values "<University>", "<Country>", "<Title>", "<Degree>" and "<Graduation Year>"
	When Click education Cancel edit button
	Then The alert dialog should not be displayed

	Examples: 
	| University | Country | Title  | Degree | Graduation Year |
	| Sdf        | China   | MFA    | 98     | 2012            |

Scenario Outline: Verify the user is able to delete the education item
	Given Click the education item delete button
	Then The alert dialog "<Notification>" should be displayed

	Examples: 
	| Notification               |
	| entry successfully removed |