Feature: As a user I want to add new user

@addUser
Scenario Outline: Creating a new user
Given User is on a Main Page
When User click on user list
And User click on add new user button
And User write <name>, <surname>, <phone number>, <email> and <role>
And User click save
Then User see results

Examples:
|     name     |   surname   | phone number |    email    |     role     |
| TestowyJuzek |    Józef	 | 555444333    | Juzz@ek.com | Wolontariusz |