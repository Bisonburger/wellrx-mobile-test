Feature: EditProfile

Background: 

Given I am on manage your profile page
    
Scenario: Edit Profile - Edit Names TC889

    Given I am on the Edit Profile page
    Then the Save Updates option should be disabled
    When I change the profile user name
    Then the Save Updates option should be enabled
    When I choose to save the changes
    Then I should see my profile info

Scenario: Edit Profile - Edit Zipcode TC892

    Given I am on the Edit Profile page
    Then I should see profile pic placeholder
    And the Save Updates option should be disabled
    When I change the profile Zipcode
    Then the Save Updates option should be enabled
    When I choose to save the changes
    Then I should see my profile info
    
Scenario: Manage Profile - Edit Allergens Information TC049

   When I select the Allergens Details
   Then I should be on Edit Allergens Details
   When I need the Edit Allergens section reset
   And I select the Edit Allergens Prefrences
   Then I should see my Allergens info
   When I select the Allergens Details
   And I select the Edit Allergens Prefrences
   Then I should see my Allergens info
    
Scenario: Manage Profile - Manage Profile Tab Validation TC014

    Then I should see my profile info
    When I select the profile Savings Card
    Then I should be on the expanded Savigs Card view
    And I should see my Conditions info
    Then I should see my Allergens info
    
Scenario: Manage Profile - Preferences Tab Validation TC015

    When I select the Preferences tab
    Then I should see my Preferences Preferences Dietary info
    And I should see my Preferences Preferred Pharmacy info
    
Scenario: Manage Profile - Settings Tab Validation TC016
 
   When I select the Notifications tab
   Then I should see my Notifications info
   When I select the Notifications edit
   Then I should see the Edit Notifications screen
   When I change notification settings
   Then I should see my Notifications info
   
Scenario: Manage Profile - Edit Profile Conditions TC017

   When I select the Edit Condition Details
   Then I should be on Edit Condition Details
   When I select the Edit Condition Health Type
   And I need the Edit Condition Condition Type reset
   And I select the Edit Condition Condition Type
   Then I should see my Conditions info
   When I select the Edit Condition Details
   And I select the Edit Condition Condition Type
   
Scenario: Manage Profile - Edit Profile Dietary Prefrences TC050

   When I select the Preferences tab
   And I select the Dietary Details
   Then I should be on Edit Dietary Preferences Details
   When I need the Dietary Preferences section reset
   And I select the Edit Dietary Preferences options
   Then I should see my Preferences Preferences Dietary info
   When I select the Dietary Details
   And I select the Edit Dietary Preferences options
   Then I should see my Preferences Preferences Dietary info