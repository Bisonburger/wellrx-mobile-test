Feature: Dashboard

    
Scenario: Dashboard - Medicine Notification and Shopping List - Without Login TC926

    Given I navigated to the savings card page without login
    Then I should be navigated to the home page
   # This has been hidden in the application and can be un-commented once the card returns
   # When I select the Dashboard card of Locked Shipping List Card
   # Then I should be on the create account page
    When I select the toobar item of Dashboard
    And I select the Dashboard card of Medicine Locked Card
    Then I should be on the create account page
    
Scenario: Dashboard - Dashboard medicine search bar TC018

    Given I am on the home page
    When I am on the search page from the dashbard
    And I enter plavix as drug name without using the autocomplete
    Then I should see a list of pharmacies
    
Scenario: Dashboard - Dashboard My WellRX carousel TC019
 
    Given I am on the home page
    When I select the Dashboard card of Savings Card
    And I select the Dashboard card of Profile Card
    Then I should see my profile info
   # This has been hidden in the application and can be un-commented once the card returns 
   # When I select the toobar item of Dashboard
   # And I select the Dashboard card of Shopping List Card
    When I select the toobar item of Dashboard
    And I select the Dashboard card of Notification Card
    Then I should be on Todays Reminders page 
    
Scenario: Dashboard - Dashboard Community carousel TC020
 
    Given I am on the home page
    When I select the Community tab from the dashbard
    And I select the Dashboard card of Share App Card
    
Scenario: Dashboard - Dashboard Recommended carousel Price Medication TC021
 
    Given I am on the home page
    When I select the Recommended tab from the dashbard
    And I select the Dashboard card of Price Meds Tutorial Card
    Then I should be on the last page of Price Meds Tutorial pages
    When I select the Tutorial Skip For Now button
    And I select the Recommended tab from the dashbard
    And I select the Dashboard card of Price Meds Tutorial Card
    Then I should be on the last page of Price Meds Tutorial pages
    When I select the Tutorial Try It button
    Then Let's See The Savings button should be disabled
    
 Scenario: Dashboard - Dashboard Recommended carousel Try Barcode Scanner TC022
 
    Given I am on the home page
    When I select the Recommended tab from the dashbard
    And I select the Dashboard card of Barcode Tutorial Card
    Then I should be on the last page of Barcode Tutorial pages
    When I select the Tutorial Skip For Now button
    And I select the Recommended tab from the dashbard
    And I select the Dashboard card of Barcode Tutorial Card
    Then I should be on the last page of Barcode Tutorial pages
    When I select the Tutorial Try It button
    Then I should be navigated to the onboarding barcode scanner page
    
 Scenario: Dashboard - Dashboard Recommended carousel Watch Videos TC035
 
    Given I am on the home page
    When I select the Recommended tab from the dashbard
    And I select the Dashboard card of Video Card
    Then I should be on the last page of Watch Videos Tutorial pages
    When I select the Tutorial Skip For Now button
    And I select the Recommended tab from the dashbard
    And I select the Dashboard card of Video Card
    Then I should be on the last page of Watch Videos Tutorial pages
    When I select the Tutorial Try It button
    Then I should be on the Drug Videos page for Notfication details
    
    
Scenario: Dashboard - Dashboard Recommended carousel New Feature Card TC023
 
    Given I am on the home page
    When I select the Recommended tab from the dashbard
    When I swipe to the left on the Dashboard page to New Feature Card
    Then I should be navigated to the New Feature Card
    
Scenario: Dashboard - Dashboard Recommended carousel Non Personalized Wellness TC039
 
    Given I am on the home page with a Non Personalized Wellness account
    When I select the Recommended tab from the dashbard
    And I select the Dashboard card of Price Meds Tutorial Card
    Then I should be on the last page of Price Meds Tutorial pages
    When I select the Tutorial Skip For Now button
    And I select the Recommended tab from the dashbard
    And I select the Dashboard card of Price Meds Tutorial Card
    Then I should be on the last page of Price Meds Tutorial pages
    When I select the Tutorial Try It button
    Then Let's See The Savings button should be disabled
    When I choose not to search savings
    And I select the Recommended tab from the dashbard
    Then I should not see these Personalized Wellness cards on the Dashboard
    
Scenario: Dashboard - Dashboard Set Notfication Card TC041
 
    Given I am on the home page
    When I select the toobar item of Medicine Chest
    And I need to dissmiss the Med Chest swipe Tutorial
    Then I should see empty chest message
    When I add a Medications for Med Chest
    And I select Pill Reminder from Med Chest Manual Entry
    When I toggle the Toggle Switch
    And I save the Reminder selections
    When I select the Add Medications Button with additional checks
    Then I should be navigated to the medicine chest page with a list
    When I select the toobar item of Dashboard
    And I select the Dashboard card of Notification Card
    Given I validate the full Dashboard Notfication Card
    When I select the toobar item of Medicine Chest
    And I swipe to delete a Medications from Med Chest list