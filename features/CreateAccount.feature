Feature: Create Account


Scenario: Create Account - Already have a account TC743
    Given I am on the create account page
    When I choose already have an account
    Then I should be navigated to the log in page

    
Scenario: Create Account - From welcome page TC744

    Given I navigated to the create an account page from welcome page
    Then I should see email and zipcode fields on the view
    And I should see following fields on the view
    |Fields|
    |FirstName|
    |LastName|
    |Password|
    |DOB|
    |ZipCode|

    And I should see following checkboxes on the view
    |checkbox|
    |UserAgreement|
    |Notifications|



Scenario: Create Account - Invalid Zipcode TC1225
    Given I am on the create account page
    When I enter all required info with invalid ZipCode
    And I select Get Your Savings Card
    Then I should see an error message reads as
    """
    Please enter a valid Zip Code
    """

Scenario: Create Account - Invalid Password TC749

    Given I am on the create account page
    When I enter all required info with invalid Password
    And I select Get Your Savings Card
    Then I should see an error message reads as
    """
    Password must be at least 8 characters, mixed case, with a number or special character
    """

Scenario: Create Account - Terms & Conditions TC917

    Given I am on the create account page
    When I select terms & conditions link
    Then I should be navigated to the Terms & Conditions page
    
Scenario: Create Account - Food Index create account TC024

    Given I navigated to the savings card page without login
    When I select the toobar item of Food Index
    And I select the Search Product from Food Index
    And I search for a food item with 702014604631
    And I select the Food Index tab
    Then I should be on the Create Account Page from Food Index
    When I select the Nutrition tab
    Then I should be on the Create Account Page from Food Index
    When I select the Better For Me tab
    Then I should be on the Create Account Page from Food Index
    When I select the Locked Feature Cancel button
    Then I should be on the food details summary tab
    
Scenario: Create Account - Med Chest create account TC025

    Given I navigated to the savings card page without login
    When I select the toobar item of Medicine Chest
    And I select the Med Chest Create Account
    Then I should be on the create account page