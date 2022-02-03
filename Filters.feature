Feature: Filters
	
Background: 	
	Given user on the MoskvaAndMe homepage
	And user press on kosmetika-i-gigiena button

@mytag
Scenario: Choice brand manufacturer
	When user presses the manufacturer button
	And user choose BioMio brand
	Then user sees in the list BioMio

Scenario: Selection of products in stock
    When user clicks the In stock button
	Then user sees in the list products available

Scenario: Choice manufacturer country
    When user presses the manufacturer country button
	And user selects country russia
	Then user sees in the list selena shampoo

Scenario: Alphabetical sorting
    When user presses the organic certificate button
	And product selection is USDA certified
	Then user sees in the list product organic coconut oil