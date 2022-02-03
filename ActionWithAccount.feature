Feature: ActionWithAccount
	Simple test

Background:
	Given user on the andMe homepage


Scenario: Registration
    When user click on registration button
	And user put data
	And user press button registration
	Then user sees the personal area

@regression
Scenario: Authorization
	When user clicks on the Enter button
	And user put data for authorization
	And user press button authorization
	Then  user sees the personal area1


@regression
Scenario: Add data to address 
	When user clicks on the Enter button
	And user put data for authorization
	And user press button authorization
	And user press button myAccount
	And user press button myAdress
	And user add adess
	And user add data to adress
	Then user sees another adress


@regression
Scenario: Sign out
	When user clicks on the Enter button
	And user put data for authorization
	And user press button authorization
	And user press button myAccount
	And user press button SingOut
	Then user sees the Enter button