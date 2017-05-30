Feature: As a user I want to add new user

@addUser
Scenario Outline: Creating a new user
Given User is on a Main Page
When User click on login tile
And User login with <login> and <userPassword>
And User click on user list
And User click on add new user button
And User write <name>, <surname>, <phone number>, <email>, <newUserPassword> and <role>
And User click save
Then User see results

Examples:
| login                     | userPassword | name         | surname | phone number | email       | newUserPassword | role        |
| toz_user0.email@gmail.com | TOZ_name_0   | TestowyJuzek | Józef   | 555444333    | Juzz@ek.com | test            |Wolontariusz |