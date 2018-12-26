Feature: WelcomePage

 Scenario Outline: Welcome with a valid invite code

    Given I start the app for the first time
    And I am on the "welcome" page
    When I indicate I have an invite code
    And I supply an invite code of "<code>"
    Then I am navigated to the "create" page

  Examples:
    |code|
    |VALID|

Scenario Outline:  Welcome with an invalid invite code

    Given I start the app for the first time
    And I am on the "welcome" page
    When I indicate I have an invite code
    And I supply an invite code of "<code>"
    Then I see an error message for "invalid invite code"
    And I remain on the same page

    Examples:
    |code|
    |INVALID|
    |BAD|

Scenario:  Welcome with no invite code
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
