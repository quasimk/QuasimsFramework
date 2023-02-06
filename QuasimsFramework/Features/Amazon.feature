Feature: Amazon Test

#Scenario: Logging in
#Given I am on the Amazon Homepage
#When I enter my username and password
#Then I will be logged in

Scenario: Checking Logo exists on Homepage
Given I am on the Amazon Homepage
Then the Amazon logo will be visible


Scenario: Validating the header returns the term which has been searched for
Given I am on the Amazon Homepage
When I search for "football"
Then the header will return the searched term.

Scenario: Validating an item is added to your basket
Given I search for "Coffee machine" on the homepage
When I add the item that has been searched for to basket
Then I can validate that the item has been added to the basket
