Feature: As a user i want to be eable to add post

@addPost
Scenario Outline: Creating a new post
Given Im on Main Page
When I go to News page
And I press add new info button
When I wrote <title> and <newsText>
And  I press Save
Then I see post with this <title> and <newsText> was created
Examples: 
| title                  | newsText                   |
| Test automatyczny      |     Tekst Automatyczny     |

