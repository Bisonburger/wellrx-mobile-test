Feature: WelcomePage

 Scenario: Welcome with a valid invite code

    Given I start the app the first time
    And I am on the welcome page
    When I indicate I have an invite code
    And I supply an invite code of "<code>"
    Then I should be navigated to the create-account page

Scenario:  Welcome with an invalid invite code

    Given I start the app for the first time
    And I am on the welcome page
    When I indicate I have an invite code
    And I supply an invite code of "<code>"
    Then I see an error message of invalid invite code
    And I remain on the same page

Scenario:  Welcome with no invite code
    Given I start the app for the first time
    And I am on the welcome page
    When I indicate I do not have an invite code
    And I navigate through the on-boarding tutorial
    Then I am navigated to the home page

Scenario:  Welcome with existing login
    Given I start the app for the first time
    And I am on the welcome page
    When I indicate I have an existing login
    Then I am navigated to the login page 