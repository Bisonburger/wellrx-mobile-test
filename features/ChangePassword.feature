Feature: Change Password

    

Scenario: Change Password - Valid Current and New Passwords TC895
    Given I am on change password page
    Then the update password button should be disabled
    When I enter valid current and new Password
    And I choose to update the password
    Then I should be back on the More menu


 Scenario: Change password - invalid current password TC1582
    Given I am on change password page
    When I enter invalid current and new Password
    And I choose to update the password
    Then I should see Change Password message reads as
    """
    Invalid current password
    """
    And I should be back on the change password page

 Scenario: Change password - invalid new password TC1583
    Given I am on change password page
    When I enter valid current and invalid new Password
    Then the update password button should be disabled