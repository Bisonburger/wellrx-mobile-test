Feature: WelcomePage


# Scenario: Welcome Page - default view and options TC1183

    # :Given I installed the app the first time
    # :When I lanuch the app
    #  When I am on the login page
    # Then I should be presented with following options
    # |Options|
    # |Yes invite code|
    # |No invite code|
    # |Already have an account|


 Scenario: Welcome Page - Yes Invite Code TC1184

    :Given I installed the app the first time
    :When I lanuch the app
    When I choose to move forward with an invite code
    Then I should be navigated to the create account page

 Scenario: Welcome Page - No Invite Code TC1185

    :Given I installed the app the first time
    :When I lanuch the app
    When I choose to move forward without an invite code and past on boarding tutorial screens
    Then I should be navigated to the home page

  Scenario: Welcome Page - already have an account TC1186

    :Given I installed the app the first time   
    :When I lanuch the app
    When I am on the login page
    Then I should be navigated to the log in page

  Scenario: WelcomePage - Invalid InviteCode TC744
    :Given I installed the app the first time
    :When I lanuch the app
    Given I choose to move forward with an invalid invite code
    Then I should see an error message reads as for invalid invite code
    """
    Invalid invite code
    """
 