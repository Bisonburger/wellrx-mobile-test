Feature: LogIn

Background:

    Given I am on the log in page

Scenario: Log In - valid credentials and Log out TC729
    When I log in as existing user
    Then I should be navigated to the home page
    When I choose to log out
    Then I should be navigated to the log in page

Scenario: Log In - invalid credentials TC730
    When I attempt to log in with invalid credentials
    Then I should see a message reads as
    """
    Invalid user name or password. Please try again.
    """
   # There is an odd issue that when the error message displays it makes some objects invisble to automation. When that is resloved these stpes can be put back in.
   # When I attempt to login again using valid credenticals
   # Then I should be navigated to the home page


Scenario: Log In - forgot password TC732
    When I choose forgot password link
    Then I should see forgot password? popup

Scenario: Forgot password - Email field validation TC734
    When I choose forgot password link
    And I enter an invalid email address in the forgot password popup
    Then the ok button on the forgot password popups should be disabled
    When I enter an valid email address in the forgot password popup
    Then the ok button on the forgot password popups should be enabled

Scenario: Forgot password - Unregistered email TC735
    When I choose forgot password link
    And I enter an unregistered email address in the forgot password popup
    And I select ok button on the forgot password popups
    Then I should see a message reads as
    """
    The entered email address does not exist in our system
    """


 Scenario: Forgot password - Sucess TC736
    When I choose forgot password link
    And I enter an registered email address in the forgot password popup
    And I select ok button on the forgot password popups
    Then I should see a message reads as
    """
    A reset password link has been sent to your registered email address
    """

 # Scenario: Log In - Remember me
    # When I choose Remember Login Information
    # When I exit the app relaunch the app again
    # And I log in as existing user
    # Then I should be navigated to the home page
    # When I exit the app relaunch the app again
    # Then I should be navigated to the home page
