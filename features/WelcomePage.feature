Feature: WelcomePage

 Scenario Outline: First time with a valid invite code

    Given I start the app for the first time
    And I am on the "welcome" page
    When I indicate I have an invite code
    And I supply an invite code of "<code>"
    Then I am navigated to the "create-account" page
    And I do not see an error

  Examples:
    |code|
    |VALID|

Scenario Outline:  First time with an invalid invite code

    Given I start the app for the first time
    And I am on the "welcome" page
    When I indicate I have an invite code
    And I supply an invite code of "<code>"
    Then I see an error message for "invalid code"
    And I remain on the same page

    Examples:
    |code|
    |INVALID|
    |BAD|

Scenario:  First time with no invite code
    Given I start the app for the first time
    And I am on the "welcome" page
    When I indicate I do not have an invite code
    And I navigate through the on-boarding tutorial
    Then I am navigated to the "home" page

Scenario:  Welcome with existing login
    Given I start the app for the first time
    And I am on the "welcome" page
    When I indicate I have an existing login
    Then I am navigated to the "login" page
